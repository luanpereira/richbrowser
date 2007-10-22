import clr

clr.AddReference('csExWB')
clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RichBrowserPlatform')

from System.Runtime.InteropServices import *

from csExWB import *
from WeifenLuo.WinFormsUI.Docking import *
from RichBrowserPlatform import *

from rbp.common.command import *
from rbp.common.singleton import *

from rbp.wb_csexwb import *

class ContentAddedCmd(ICommand):

	def wb_DocumentTitleChanged(self, sender, event):
		get_singleton(Commander).execute('DocumentTitleChanged', sender, event)
		
	def wb_ProgressChanged(self, sender, event):
		get_singleton(Commander).execute('ProgressChanged', sender, event)
		
	def wb_DocumentCompleted(self, sender, event):
		get_singleton(Commander).execute('DocumentCompleted', sender, event)
		
	def wb_StatusTextChanged(self, sender, event):
		get_singleton(Commander).execute('StatusTextChanged', sender, event)

	def execute(self, sender, event):
		dc = event.Content
		if isinstance(dc, DockContentWebBrowser):
			wb = dc.WebBrowser.wb
			wb.Tag = dc
			print "wb=" + wb.ToString()
			if isinstance(wb, cEXWB):
				# for csExWB
				wb.TitleChange += self.wb_DocumentTitleChanged
				wb.DocumentComplete += self.wb_DocumentCompleted
				wb.StatusTextChange += self.wb_StatusTextChanged
				wb.ProgressChange += self.wb_ProgressChanged
			else:
				# for Default WebBrowser
				wb.DocumentTitleChanged += self.wb_DocumentTitleChanged
				wb.DocumentCompleted += self.wb_DocumentCompleted
				wb.StatusTextChanged += self.wb_StatusTextChanged
				wb.ProgressChanged += self.wb_ProgressChanged
			
class NewWebBrowserCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		dc = DockContentWebBrowser()
		dc.WebBrowser = self.form.rbc.WebBrowserFactory.Create()
		dc.Show(self.form.dp, DockState.Document)

class CloseWebBrowserCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		dc = self.form.dp.ActiveDocument
		if isinstance(dc, DockContentWebBrowser):
			dc.Close()

class ExitCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		self.form.Close()

class DocumentTitleChangedCmd(ICommand):

	def execute(self, sender, event):
		wb = sender
		dc = wb.Tag
		dc.TabText = wb.DocumentTitle

class ProgressChangedCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		wb = sender
		if isinstance(wb, cEXWB):
			progress = event.progress
		else:
			progress = event.CurrentProgress
		c = self.form.rbc.pb
		if progress > -1:
			c.Visible = True
			c.Value = progress

class DocumentCompletedCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		wb = sender
		if isinstance(wb, cEXWB):
			url = event.url.ToString()
		else:
			url = event.Url.ToString()
		self.form.rbc.pb.Visible = False
		
class StatusTextChangedCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		wb = sender
		if isinstance(wb, cEXWB):
			t = event.text
		else:
			t = wb.StatusText
		url = self.form.rbc.lbMessage.Text = t

class NavigateCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, url):
		if url == '':
			url = self.form.rbc.tbUrl.Text
		dc = self.form.dp.ActiveDocument
		if (dc == None) or isinstance(dc, DockContentWebBrowser) == False:
			get_singleton(Commander).execute('NewWebBrowser', None, None)
			dc = self.form.dp.ActiveDocument
		wb = dc.WebBrowser
		try:
			wb.Navigate(url)
		except COMException:
			#  TODO: fix this error
			print "COMException in Navigate(): url=" + url.ToString()

class SearchCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, query):
		if query == '':
			query = self.form.rbc.tbSearch.Text
		get_singleton(Commander).execute('Navigate', None, 'http://www.google.co.kr/search?q=' + query)
