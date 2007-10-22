using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RBPGUI.RegEx
{
    public partial class DockContentRegEx : DockContent
    {
    	public ToolStrip ts { get { return toolStrip1; } }
    	
    	public ToolStripButton btLoad { get { return toolStripButtonLoad; } }
    	public ToolStripButton btSave { get { return toolStripButtonSave; } }
    	
    	public ToolStripTextBox tbPattern { get { return toolStripTextBoxPattern; } }
    	public ToolStripButton btMatch { get { return toolStripButtonMatch; } }

    	public ToolStripLabel lbCount { get { return toolStripLabelCount; } }

    	public ToolStripTextBox tbUserAgent { get { return toolStripTextBoxUserAgent; } }
    	public ToolStripButton btIgnoreCase { get { return toolStripButtonIgnoreCase; } }
    	
    	public ToolStripButton btClear { get { return toolStripButtonMatch; } }
    	
    	public ToolStripButton btCopy { get { return toolStripButtonCopy; } }
    	public ToolStripButton btPaste { get { return toolStripButtonPaste; } }
    	
    	public DockContentRegEx()
        {
            InitializeComponent();
        }
    }
}
