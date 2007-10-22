import clr

clr.AddReference('System.Drawing')
clr.AddReference('System.Windows.Forms')

clr.AddReference('csExWB')
clr.AddReference('RichBrowserPlatform')

from System.Drawing import *
from System.Windows.Forms import *

from csExWB import *
from RichBrowserPlatform import *

class csExWBWebBrowser(UserControl, IWebBrowser):
	wb = None
	
	def __init__(self):
		print "a"
		c = self.wb = cEXWB()
		print "b"
		c.Dock = DockStyle.Fill
		self.Controls.Add(c)

	def Navigate(self, url):
		self.wb.Navigate(url)

class csExWBWebBrowserFactory(IWebBrowserFactory):
	def Create(self):
		return csExWBWebBrowser()
