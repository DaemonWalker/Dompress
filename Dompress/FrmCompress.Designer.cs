namespace Dompress
{
    partial class FrmCompress
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkShowPwd = new System.Windows.Forms.CheckBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdSelected = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvBrowser = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvDirInfo = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "压缩文件存放路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "压缩密码";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(980, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "选择";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkShowPwd
            // 
            this.chkShowPwd.AutoSize = true;
            this.chkShowPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.chkShowPwd.Location = new System.Drawing.Point(852, 24);
            this.chkShowPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowPwd.Name = "chkShowPwd";
            this.chkShowPwd.Size = new System.Drawing.Size(175, 37);
            this.chkShowPwd.TabIndex = 8;
            this.chkShowPwd.Text = "显示密码";
            this.chkShowPwd.UseVisualStyleBackColor = true;
            this.chkShowPwd.CheckedChanged += new System.EventHandler(this.chkShowPwd_CheckedChanged);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(352, 32);
            this.btnCompress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(172, 92);
            this.btnCompress.TabIndex = 9;
            this.btnCompress.Text = "开始";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.tbPwd.Location = new System.Drawing.Point(176, 22);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(670, 44);
            this.tbPwd.TabIndex = 10;
            // 
            // tbSave
            // 
            this.tbSave.Font = new System.Drawing.Font("宋体", 12F);
            this.tbSave.Location = new System.Drawing.Point(304, 10);
            this.tbSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(670, 44);
            this.tbSave.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "压缩质量";
            // 
            // cbLevel
            // 
            this.cbLevel.Font = new System.Drawing.Font("宋体", 12F);
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "打包",
            "很低",
            "低",
            "普通",
            "高",
            "最高"});
            this.cbLevel.Location = new System.Drawing.Point(178, 112);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(332, 41);
            this.cbLevel.TabIndex = 14;
            // 
            // cbMethod
            // 
            this.cbMethod.Font = new System.Drawing.Font("宋体", 12F);
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "Copy",
            "Deflate",
            "Deflate64",
            "BZip2",
            "Lzma",
            "Lzma2",
            "Ppmd",
            "Default"});
            this.cbMethod.Location = new System.Drawing.Point(696, 112);
            this.cbMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(332, 41);
            this.cbMethod.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(546, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "压缩算法";
            // 
            // ofdSelected
            // 
            this.ofdSelected.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 608);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(8, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1224, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 74);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvDirInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 475);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 15;
            // 
            // tvBrowser
            // 
            this.tvBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBrowser.Location = new System.Drawing.Point(0, 0);
            this.tvBrowser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvBrowser.Name = "tvBrowser";
            this.tvBrowser.Size = new System.Drawing.Size(404, 475);
            this.tvBrowser.TabIndex = 12;
            this.tvBrowser.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBrowser_BeforeExpand);
            this.tvBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBrowser_AfterSelect);
            this.tvBrowser.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvBrowser_NodeMouseClick);
            this.tvBrowser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvBrowser_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.tbSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 70);
            this.panel2.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbMethod);
            this.tabPage2.Controls.Add(this.chkShowPwd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbPwd);
            this.tabPage2.Controls.Add(this.cbLevel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 12F);
            this.tabPage2.Location = new System.Drawing.Point(8, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1224, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 140);
            this.panel1.TabIndex = 18;
            // 
            // lvDirInfo
            // 
            this.lvDirInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDirInfo.Location = new System.Drawing.Point(0, 0);
            this.lvDirInfo.Name = "lvDirInfo";
            this.lvDirInfo.Size = new System.Drawing.Size(804, 475);
            this.lvDirInfo.TabIndex = 0;
            this.lvDirInfo.UseCompatibleStateImageBehavior = false;
            this.lvDirInfo.View = System.Windows.Forms.View.List;
            // 
            // FrmCompress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 748);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCompress";
            this.Text = "FrmCompress";
            this.Load += new System.EventHandler(this.FrmCompress_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkShowPwd;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdSelected;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvBrowser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDirInfo;
    }
}