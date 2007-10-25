"""

	Regular Expression Tester

 0.3.2 (23 Oct 2007):
  - ported to RBP plugin in public
 0.3.1 (4 Jul 2007): 
  - added clear button
 0.3 (28 May 2007): 
  - added ignore case option. 
  - added version info.
  - added clipboard copy/paste functions.
 0.2 (?): added user agent param.
 0.1 (?): initial version
 
"""

PROGRAM_VERSION = "v0.3.1"
FILE_VERSION = "v0.3"
FILE_DIALOG_FILTER = 'Regular Expression Tester files (*.ret)|*.ret|All files (*.*)|*.*'

from common.pluginhost import *
from common.singleton import *
from common.command import *

import clr

clr.AddReference('WeifenLuo.WinFormsUI.Docking')
clr.AddReference('RBPGUI.RegEx')

from System.Text import *
from System.Text.RegularExpressions import *
from System.Net import *

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
		
class RegExCmd(BaseCommand):
	form = None
	
	def __init__(self, form):
		self.form = form
		
	def execute(self, sender, event):
		print "RegEx:"
		dc = DockContentRegEx()
		dc.TabText = "RegEx"
		dc.Show(self.form.dp, DockState.Document)

		self.set_button(dc.btLoad, RegExLoadCmd()) 
		self.set_button(dc.btSave, RegExSaveCmd()) 

		self.set_button(dc.btWeb, RegExWebCmd())
		self.set_button(dc.btMatch, RegExMatchCmd()) 
		
		self.set_button(dc.btClear, RegExClearCmd())
		self.set_button(dc.btCopy, RegExCopyCmd())
		self.set_button(dc.btPaste, RegExPasteCmd())
		
		c = dc.cbUserAgent
		c.SelectedIndex = 0
		
		c = dc.lbMatches
		c.SelectedIndexChanged += self.__lbMatches_SelectedIndexChanged

	def __lbMatches_SelectedIndexChanged(self, sender, event):
		dc = sender.Parent
		lb = sender
		if lb.SelectedIndex > -1:
			dc.tbDetails.Text = lb.Items[lb.SelectedIndex]

class RegExLoadCmd(ICommand):
	key = 'RegExLoad'
	text = 'Load'
	
	def execute(self, sender, event):
		dc = sender.Parent
		dlg = OpenFileDialog()
		dlg.Filter = FILE_DIALOG_FILTER
		if dlg.ShowDialog() == DialogResult.OK:
			dc.tbFilename.Text = Path.GetFileName(dlg.FileName)
			reader = StreamReader(dlg.FileName)
			version = reader.ReadLine()
			if version == "v0.3":
				dc.cbUserAgent.Text = reader.ReadLine()
				dc.tbUrl.Text = reader.ReadLine()
				dc.tbPattern.Text = reader.ReadLine()
				dc.chkIgnoreCase.Checked = Convert.ToBoolean(reader.ReadLine())
				dc.tbContents.Text = reader.ReadToEnd()
			else:
				dc.tbUrl.Text = version
				dc.tbPattern.Text = reader.ReadLine()
				fullText = ""
				line = reader.ReadLine()
				while line != None:
					fullText = fullText + line
					line = reader.ReadLine()
				dc.tbContents.Text = fullText
			reader.Close()
		
class RegExSaveCmd(ICommand):
	key = 'RegExSave'
	text = 'Save'
	
	def execute(self, sender, event):
		dc = sender.Parent
		dlg = SaveFileDialog()
		dlg.FileName = Path.GetFileNameWithoutExtension(dc.tbFilename.Text)
		dlg.Filter = FILE_DIALOG_FILTER
		dlg.RestoreDirectory = True

		if dlg.ShowDialog() == DialogResult.OK:
			dc.tbFilename.Text = Path.GetFileName(dlg.FileName)
			writer = File.CreateText(dlg.FileName)
			writer.WriteLine(FILE_VERSION)
			writer.WriteLine(dc.cbUserAgent.Text)
			writer.WriteLine(dc.tbUrl.Text)
			writer.WriteLine(dc.tbPattern.Text)
			writer.WriteLine(dc.chkIgnoreCase.Checked.ToString())
			writer.WriteLine(dc.tbContents.Text)
			writer.Close()
		
class RegExWebCmd(ICommand):
	key = 'RegExWeb'
	text = 'Web'

	def execute(self, sender, event):
		dc = sender.Parent
		
		# http://www.dt.co.kr/section_list.htm?scd=2

		lcUrl = dc.tbUrl.Text # "http://www.dt.co.kr/section_list.htm?scd=2";

		# *** Establish the request
		loHttp = WebRequest.Create(lcUrl)

		# *** Set properties
		loHttp.Timeout = 10000 # 10 secs
		loHttp.UserAgent = dc.cbUserAgent.Text

		# *** Retrieve request info headers
		loWebResponse = loHttp.GetResponse()

		enc = Encoding.GetEncoding("euc-kr") # Windows default Code Page

		loResponseStream = StreamReader(loWebResponse.GetResponseStream(), enc)

		lcHtml = loResponseStream.ReadToEnd();

		dc.tbContents.Text = lcHtml

		loWebResponse.Close()
		loResponseStream.Close()
		
class RegExMatchCmd(ICommand):
	key = 'RegExMatch'
	text = 'Match'
	
	def execute(self, sender, event):
		dc = sender.Parent
		re = None
		if dc.chkIgnoreCase.Checked == True:
			re = Regex(dc.tbPattern.Text, RegexOptions.IgnoreCase)
		else:
			re = Regex(dc.tbPattern.Text, RegexOptions.None)
		mc = re.Matches(dc.tbContents.Text)
		dc.tbCount.Text = mc.Count.ToString()
		dc.lbMatches.Items.Clear()
		for j in range(mc.Count):
			m = mc[j]
			item = (j + 1).ToString() + ": "
			for i in range(1, m.Groups.Count):
				item = item + i.ToString() + "=[" + m.Groups[i].ToString() + "], "
			dc.lbMatches.Items.Add(item)

class RegExClearCmd(ICommand):
	key = 'RegExClear'
	text = 'Clear'

	def execute(self, sender, event):
		dc = sender.Parent
		dc.tbContents.Clear()	
		
class RegExCopyCmd(ICommand):
	key = 'RegExCopy'
	text = 'Copy'

	def execute(self, sender, event):
		dc = sender.Parent
		if dc.tbContents.Text.Length > 0:
			Clipboard.SetText(dc.tbContents.Text)
		
class RegExPasteCmd(ICommand):
	key = 'RegExPaste'
	text = 'Paste'

	def execute(self, sender, event):
		dc = sender.Parent
		dc.tbContents.Text = Clipboard.GetText()
		
if __name__ == '__main__':
	pass
else:
	# add to pluginhost
	get_singleton(PluginHost).add('RegEx', RegExPlugin())
	