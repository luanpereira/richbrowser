using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RBPGUI.Downloader
{
    public partial class DockContentDownloader : DockContent
    {
        public ToolStripButton btAdd { get { return toolStripButtonAdd; } }
        public ToolStripButton btRemove { get { return toolStripButtonRemove; } }

        public ToolStripTextBox tbDownPath { get { return toolStripTextBoxDownPath; } }
        public ToolStripButton btBrowse { get { return toolStripButtonBrowse; } }

        public ToolStripButton btStart { get { return toolStripButtonStart; } }
        public ToolStripButton btStop { get { return toolStripButtonStop; } }

        public ListView lv { get { return listViewMain; } }

        public ToolStripProgressBar pb { get { return toolStripProgressBarMain; } }
        public ToolStripLabel lblPercent { get { return toolStripLabelPercent; } }

        public DockContentDownloader()
        {
            InitializeComponent();
        }
    }
}