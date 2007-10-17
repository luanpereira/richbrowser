#!/usr/bin/python
# -*- coding: euc-kr -*-

import clr
clr.AddReference('System.Drawing')
clr.AddReference('System.Windows.Forms')

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RichBrowserControl')
clr.AddReference('RichBrowserPlatform')

from System import *
from System.Drawing import *
from System.Windows.Forms import *
from System.Runtime.InteropServices import *

from WeifenLuo.WinFormsUI.Docking import *
from RichBrowserControl import *
from RichBrowserPlatform import *

clr.AddReference('RBPcsExWB')
from RBPcsExWB import *

#clr.AddReference('RBPDefaultWebBrowser')
#from RBPDefaultWebBrowser import *

class FormMain(Form):
	# PUMzControl
	pc = None
	# DockPanel
	dp = None
	dcCollector = None
	dcDownloader = None
	
	def __init__(self):
		self.Text = "DemoAppIronPython"
		self.Width = 800
		self.Height = 600
		self.StartPosition = FormStartPosition.CenterScreen
	
		c = self.pc = RichBrowserControl()
		c.WebBrowserFactory = csExWBWebBrowserFactory()
		#c.WebBrowserFactory = DefaultWebBrowserFactory()
		c.Dock = DockStyle.Fill
		self.Controls.Add(c)

form = FormMain()
Application.Run(form)
