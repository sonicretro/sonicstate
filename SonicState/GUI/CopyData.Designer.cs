namespace SonicState
{
    partial class frmCopyData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopyData));
            this.nudDataStart = new System.Windows.Forms.NumericUpDown();
            this.nudDataEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDataType = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmnuDataTypeArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuDataTypeLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnuDataTypeCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdDestination = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEnd)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDataStart
            // 
            this.nudDataStart.Enabled = false;
            this.nudDataStart.Hexadecimal = true;
            this.nudDataStart.Location = new System.Drawing.Point(81, 80);
            this.nudDataStart.Maximum = new decimal(new int[] {
            140408,
            0,
            0,
            0});
            this.nudDataStart.Name = "nudDataStart";
            this.nudDataStart.Size = new System.Drawing.Size(70, 20);
            this.nudDataStart.TabIndex = 3;
            // 
            // nudDataEnd
            // 
            this.nudDataEnd.Enabled = false;
            this.nudDataEnd.Hexadecimal = true;
            this.nudDataEnd.Location = new System.Drawing.Point(179, 80);
            this.nudDataEnd.Maximum = new decimal(new int[] {
            140408,
            0,
            0,
            0});
            this.nudDataEnd.Name = "nudDataEnd";
            this.nudDataEnd.Size = new System.Drawing.Size(70, 20);
            this.nudDataEnd.TabIndex = 6;
            this.nudDataEnd.Value = new decimal(new int[] {
            140408,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(81, 54);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(248, 20);
            this.txtDestination.TabIndex = 8;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(335, 52);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Range:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(81, 28);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(282, 20);
            this.txtSource.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Source:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "to";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnCopy,
            this.toolStripSeparator1,
            this.tbtnDataType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(375, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnCopy
            // 
            this.tbtnCopy.Enabled = false;
            this.tbtnCopy.Image = global::SonicState.Properties.Resources.copy_16;
            this.tbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCopy.Name = "tbtnCopy";
            this.tbtnCopy.Size = new System.Drawing.Size(52, 22);
            this.tbtnCopy.Text = "Copy";
            this.tbtnCopy.Click += new System.EventHandler(this.tbtnCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnDataType
            // 
            this.tbtnDataType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuDataTypeArt,
            this.tmnuDataTypeLevel,
            this.toolStripMenuItem1,
            this.tmnuDataTypeCustom});
            this.tbtnDataType.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDataType.Image")));
            this.tbtnDataType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDataType.Name = "tbtnDataType";
            this.tbtnDataType.Size = new System.Drawing.Size(51, 22);
            this.tbtnDataType.Text = "Art";
            // 
            // tmnuDataTypeArt
            // 
            this.tmnuDataTypeArt.Checked = true;
            this.tmnuDataTypeArt.CheckOnClick = true;
            this.tmnuDataTypeArt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tmnuDataTypeArt.Name = "tmnuDataTypeArt";
            this.tmnuDataTypeArt.Size = new System.Drawing.Size(152, 22);
            this.tmnuDataTypeArt.Text = "Art";
            this.tmnuDataTypeArt.Click += new System.EventHandler(this.tbtnDataTypeArt_Click);
            // 
            // tmnuDataTypeLevel
            // 
            this.tmnuDataTypeLevel.CheckOnClick = true;
            this.tmnuDataTypeLevel.Name = "tmnuDataTypeLevel";
            this.tmnuDataTypeLevel.Size = new System.Drawing.Size(152, 22);
            this.tmnuDataTypeLevel.Text = "Level";
            this.tmnuDataTypeLevel.Click += new System.EventHandler(this.tmnuDataTypeLevel_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tmnuDataTypeCustom
            // 
            this.tmnuDataTypeCustom.CheckOnClick = true;
            this.tmnuDataTypeCustom.Name = "tmnuDataTypeCustom";
            this.tmnuDataTypeCustom.Size = new System.Drawing.Size(152, 22);
            this.tmnuDataTypeCustom.Text = "Custom";
            this.tmnuDataTypeCustom.Click += new System.EventHandler(this.tmnuDataTypeCustom_Click);
            // 
            // ofdDestination
            // 
            this.ofdDestination.Filter = "Savestates (*.gs*)|*.gs*|All files (*.*)|*.*";
            this.ofdDestination.Title = "Open Savestate";
            // 
            // frmCopyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 112);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDataEnd);
            this.Controls.Add(this.nudDataStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCopyData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copy Data";
            ((System.ComponentModel.ISupportInitialize)(this.nudDataStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDataEnd)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDataStart;
        private System.Windows.Forms.NumericUpDown nudDataEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tbtnDataType;
        private System.Windows.Forms.ToolStripMenuItem tmnuDataTypeArt;
        private System.Windows.Forms.ToolStripMenuItem tmnuDataTypeLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmnuDataTypeCustom;
        private System.Windows.Forms.OpenFileDialog ofdDestination;
    }
}