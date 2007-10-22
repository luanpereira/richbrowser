from pluginhost import *
from singleton import *
from command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.Downloader')

from WeifenLuo.WinFormsUI.Docking import *
from RBPGUI.Downloader import *

from rbp_plugin_base import *

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
		else:
			dc = get_singleton(cls)
			dc.Show()

if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('Downloader', DownloaderPlugin())
	