using SevenZip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dompress
{
    public partial class FrmCompress : Form
    {
        public FrmCompress()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSelected.Text))
            {
                MessageBox.Show("请选择一个文件或文件夹去压缩！");
            }
            var comPath = tbSelected.Text;
            var filePath = tbSave.Text;
            var pwd = tbPwd.Text;
            var compressor = new SevenZipCompressor()
            {
                CompressionMethod = (CompressionMethod)cbMethod.SelectedIndex,
                CompressionLevel = (CompressionLevel)cbLevel.SelectedIndex
            };
            if (Directory.Exists(comPath))
            {
                if (string.IsNullOrEmpty(pwd))
                {
                    compressor.CompressDirectory(comPath, filePath, true);
                }
                else
                {
                    compressor.CompressDirectory(comPath, filePath, true, pwd);
                }
            }
            if (File.Exists(comPath))
            {
                if (string.IsNullOrEmpty(pwd))
                {
                    compressor.CompressFiles(filePath, comPath);
                }
                else
                {
                    compressor.CompressFilesEncrypted(filePath, pwd, comPath);
                }
            }
            MessageBox.Show("ok!");
        }

        private void chkShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPwd.Checked)
            {
                tbPwd.PasswordChar = '\0';
            }
            else
            {
                tbPwd.PasswordChar = '*';
            }
        }

        private void FrmCompress_Load(object sender, EventArgs e)
        {
            cbLevel.SelectedIndex = 3;
            cbMethod.SelectedIndex = 4;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdSelected.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            tbSelected.Text = ofdSelected.FileName;
        }
    }
}
