from rbp.common.pluginhost import *
from rbp.common.singleton import *
from rbp.common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.RegEx')

from WeifenLuo.WinFormsUI.Docking import *
from RBPGUI.RegEx import *

from rbp.plugin_base import *

class RegExPlugin(BasePlugin):
	def activate(self, args):
		BasePlugin.activate(self, args)
		
		form = args
		self.add_button('RegEx', 'RegEx', RegExCmd(form))
		
		print "activated"
		
	def deactivate(self, args):
		print "deactivated"
		
class RegExCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "RegEx:"
		dc = DockContentRegEx()
		dc.TabText = "RegEx"
		dc.Show(self.form.dp, DockState.Document)

if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('RegEx', RegExPlugin())
	