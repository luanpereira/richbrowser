#!/usr/bin/python
# -*- coding: euc-kr -*-

import clr
clr.AddReference('System.Windows.Forms')

from System.Windows.Forms import *

from rbp_formdeco import *

from singleton import *
from pluginhost import *

class FormMain(Form):
	rbc = None
	dp = None
	deco = None
	
	def __init__(self):
		self.Text = "DemoAppIronPython"
		
		d = self.deco = FormDecorator(self)
		d.decorate()
		
		# pluginhost
		get_singleton(PluginHost).load('plugins', 'rbp_plugin_*.py')
		get_singleton(PluginHost).activate(self)
		
		self.FormClosing += self.__frm_FormClosing
		
	def __frm_FormClosing(self, sender, event):
		get_singleton(PluginHost).deactivate(self)

if __name__ == '__main__':
	form = FormMain()
	Application.Run(form)
