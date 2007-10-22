from pluginhost import *
from singleton import *
from command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.Wikiholic')

from WeifenLuo.WinFormsUI.Docking import *
from RBPGUI.Wikiholic import *

from rbp_plugin_base import *

class WikiholicPlugin(BasePlugin):
	def activate(self, args):
		BasePlugin.activate(self, args)
		
		form = args
		self.add_button('Wikiholic', 'Wikiholic', WikiholicCmd(form))
		
		print "activated"
		
	def deactivate(self, args):
		print "deactivated"
		
class WikiholicCmd(ICommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "Wikiholic:"
		dc = DockContentWikiholic()
		dc.TabText = "Wikiholic"
		dc.Show(self.form.dp, DockState.DockLeft)

if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('Wikiholic', WikiholicPlugin())
	