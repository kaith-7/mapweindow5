using MW5.Attributes.Controls;

namespace MW5.Plugins.TableEditor.Views
{
    partial class JoinsView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinsView));
            this.btnEditJoin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.joinsGrid1 = new MW5.Attributes.Controls.JoinsGrid();
            ((System.ComponentModel.ISupportInitialize)(this.joinsGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditJoin
            // 
            resources.ApplyResources(this.btnEditJoin, "btnEditJoin");
            this.btnEditJoin.Name = "btnEditJoin";
            this.btnEditJoin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnStopAll
            // 
            resources.ApplyResources(this.btnStopAll, "btnStopAll");
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            resources.ApplyResources(this.btnJoin, "btnJoin");
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // joinsGrid1
            // 
            resources.ApplyResources(this.joinsGrid1, "joinsGrid1");
            this.joinsGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.joinsGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.joinsGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.joinsGrid1.BrowseOnly = true;
            this.joinsGrid1.GridLineColor = System.Drawing.Color.White;
            this.joinsGrid1.Name = "joinsGrid1";
            this.joinsGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.joinsGrid1.ShowRowHeaders = false;
            this.joinsGrid1.TableDescriptor.AllowEdit = false;
            this.joinsGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.joinsGrid1.TableOptions.AllowDropDownCell = false;
            this.joinsGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.joinsGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.joinsGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.joinsGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.joinsGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.joinsGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.joinsGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.joinsGrid1.UseRightToLeftCompatibleTextBox = true;
            this.joinsGrid1.VersionInfo = "0.0.1.0";
            this.joinsGrid1.WrapWithPanel = true;
            // 
            // JoinsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.joinsGrid1);
            this.Controls.Add(this.btnEditJoin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnJoin);
            this.Name = "JoinsView";
            ((System.ComponentModel.ISupportInitialize)(this.joinsGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditJoin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnJoin;
        private JoinsGrid joinsGrid1;
    }
}