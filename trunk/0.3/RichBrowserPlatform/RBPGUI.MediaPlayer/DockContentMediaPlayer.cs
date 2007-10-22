using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using AxWMPLib;

namespace RBPGUI.MediaPlayer
{
    public partial class DockContentMediaPlayer : DockContent
    {
        public ToolStrip ts { get { return toolStripMain; } }

        public ToolStripTextBox tbUrl { get { return toolStripTextBoxUrl; } }
        public ToolStripButton btAdd { get { return toolStripButtonAdd; } }

        public ToolStripButton btPlay { get { return toolStripButtonPlay; } }
        public ToolStripButton btStop { get { return toolStripButtonStop; } }

        public AxWindowsMediaPlayer wmp { get { return axWindowsMediaPlayerMain; } }

        public DockContentMediaPlayer()
        {
            InitializeComponent();
        }
    }
}