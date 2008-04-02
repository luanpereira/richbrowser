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
    /// <summary>
    /// 플러그인 표시 패널
    /// </summary>
    public partial class DCPlugins : DockContent
    {
        /// <summary>
        /// 생성자
        /// </summary>
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