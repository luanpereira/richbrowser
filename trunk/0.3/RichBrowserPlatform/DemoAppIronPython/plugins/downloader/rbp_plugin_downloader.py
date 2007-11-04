from common.pluginhost import *
from common.singleton import *
from common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.Downloader')

from System.IO import *
from System.Net import *

from WeifenLuo.WinFormsUI.Docking import *
from RBPGUI.Downloader import *

from rbp.plugin_base import *

class DownloaderPlugin(BasePlugin):
	def activate(self, args):
		BasePlugin.activate(self, args)
		
		form = args
		self.add_button('Downloader', 'Downloader', DownloaderCmd(form))

		print "activated"
		
	def deactivate(self, args):
		print "deactivated"
		
class DownloaderCmd(ICommand):
	form = None
	wc = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "Downloader:"
		cls = DockContentDownloader
		if has_singleton(cls) == False:
			dc = get_singleton(cls)
			dc.TabText = "Downloader"
			dc.HideOnClose = True
			dc.Show(self.form.dp, DockState.DockLeft)
			
			c = dc.lv
			c.View = View.Details
			c.Columns.Add("URL")
			
			c = dc.btAdd
			c.Click += self.__btAdd_Click
			
			c = dc.btRemove
			c.Click += self.__btRemove_Click
			
			c = dc.btBrowse
			c.Click += self.__btBrowse_Click
			
			c = dc.btStart
			c.Click += self.__btStart_Click
			
			c = dc.btStop
			c.Click += self.__btStop_Click
			
			c = self.wc = WebClient()
			c.DownloadFileCompleted += self.__wc_DownloadFileAsyncCompleted
			c.DownloadProgressChanged += self.__wc_DownloadProgressChanged
		
		else:
			dc = get_singleton(cls)
			dc.Show()
			
	def __wc_DownloadFileAsyncCompleted(self, sender, event):
		print "completed"
		cls = DockContentDownloader
		dc = get_singleton(cls)
		lv = dc.lv
		if event.Cancelled == True:
			print "canceled."
		else:
			lv.Items.Remove(lv.Items[0])
			if lv.Items.Count > 0:
				self.__download_first_one()
			else:
				print "all done."
		
	
	def __wc_DownloadProgressChanged(self, sender, event):
		cls = DockContentDownloader
		dc = get_singleton(cls)
		pb = dc.pb
		pb.Value = event.ProgressPercentage
		lbl = dc.lblPercent
		lbl.Text = pb.Value.ToString() + '%'
		
	def __download_first_one(self):
		cls = DockContentDownloader
		dc = get_singleton(cls)
		lv = dc.lv
		tbDownPath = dc.tbDownPath
		if lv.Items.Count > 0:
			try:
				uri = Uri(lv.Items[0].Text)
				filename = tbDownPath.Text + "\\" + Path.GetFileName(uri.LocalPath)
				print "filename=" + filename
				self.wc.DownloadFileAsync(uri, filename)
				print "started"
			except UriFormatException:
				MessageBox.Show('uri format error')
		
	def __btAdd_Click(self, sender, event):
		dlg = FormInputBox();
		dlg.Title = 'URL?'
		if dlg.ShowDialog() == DialogResult.OK:
			print dlg.InputText
			cls = DockContentDownloader
			dc = get_singleton(cls)
			lv = dc.lv
			lv.Items.Add(dlg.InputText)

	def __btRemove_Click(self, sender, event):
		print "remove"
		cls = DockContentDownloader
		dc = get_singleton(cls)
		lv = dc.lv
		for item in lv.SelectedItems:
			lv.Items.Remove(item)

	def __btBrowse_Click(self, sender, event):
		print "browse"
		dlg = FolderBrowserDialog()
		if dlg.ShowDialog() == DialogResult.OK:
			cls = DockContentDownloader
			dc = get_singleton(cls)
			tb = dc.tbDownPath
			tb.Text = dlg.SelectedPath
	
	def __btStart_Click(self, sender, event):
		print "start"
		self.__download_first_one()

	def __btStop_Click(self, sender, event):
		print "stop"
		self.wc.CancelAsync()
	
if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('Downloader', DownloaderPlugin())
	