from rbp.common.pluginhost import *
from rbp.common.singleton import *
from rbp.common.command import *

class FirstPlugin:
	def activate(self, args):
		print "FP: activated"
		
	def deactivate(self, args):
		print "FP: deactivated"
		
if __name__ == '__main__':
	pass
else:
	get_singleton(PluginHost).add('first', FirstPlugin())
	