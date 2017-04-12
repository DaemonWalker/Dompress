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
        }
        public string FileName { get; set; }
        public bool IsDirectory { get; set; }
    }
}
