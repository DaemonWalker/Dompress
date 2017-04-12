
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
    public partial class FrmMain : Form
    {
        private SevenZipExtractor extractor;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                extractor = new SevenZipExtractor(ofdOpen.FileName);
                foreach (var item in extractor.ArchiveFileData)
                {
                    if (item.FileName.Contains('\\') == false && item.IsDirectory)
                    {
                        var node = new DomNode(item.FileName, item.FileName, item.IsDirectory);
                        tvFile.Nodes.Add(node);
                        node.Tag = item.FileName;
                    }
                }
                foreach (var item in extractor.ArchiveFileData)
                {
                    var path = item.FileName.Split('\\');
                    CreateNode(path, 0, null);
                }


            }
        }

        private void CreateNode(string[] path, int index, TreeNode root)
        {
            if (index >= path.Length)
            {
                return;
            }
            TreeNodeCollection collection = null;
            if (index == 0)
            {
                collection = tvFile.Nodes;
            }
            else
            {
                collection = root.Nodes;
            }
            DomNode node = null;
            if (collection != null)
            {
                foreach (TreeNode temp in collection)
                {
                    if (temp.Text == path[index])
                    {
                        CreateNode(path, index + 1, temp);
                        node = temp as DomNode;
                        break;
                    }
                }
            }
            if (node == null)
            {
                node = new DomNode() { Text = path[index] };
                var filePath = new StringBuilder();
                for (int i = 0; i <= index; i++)
                {
                    filePath.AppendFormat(@"{0}\", path[i]);
                }

                if (path.Length == index + 1)
                {
                    filePath.Length = filePath.Length - 1;
                    node.FileName = filePath.ToString();
                    node.IsDirectory = false;
                }
                else
                {
                    node.FileName = filePath.ToString();
                    node.IsDirectory = true;
                }
                collection.Add(node);
                CreateNode(path, index + 1, node);
            }

        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            if (fbdExtPath.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var path = fbdExtPath.SelectedPath;
            if (tvFile.SelectedNode == null)
            {
                extractor.ExtractArchive(path);
                return;
            }
            var node = tvFile.SelectedNode;
            ExtFiles(node, new List<string>() { path }, 0);
        }

        private void ExtFiles(TreeNode node, List<string> curPath, int deepth)
        {
            var dNode = node as DomNode;
            for (int i = curPath.Count - 1; i > deepth; i--)
            {
                curPath.RemoveAt(i);
            }
            curPath.Add(dNode.Text);
            var fullPath = Path.Combine(curPath.ToArray());
            if (dNode.IsDirectory)
            {
                if (Directory.Exists(fullPath) == false)
                {
                    Directory.CreateDirectory(fullPath);
                }
            }
            else
            {
                if (File.Exists(fullPath) == true)
                {
                    File.Delete(fullPath);
                }
                var fileStream = new FileStream(fullPath, FileMode.Create);
                extractor.ExtractFile(dNode.FileName, fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
            foreach (TreeNode child in node.Nodes)
            {
                ExtFiles(child, curPath, deepth + 1);
            }
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            tvFile.SelectedNode = null;
        }
    }
}
