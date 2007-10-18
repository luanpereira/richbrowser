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
	
		c = rbc = self.rbc = RichBrowserControl()
		c.WebBrowserFactory = csExWBWebBrowserFactory()
		#c.WebBrowserFactory = DefaultWebBrowserFactory()
		c.Dock = DockStyle.Fill
		self.Controls.Add(c)
		
		self.dp = rbc.dp
		
		c = rbc.tbUrl
		c.GotFocus += self.__tbUrl_GotFocus
		c.KeyDown += self.__tbUrl_KeyDown
		
		c = rbc.btGo
		c.Click += self.__btGo_Click
		
		c = rbc.tbSearch
		c.GotFocus += self.__tbSearch_GotFocus
		c.KeyDown += self.__tbSearch_KeyDown
		
		c = rbc.btSearch
		c.Click += self.__btSearch_Click
		
		c = rbc.miWebSearch
		c.Click += self.__miWebSearch_Click
		
	def __tbUrl_GotFocus(self, sender, event):
		self.rbc.tbUrl.SelectAll();
		
	def __tbUrl_KeyDown(self, sender, event):
		if event.KeyCode == Keys.Return:
			self.__navigate()

			event.SuppressKeyPress = True;

	def __btGo_Click(self, sender, event):
		self.__navigate()
			
	def __tbSearch_GotFocus(self, sender, event):
		self.rbc.tbSearch.SelectAll();
		
	def __tbSearch_KeyDown(self, sender, event):
		if event.KeyCode == Keys.Return:
			self.__search()

			event.SuppressKeyPress = True;

	def __btSearch_Click(self, sender, event):
		self.__search()
			
	def __miWebSearch_Click(self, sender, event):
		self.rbc.tbSearch.Focus()
			
	def __new_web_browser(self):
		dc = DockContentWebBrowser()
		dc.WebBrowser = self.rbc.WebBrowserFactory.Create()
		dc.Show(self.dp, DockState.Document)
		return dc

	def __navigate(self, url = '', dc = None):
		if dc == None:
			dc = self.__new_web_browser()
		if url == '':
			url = self.rbc.tbUrl.Text
		dc.WebBrowser.Navigate(url)
		
	def __search(self, query = '', dc = None):
		if query == '':
			query = self.rbc.tbSearch.Text
		self.__navigate('http://www.google.co.kr/search?q=' + query, dc)
		
form = FormMain()
Application.Run(form)
