#!/usr/bin/python
# -*- coding: euc-kr -*-

import clr
clr.AddReference('System.Windows.Forms')

from System.Windows.Forms import *

from rbp_formdeco import *

class FormMain(Form):
	rbc = None
	dp = None
	deco = None
	
	def __init__(self):
		self.Text = "DemoAppIronPython"
		
		d = self.deco = FormDecorator(self)
		d.decorate()
		
if __name__ == '__main__':
	form = FormMain()
	Application.Run(form)
