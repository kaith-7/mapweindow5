using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MW5.Plugins.PictureView.Views
{
    public partial class LookPicture : Form
    {
        public LookPicture(string picpath)
        {
            InitializeComponent();
            panel1.Layout += Panel1_Layout;
            Initialize(picpath);
        }

        private void Panel1_Layout(object sender, LayoutEventArgs e)
        {
            Control parent = sender as Control;
            Rectangle parentDisplayRectangle = parent.DisplayRectangle;
            Point nextControlLocation = parentDisplayRectangle.Location;

            foreach (Control c in parent.Controls)
            {
                if (!c.Visible)
                {
                    continue;
                }
                
                nextControlLocation.Offset(c.Margin.Left, c.Margin.Top);
                c.Location = nextControlLocation;
                int w = panel1.Width - c.Margin.Left - c.Margin.Right;
                c.Height = (int)(c.Height * ((float)w / c.Width));
                c.Width = w;

                if (c.AutoSize)
                {
                    c.Size = c.GetPreferredSize(parentDisplayRectangle.Size);
                }

                nextControlLocation.X = parentDisplayRectangle.X;
                nextControlLocation.Y += c.Height + c.Margin.Top;
            }
        }

        public void SetPicturePath(string picturespath)
        {
            Initialize(picturespath);
        }
        
        static private ConcurrentDictionary<string, Image> imagesCache = new ConcurrentDictionary<string, Image>();

        private Image GetImage(string filename)
        {
            if (!imagesCache.ContainsKey(filename))
            {
                using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    imagesCache[filename] = Image.FromStream(fs);
                }
            }
            return imagesCache[filename];
        }

        private void Initialize(string picturespath)
        {
            DirectoryInfo folder = new DirectoryInfo(picturespath);
            panel1.Controls.Clear();
            if (folder.Exists)
            { 
                FileInfo[] files = folder.GetFiles("*.jpg", SearchOption.AllDirectories);
                panel1.AutoScroll = true;
                panel1.VerticalScroll.Enabled = false;
            
                foreach (FileInfo file in files)
                {
                    PictureBox PB = new PictureBox();
                    Image image1 = GetImage(file.FullName);
                    PB.BorderStyle = BorderStyle.FixedSingle;
                    PB.SizeMode = PictureBoxSizeMode.Zoom;
                    PB.Name = file.FullName;
                    PB.Width = panel1.Width - PB.Margin.Left - PB.Margin.Right;
                    PB.Height = (int)(image1.Height * ((float)PB.Width / image1.Width)); 

                    PB.Image = image1;
                    PB.Click += new EventHandler(PB_Click); //查看大图的点击事件
                    PB.MouseHover += new EventHandler(PB_tooltip); //查看图片属性的点击事件

                    panel1.Controls.Add(PB);
                }
            
                if (panel1.Controls.Count > 0)
                {
                    SetPicture((PictureBox)panel1.Controls[0]);
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.hello_icon;
            }
        }
        //panel中的点击事件，在picturebox中显示点击图片
        private void PB_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SetPicture(pic);
        }

        private void SetPicture(PictureBox pic)
        {
            pictureBox1.Image = GetImage(pic.Name);
        }

        //panel中显示图片属性
        private void PB_tooltip(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            //读取属性文件
            string[] pertyname = { "longitude", "latitude", "utctimestamp"};
            string[] showname = { "经度", "纬度", "拍摄时间" };
            string[] showinfo = { "", "", "" }; //添加要素，三个list都要添加

            string pertyfile = pic.Name.Replace("jpg", "properties");
            StreamReader readf = new StreamReader(pertyfile, Encoding.UTF8);
            while (!readf.EndOfStream)
            {
                string[] pertyline = readf.ReadLine().Split(new[] { "=" }, StringSplitOptions.None);
                if (pertyline.Length > 1)
                {
                    if (pertyname.Contains(pertyline.First()))
                    {
                        int pertyindex = pertyname.ToList().IndexOf(pertyline.First());
                        if (showname[pertyindex].Contains("时间"))
                        {
                            string pictime = DateTime.ParseExact(pertyline[1], "yyyyMMdd_HHmmss", CultureInfo.CurrentCulture).AddHours(8).ToString("yyyy-MM-dd HH:mm:ss");
                            showinfo[pertyindex] = pictime;
                        }
                        else
                        {
                            showinfo[pertyindex] = pertyline[1];
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            readf.Close();
            //构造显示对话框
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.InitialDelay = 500;
            toolTip1.AutoPopDelay = 10000;
            string showstr= "";
            int j = 0;
            foreach (string aperty in showname)
            {
                showstr += aperty + ": " + showinfo[j] + "\n";
                j += 1;
            }
            toolTip1.SetToolTip(pic, showstr);
        }

        //旋转
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Invalidate();
        }

        private void LookPicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void LookPicture_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
