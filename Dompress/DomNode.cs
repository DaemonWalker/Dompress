using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dompress
{
    public class DomNode : TreeNode
    {
        public DomNode() { }
        public DomNode(string text, string fileName, bool isDirectory)
        {
            base.Text = text;
            this.FileName = fileName;
            this.IsDirectory = isDirectory;
            this.IsRoot = false;
        }
        public DomNode(bool isRoot)
        {
            base.Text = "...";
            this.IsRoot = isRoot;
        }
        public string FileName { get; set; }
        public bool IsDirectory { get; set; }
        public bool IsRoot { get; set; }
    }
}
