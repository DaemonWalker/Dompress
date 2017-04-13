using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dompress
{
    class BrowserNode : TreeNode
    {
        public BrowserNode(bool isDir)
        {
            if (isDir)
            {
                base.Nodes.Add("temp");
                this.HasExpanded = false;
                this.IsDir = true;
            }
            else
            {
                this.HasExpanded = true;
                this.IsDir = false;
            }
        }
        public bool HasExpanded { get; set; }
        public string Path { get; set; }
        public bool IsPhysical { get; set; }
        public bool IsDir { get; set; }
    }
}
