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
        public Button btLoad { get { return buttonLoad; } }
        public Button btSave { get { return buttonSave; } }
        public TextBox tbFilename { get { return textBoxFilename; } }

        public TextBox tbPattern { get { return textBoxPattern; } }
        public Button btMatch { get { return buttonMatch; } }

        public TextBox tbCount { get { return textBoxCount; } }

        public TextBox tbUrl { get { return textBoxURL; } }
        public ComboBox cbUserAgent { get { return comboBoxUserAgent; } }
        public CheckBox chkIgnoreCase { get { return checkBoxIgnoreCase; } }
        public Button btWeb { get { return buttonWeb; } }

        public Button btClear { get { return buttonClear; } }
        public Button btCopy { get { return buttonCopyContents; } }
        public Button btPaste { get { return buttonPasteContents; } }
        public TextBox tbContents { get { return textBoxContents; } }

        public ListBox lbMatches { get { return listBoxMatches; } }
        public TextBox tbDetails { get { return textBoxMatchDetails; } }

        public DockContentRegEx()
        {
            InitializeComponent();
        }
    }
}