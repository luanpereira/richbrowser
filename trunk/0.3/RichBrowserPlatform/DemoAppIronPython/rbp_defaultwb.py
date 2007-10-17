import clr

clr.AddReference('System.Drawing')
clr.AddReference('System.Windows.Forms')

clr.AddReference('RichBrowserPlatform')

from System.Drawing import *
from System.Windows.Forms import *

from RichBrowserPlatform import *

class DefaultWebBrowser(UserControl, IWebBrowser):
	wb = None
	
	def __init__(self):
		c = self.wb = WebBrowser()
		c.Dock = DockStyle.Fill
		self.Controls.Add(c)

	def Navigate(self, url):
		self.wb.Navigate(url)

class DefaultWebBrowserFactory(IWebBrowserFactory):
	def Create(self):
		return DefaultWebBrowser()
