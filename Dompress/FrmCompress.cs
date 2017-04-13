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
            if (string.IsNullOrWhiteSpace(string.Empty))//tbSelected.Text))
            {
                MessageBox.Show("请选择一个文件或文件夹去压缩！");
            }
            var comPath = "";// tbSelected.Text;
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

            BrowserInit();
        }

        private void BrowserInit()
        {
            tvBrowser.Nodes.Add(new BrowserNode(true)
            {
                Text = Environment.UserName,
                Path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            });

            var myComputer = new BrowserNode(false)
            {
                Text = "我的电脑",
                IsPhysical = false
            };
            foreach (var drive in DriveInfo.GetDrives())
            {
                var diskNode = new BrowserNode(true)
                {
                    Text = drive.Name,
                    Path = drive.Name,
                    IsPhysical = true
                };
                myComputer.Nodes.Add(diskNode);
            }
            tvBrowser.Nodes.Add(myComputer);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdSelected.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //tbSelected.Text = ofdSelected.FileName;
        }

        private void tvBrowser_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node as BrowserNode;
            if (node.HasExpanded)
            {
                return;
            }
            node.Nodes.Clear();
            var dir = new DirectoryInfo(node.Path);
            foreach (var childDir in dir.GetDirectories())
            {
                var dirNode = new BrowserNode(true)
                {
                    Text = childDir.Name,
                    Path = childDir.FullName,
                    IsPhysical = true
                };
                node.Nodes.Add(dirNode);
            }
            node.HasExpanded = true;
        }

        private void tvBrowser_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tvBrowser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void tvBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvBrowser.SelectedNode == null)
            {
                return;
            }

            var node = tvBrowser.SelectedNode as BrowserNode;
            if (node.IsPhysical == false)
            {
                return;
            }

            lvDirInfo.Items.Clear();
            var dir = new DirectoryInfo(node.Path);

            foreach (var child in dir.GetDirectories())
            {
                lvDirInfo.Items.Add(new ListViewItem()
                {
                    Text = child.Name,
                    Tag = child.FullName
                });
            }

            foreach (var file in dir.GetFiles())
            {
                lvDirInfo.Items.Add(new ListViewItem()
                {
                    Text = file.Name,
                    Tag = file.FullName
                });
            }
        }
    }
}
