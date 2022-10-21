using MW5.Configuration.Plugins;
using MW5.UI.Controls;

namespace MW5.Configuration
{
    partial class PluginsConfigPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsConfigPage));
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pluginGrid1 = new MW5.Configuration.PluginGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            resources.ApplyResources(this.splitContainerAdv1, "splitContainerAdv1");
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel1, "splitContainerAdv1.Panel1");
            this.splitContainerAdv1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerAdv1.Panel2
            // 
            resources.ApplyResources(this.splitContainerAdv1.Panel2, "splitContainerAdv1.Panel2");
            this.splitContainerAdv1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerAdv1.SplitterDistance = 275;
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pluginGrid1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // pluginGrid1
            // 
            resources.ApplyResources(this.pluginGrid1, "pluginGrid1");
            this.pluginGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.pluginGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pluginGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pluginGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pluginGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pluginGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pluginGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.pluginGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.pluginGrid1.GridLineColor = System.Drawing.Color.White;
            this.pluginGrid1.Name = "pluginGrid1";
            this.pluginGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.pluginGrid1.ShowRowHeaders = false;
            this.pluginGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.pluginGrid1.TableOptions.AllowDropDownCell = true;
            this.pluginGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.pluginGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.pluginGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.pluginGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pluginGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.pluginGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.pluginGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.pluginGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.pluginGrid1.UseRightToLeftCompatibleTextBox = true;
            this.pluginGrid1.VersionInfo = "5.0.1.0";
            this.pluginGrid1.WrapWithPanel = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.chkSelectAll);
            this.panel2.Name = "panel2";
            // 
            // chkSelectAll
            // 
            resources.ApplyResources(this.chkSelectAll, "chkSelectAll");
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // PluginsConfigPage
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerAdv1);
            this.Name = "PluginsConfigPage";
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pluginGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PluginGrid pluginGrid1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
