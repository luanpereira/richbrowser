from rbp.common.pluginhost import *
from rbp.common.singleton import *
from rbp.common.command import *

import clr

clr.AddReference('System.Windows.Forms')
clr.AddReference('WeifenLuo.WinFormsUI.Docking')

from System.Windows.Forms import *
from WeifenLuo.WinFormsUI.Docking import *

class BasePlugin:
	tc = None
	
	def activate(self, args):
		print "activated"
		form = args
		tsc = form.rbc.tsc
		
		tc = self.tc = ToolStrip()
		tsc.TopToolStripPanel.Controls.Add(tc)
		
	def deactivate(self, args):
		print "deactivated"
		
	def __handle_cmd(self, sender, event):
		get_singleton(Commander).execute(sender.Tag, sender, event)
		
	def add_button(self, text, key, cmd):
		c = ToolStripButton()
		c.Text = text
		c.DisplayStyle = ToolStripItemDisplayStyle.Text
		c.Tag = key
		c.Click += self.__handle_cmd
		self.tc.Items.Add(c)
		get_singleton(Commander).set(key, cmd)
