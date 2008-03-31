#!/usr/bin/python
# -*- coding: euc-kr -*-

import sys

# clr.Path는 deprecated 됨
# ref: http://www.codeplex.com/Wiki/View.aspx?ProjectName=IronPython&title=RC1%20Release%20Notes
#clr.Path.Add(System.Environment.CurrentDirectory + '\\plugins\\isky')

from System import *
from System.IO import *

class PluginHost:
	info = 'host'
	plugins = {}
	plugin_path = ''
	
	def load(self, path, format):
		for folder in Directory.GetDirectories(path, "*.*"):
			for filename in Directory.GetFiles(folder, format):
				try:
					self.plugin_path = Environment.CurrentDirectory + '\\' + folder
					print "plugin_path=" + self.plugin_path
					sys.path.append(self.plugin_path)
					print "module_file=" + filename
					#print Path.GetExtension(filename)
					#module_name = Path.GetFileNameWithoutExtension(filename)
					module_name = filename.Replace(Path.GetExtension(filename), "")
					module_name = module_name.Replace("\\", ".")
					#module_name = "plugins." + Path.GetDirectoryName(folder) + "." + module_name
					print "module_name=" + module_name
					module = __import__(module_name)
					#p = Plugin()
					#p.plug()
					print "PH: loaded"
				except Exception, inst:
					print "[ERROR] msg=", inst
					print "[ERROR] PH: error in loading module: module=" + module_name
	
	def add(self, key, plugin):
		self.plugins[key] = plugin
		print "plugin_path=" + self.plugin_path
		plugin.path = self.plugin_path
		print "PH: plugin added. plugin=" + key

	def activate(self, args):
		for key in self.plugins:
			self.plugins[key].activate(args)

	def deactivate(self, args):
		for key in self.plugins:
			self.plugins[key].deactivate(args)

	def get_plugin(self, key):
		return self.plugins[key]
		