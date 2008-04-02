using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP.Controls
{
    public partial class DCPlugins : DockContent
    {
        public DCPlugins()
        {
            InitializeComponent();
        }

        public void AddPlugin(IPlugin plugin)
        {
            TreeNode node = new TreeNode();
            node.Text = plugin.Title;
            node.Tag = plugin;
            treeViewPlugins.Nodes.Add(node);
        }
    }
}