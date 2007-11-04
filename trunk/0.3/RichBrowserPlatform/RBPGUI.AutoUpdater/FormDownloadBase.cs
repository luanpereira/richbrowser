using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RBPGUI.AutoUpdater
{
    public partial class FormDownloadBase : Form
    {
        public Label lblMessage { get { return labelMessage; } }
        public ProgressBar pb { get { return progressBarMain; } }
        public Button btCancel { get { return buttonCancel; } }
        public Timer tmSkip { get { return timerSkip; } }

        public FormDownloadBase()
        {
            InitializeComponent();
        }
    }
}