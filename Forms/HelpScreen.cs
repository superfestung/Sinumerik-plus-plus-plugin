using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NppDemo.Utils;

namespace NppDemo.Forms
{
    public partial class HelpScreen : Form
    {

        public static string HandOverURL;
        public HelpScreen()
        {
            InitializeComponent();
            webBrowser1.Url = new System.Uri(HandOverURL, System.UriKind.Absolute);
        }
        public void RefreshBrowser(string BrowserLink)
            {            
            webBrowser1.Navigate(BrowserLink);            
            }

        private void Button_Forward_Click(object sender, EventArgs e)
        {
            //Forward Button
            webBrowser1.GoForward();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            //Backward Button
            webBrowser1.GoBack();
        }
        private void Button_Search_Click(object sender, EventArgs e)
        {
            //Search Button
            //webBrowser1.GoBack();
            ReadFiles readFiles = new ReadFiles(textBox1.Text,
                "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/siemens/sinumerik/hmi/cfg/slhlpgcode.xml",
                "FUNCTION");
            //ReadFiles readFiles = new ReadFiles(Npp.editor.GetSelText(),
            //    "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/siemens/sinumerik/hmi/cfg/slhlpgcode.xml",
            //    "FUNCTION");
            readFiles.GetHTMLFile();
        }

    }
}
