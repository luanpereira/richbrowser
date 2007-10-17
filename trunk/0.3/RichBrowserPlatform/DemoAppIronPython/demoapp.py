#!/usr/bin/python
# -*- coding: euc-kr -*-

import clr
clr.AddReference('System.Drawing')
clr.AddReference('System.Windows.Forms')

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RichBrowserPlatform')

from System import *
from System.Drawing import *
from System.Windows.Forms import *
from System.Runtime.InteropServices import *

from WeifenLuo.WinFormsUI.Docking import *
from RichBrowserPlatform import *

from rbp_csexwb import *
#from rbp_defaultwb import *

class FormMain(Form):
	rbc = None
	dp = None
	
	def __init__(self):
		self.Text = "DemoAppIronPython"
		self.Width = 800
		self.Height = 600
		self.StartPosition = FormStartPosition.CenterScreen
	
		c = self.rbc = RichBrowserControl()
		c.WebBrowserFactory = csExWBWebBrowserFactory()
		#c.WebBrowserFactory = DefaultWebBrowserFactory()
		c.Dock = DockStyle.Fill
		self.Controls.Add(c)
		
		self.dp = self.rbc.dp
		
		c = self.rbc.tbUrl
		c.GotFocus += self.tbUrl_GotFocus
		c.KeyDown += self.tbUrl_KeyDown
		
	def tbUrl_GotFocus(self, sender, event):
		self.rbc.tbUrl.SelectAll();
		
	def tbUrl_KeyDown(self, sender, event):
		if event.KeyCode == Keys.Return:
			dc = DockContentWebBrowser()
			dc.WebBrowser = self.rbc.WebBrowserFactory.Create()
			dc.Show(self.dp, DockState.Document)
			dc.WebBrowser.Navigate(self.rbc.tbUrl.Text)

			event.SuppressKeyPress = True;

form = FormMain()
Application.Run(form)
