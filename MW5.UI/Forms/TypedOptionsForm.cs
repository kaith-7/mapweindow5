// -------------------------------------------------------------------------------------------
// <copyright file="TypedOptionsForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016-2017
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MW5.Shared;

namespace MW5.UI.Forms
{
    public class TypedOptionsForm<T> : OptionsForm
        where T : struct, IConvertible
    {
        private readonly List<RadioButton> _list;

        public TypedOptionsForm(IEnumerable<T> options, string text)
        {
            if (options == null) throw new ArgumentNullException("options");

            var list = options.ToList();

            lblText.Text = text;

            _list = new List<RadioButton>();
            double roomRate = GetDpi();

            for (int i = 0; i < list.Count; i++)
            {
                var button = new RadioButton();
                _list.Add(button);

                button.Parent = this;
                button.Left = 20;
                button.Top = (int)(60 * roomRate) + (int)(23 * roomRate * i);
                //button.Top = 80 + 23 * i;
                button.Text = list[i].EnumToString();
                button.AutoSize = true;
                button.Tag = list[i];
            }

            Height = (int)(150 * roomRate) + (int)(23 * roomRate * list.Count);

            this.button1.Location = new System.Drawing.Point((int)(190 * roomRate), (int)(60 * roomRate) + (int)(23 * roomRate * list.Count));

            this.button2.Location = new System.Drawing.Point((int)(310 * roomRate), (int)(60 * roomRate) + (int)(23 * roomRate * list.Count));
        }

        private double GetDpi()
        {
            double ZoomRate = 1;
            Graphics graphics = CreateGraphics();
            var dpiX = graphics.DpiX;
            var dpiY = graphics.DpiY;
            if (dpiX == 90)
                ZoomRate = 1;
            else if (dpiX == 120)
                ZoomRate = 1.2;
            else if (dpiX == 144)
                ZoomRate = 1.4;
            else if (dpiX == 168)
                ZoomRate = 1.5;
            else if (dpiX == 192)
                ZoomRate = 1.6;
            else if (dpiX == 216)
                ZoomRate = 1.8;

            return ZoomRate;
        }
        public T SelectedItem
        {
            get
            {
                foreach (RadioButton t in _list)
                {
                    if (t.Checked)
                    {
                        return (T)t.Tag;
                    }
                }

                return default(T);
            }

            set
            {
                var button = _list.FirstOrDefault(item => ((T)item.Tag).Equals(value));
                if (button != null)
                {
                    button.Checked = true;
                }
            }
        }

        public Color SelectedColor
        {
            get { return colorPicker.Color; }
            set { colorPicker.Color = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lblColorText
            // 
            this.lblColorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // colorPicker
            // 
            this.colorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorPicker.Size = new System.Drawing.Size(74, 22);
            // 
            // TypedOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(378, 293);
            this.Name = "TypedOptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TypedOptionsForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}