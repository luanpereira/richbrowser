#!/usr/bin/python
# -*- coding: euc-kr -*-

import clr
clr.AddReference('System.Windows.Forms')

from System import *
import sys
sys.path.append(Environment.CurrentDirectory + '\\rbp')

clr.AddReference('RichBrowserPlatform')
clr.AddReference('WeifenLuo.WinFormsUI.Docking')

from System.Windows.Forms import *

from WeifenLuo.WinFormsUI.Docking import *
from RichBrowserPlatform import *

from rbp.wb_csexwb import *
from rbp.wb_default import *

from rbp.common.singleton import *
from rbp.common.command import *
from rbp.cmd import *

class FormDecorator:
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def decorate(self):
		form = self.form
		print form.Text
		
		form.Width = 800
		form.Height = 600
		form.StartPosition = FormStartPosition.CenterScreen
	
		c = rbc = form.rbc = RichBrowserControl()
		c.WebBrowserFactory = csExWBWebBrowserFactory()
		#c.WebBrowserFactory = DefaultWebBrowserFactory()
		c.Dock = DockStyle.Fill
		form.Controls.Add(c)
		
		dp = form.dp = rbc.dp
		dp.ContentAdded += self.__dp_ContentAdded;
		
		self.__set_item(rbc.miNew, 'NewWebBrowser', 'New', None, Keys.Control | Keys.T)
		self.__set_item(rbc.miClose, 'CloseWebBrowser', 'Close', None, Keys.Control | Keys.W)
		self.__set_item(rbc.miExit, 'Exit', 'Exit')
		
		self.__set_item(rbc.btNew, 'NewWebBrowser', 'New', Image.FromFile("res\\new_16.png"))
		self.__set_item(rbc.btBack, 'Back', 'Back', Image.FromFile("res\\back_16.png"))
		self.__set_item(rbc.btForward, 'Forward', 'Forward', Image.FromFile("res\\forwd_16.png"))
		self.__set_item(rbc.btStop, 'Stop', 'Stop', Image.FromFile("res\\cancl_16.png"))
		self.__set_item(rbc.btRefresh, 'Refresh', 'Refresh', Image.FromFile("res\\ref_16.png"))
		self.__set_item(rbc.btHome, 'Home', 'Home', Image.FromFile("res\\home_16.png"))
		
		c = rbc.tbUrl
		c.GotFocus += self.__tbUrl_GotFocus
		c.KeyDown += self.__tbUrl_KeyDown
		
		c = rbc.btGo
		c.Image = Image.FromFile("res\\Play.png")
		c.Click += self.__btGo_Click
		
		c = rbc.tbSearch
		c.GotFocus += self.__tbSearch_GotFocus
		c.KeyDown += self.__tbSearch_KeyDown
		
		c = rbc.btSearch
		c.Image = Image.FromFile("res\\Search.png")
		c.Click += self.__btSearch_Click
		
		c = rbc.miWebSearch
		c.Click += self.__miWebSearch_Click
		
		get_singleton(Commander).set('ContentAdded', ContentAddedCmd())
		
		get_singleton(Commander).set('NewWebBrowser', NewWebBrowserCmd(form))
		get_singleton(Commander).set('CloseWebBrowser', CloseWebBrowserCmd(form))
		get_singleton(Commander).set('Exit', ExitCmd(form))
		
		get_singleton(Commander).set('DocumentTitleChanged', DocumentTitleChangedCmd())
		get_singleton(Commander).set('ProgressChanged', ProgressChangedCmd(form))
		get_singleton(Commander).set('DocumentCompleted', DocumentCompletedCmd(form))
		get_singleton(Commander).set('StatusTextChanged', StatusTextChangedCmd(form))
		
		get_singleton(Commander).set('Navigate', NavigateCmd(form))
		get_singleton(Commander).set('Search', SearchCmd(form))

	def __handle_cmd(self, sender, event):
		get_singleton(Commander).execute(sender.Tag, sender, event)
	
	def __set_item(self, mi, key, text = None, image = None, sk = None):
		c = mi
		c.Tag = key
		c.Click += self.__handle_cmd
		if text != None:
			c.Text = text
		if image != None:
			c.Image = image
		if sk != None:
			c.ShortcutKeys = sk
	
	def __dp_ContentAdded(self, sender, event):
		get_singleton(Commander).execute('ContentAdded', sender, event)
	
	def __btGo_Click(self, sender, event):
		get_singleton(Commander).execute('Navigate', sender, '')
			
	def __btSearch_Click(self, sender, event):
		get_singleton(Commander).execute('Search', sender, '')
			
	def __tbUrl_GotFocus(self, sender, event):
		self.form.rbc.tbUrl.SelectAll();
		
	def __tbUrl_KeyDown(self, sender, event):
		if event.KeyCode == Keys.Return:
			get_singleton(Commander).execute('Navigate', sender, '')
			
			event.SuppressKeyPress = True;

	def __tbSearch_GotFocus(self, sender, event):
		self.form.rbc.tbSearch.SelectAll();
		
	def __tbSearch_KeyDown(self, sender, event):
		if event.KeyCode == Keys.Return:
			get_singleton(Commander).execute('Search', None, '')

			event.SuppressKeyPress = True;

	def __miWebSearch_Click(self, sender, event):
		self.form.rbc.tbSearch.Focus()
		
if __name__ == '__main__':
	f = Form()
	f.Text = "test"
	fd = FormDecorator(f)
	fd.decorate()
