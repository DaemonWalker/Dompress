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
            this.tvFile = new System.Windows.Forms.TreeView();
            this.menuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdExtPath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.fbdComPath = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdComName = new System.Windows.Forms.SaveFileDialog();
            this.menuFile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // tvFile
            // 
            this.tvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFile.ContextMenuStrip = this.menuFile;
            this.tvFile.Font = new System.Drawing.Font("宋体", 12F);
            this.tvFile.Location = new System.Drawing.Point(15, 19);
            this.tvFile.Margin = new System.Windows.Forms.Padding(6);
            this.tvFile.Name = "tvFile";
            this.tvFile.Size = new System.Drawing.Size(1687, 758);
            this.tvFile.TabIndex = 2;
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClear});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(185, 40);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(184, 36);
            this.tsmiClear.Text = "清除选择";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1717, 792);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCom);
            this.panel1.Controls.Add(this.btnExt);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1717, 141);
            this.panel1.TabIndex = 6;
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(215, 12);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(175, 114);
            this.btnExt.TabIndex = 1;
            this.btnExt.Text = "解压";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(175, 114);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(414, 12);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(175, 114);
            this.btnCom.TabIndex = 2;
            this.btnCom.Text = "压缩";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 933);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuFile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.ContextMenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.FolderBrowserDialog fbdExtPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.FolderBrowserDialog fbdComPath;
        private System.Windows.Forms.SaveFileDialog sfdComName;
    }
}

