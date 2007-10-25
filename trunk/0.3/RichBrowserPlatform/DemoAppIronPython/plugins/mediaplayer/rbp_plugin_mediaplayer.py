from common.pluginhost import *
from common.singleton import *
from common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.MediaPlayer')

from WeifenLuo.WinFormsUI.Docking import *
from RBPGUI.MediaPlayer import *

from rbp.plugin_base import *

class MediaPlayerPlugin(BasePlugin):
	def activate(self, args):
		print "MP: activated"

		BasePlugin.activate(self, args)
		form = args
		
		self.add_button('MediaPlayer', 'MediaPlayer', MediaPlayerCmd(form))
		
	def deactivate(self, args):
		print "MP: deactivated"
		
class MediaPlayerCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "MP:"
		cls = DockContentMediaPlayer
		if has_singleton(cls) == False:
			# wmp settings
			# ref: http://www.streamalot.com/wm-embed.shtml
		
			dc = get_singleton(cls)
			dc.TabText = "MediaPlayer"
			dc.HideOnClose = True
			dc.Show(self.form.dp, DockState.DockLeft)
			
			c = dc.btAdd
			c.Text = 'Add'
			c.Click += self.__btAdd_Click
			
			c = dc.btPlay
			c.Text = 'Play'
			c.Click += self.__btPlay_Click
			
			c = dc.btStop
			c.Text = 'Stop'
			c.Click += self.__btStop_Click
			
			c = dc.wmp
			c.settings.enableErrorDialogs = True
			c.ErrorEvent += self.__wmp_Error
			
		else:
			dc = get_singleton(cls)
			dc.Show()
			
	def __btAdd_Click(self, sender, event):
		cls = DockContentMediaPlayer
		dc = get_singleton(cls)
		wmp = dc.wmp

		url = dc.tbUrl.Text

		# playlist 사용할 때
		pl = wmp.newPlaylist('playlist', '')
		wmp.currentPlaylist = pl
		pl.appendItem(wmp.newMedia(url))
		
		"""
		# url 하나인 경우
		wmp.URL = url
		"""
		
		"""
		# 웹 브라우저에서 띄울 때
		wmp.launchURL(url)
		"""
		
		wmp.Ctlcontrols.play()
			
	def __btPlay_Click(self, sender, event):
		cls = DockContentMediaPlayer
		dc = get_singleton(cls)
		wmp = dc.wmp
		wmp.Ctlcontrols.play()
			
	def __btStop_Click(self, sender, event):
		cls = DockContentMediaPlayer
		dc = get_singleton(cls)
		wmp = dc.wmp
		wmp.Ctlcontrols.stop()
			
	def __wmp_Error(self, sender, event):
		wmp = sender
		print "[ERROR] count=" + wmp.Error.errorCount.ToString()
		for i in range(wmp.Error.errorCount):
			print "[ERROR] i=" + i.ToString()
			print "[ERROR] msg=" + wmp.Error.get_Item(i).errorDescription
			item = wmp.Error.get_Item(i + 1)
			if item == None:
				print "[ERROR] item is null"
			else:
				print "[ERROR] item=" + item.ToString()
				print "[ERROR] msg=" + item.errorDescription
		
if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('MediaPlayer', MediaPlayerPlugin())
	