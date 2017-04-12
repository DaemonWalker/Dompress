namespace Dompress
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbOpenPath = new System.Windows.Forms.TextBox();
            this.tvFile = new System.Windows.Forms.TreeView();
            this.btnExt = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdExtPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOpen.Location = new System.Drawing.Point(412, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "button1";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tbOpenPath
            // 
            this.tbOpenPath.Font = new System.Drawing.Font("宋体", 12F);
            this.tbOpenPath.Location = new System.Drawing.Point(37, 22);
            this.tbOpenPath.Name = "tbOpenPath";
            this.tbOpenPath.Size = new System.Drawing.Size(328, 26);
            this.tbOpenPath.TabIndex = 1;
            // 
            // tvFile
            // 
            this.tvFile.ContextMenuStrip = this.menuFile;
            this.tvFile.Font = new System.Drawing.Font("宋体", 12F);
            this.tvFile.Location = new System.Drawing.Point(37, 81);
            this.tvFile.Name = "tvFile";
            this.tvFile.Size = new System.Drawing.Size(328, 160);
            this.tvFile.TabIndex = 2;
            // 
            // btnExt
            // 
            this.btnExt.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExt.Location = new System.Drawing.Point(517, 22);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(75, 23);
            this.btnExt.TabIndex = 3;
            this.btnExt.Text = "button1";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClear});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(124, 22);
            this.tsmiClear.Text = "清除选择";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.tvFile);
            this.Controls.Add(this.tbOpenPath);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbOpenPath;
        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.ContextMenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.FolderBrowserDialog fbdExtPath;
    }
}

