﻿// NPP plugin platform for .Net v0.91.57 by Kasper B. Graversen etc.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using static Kbg.NppPluginNET.PluginInfrastructure.ScintillaGateway;
//For XML Parsing, added by Superfestung, not sure if nessecarry
using System.Xml;
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;
using NppDemo.Forms;
using NppDemo.Utils;
using PluginNetResources = NppDemo.Properties.Resources;



namespace Kbg.NppPluginNET
{
    class Main
    {
        #region " Fields "
        internal const int UNDO_BUFFER_SIZE = 64;
        internal const string PluginName = "Sinumerik++";
        public static readonly string PluginConfigDirectory = Path.Combine(Npp.notepad.GetConfigDirectory(), PluginName);
        public const string PluginRepository = "https://github.com/superfestung/Sinumerik-plus-plus-plugin";
        // general stuff things
        static Icon dockingFormIcon = null;
        private static readonly string sessionFilePath = Path.Combine(PluginConfigDirectory, "savedNppSession.xml");
        private static List<(string filepath, DateTime time, bool opened, int modsSinceOpen)> filesOpenedClosed = new List<(string filepath, DateTime time, bool opened, int modsSinceOpen)>();
        public static Settings settings = new Settings();
        public static bool bufferFinishedOpening;
        public static int modsSinceBufferOpened = 0;
        public static string activeFname = null;
        public static bool isDocTypeHTML = false;
        // forms
        public static SelectionRememberingForm selectionRememberingForm = null;
        public static HelpScreen helpScreen = null;//new HelpScreen();
        static internal int IdAboutForm = -1;
        static internal int IdSelectionRememberingForm = -1;
        static internal int IdCloseHtmlTag = -1;
        static internal int IdGcodeHelpForm = -1;
        #endregion

        #region " Startup/CleanUp "

        static internal void CommandMenuInit()
        {
            // Initialization of your plugin commands

            // with function :
            // SetCommand(int index,                            // zero based number to indicate the order of command
            //            string commandName,                   // the command name that you want to see in plugin menu
            //            NppFuncItemDelegate functionPointer,  // the symbol of function (function pointer) associated with this command. The body should be defined below. See Step 4.
            //            ShortcutKey *shortcut,                // optional. Define a shortcut to trigger this command
            //            bool check0nInit                      // optional. Make this menu item be checked visually
            //            );

            // the "&" before the "D" means that D is an accelerator key for selecting this option 

            PluginBase.SetCommand(0, "Read the Online Help", OnlineHelp);
            PluginBase.SetCommand(1, "G-Code Help", GcodeHelp, new ShortcutKey(true, true, true, Keys.F)); IdGcodeHelpForm = 1;
            PluginBase.SetCommand(2, "---", null);
            PluginBase.SetCommand(3, "&Settings", OpenSettings);
            PluginBase.SetCommand(4, "A&bout", ShowAboutForm); //IdAboutForm = 4;


        }

        static internal void SetToolBarIcons()
        {
            string iconsToUseChars = settings.toolbar_icons.ToLower();
            var iconInfo = new (Bitmap bmp, Icon icon, Icon iconDarkMode, int id, char representingChar)[]
            {
                //(PluginNetResources.about_form_toolbar_bmp, PluginNetResources.about_form_toolbar, PluginNetResources.about_form_toolbar_darkmode, IdAboutForm, 'a'),
                (PluginNetResources.magnifier_V2_bmp, PluginNetResources.magnifier_V2, PluginNetResources.magnifier_V2, IdGcodeHelpForm, 'a'),
            }
                .Where(x => iconsToUseChars.IndexOf(x.representingChar) >= 0)
                .OrderBy(x => iconsToUseChars.IndexOf(x.representingChar));
            // order the icons according to their order in settings.toolbar_icons, and exclude those without their representing char listed

            foreach ((Bitmap bmp, Icon icon, Icon iconDarkMode, int funcId, char representingChar) in iconInfo)
            {
                // create struct
                toolbarIcons tbIcons = new toolbarIcons();

                // add bmp's and icons
                tbIcons.hToolbarBmp = bmp.GetHbitmap();
                tbIcons.hToolbarIcon = icon.Handle;
                tbIcons.hToolbarIconDarkMode = iconDarkMode.Handle;

                // convert to c++ pointer
                IntPtr pTbIcons = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons));
                Marshal.StructureToPtr(tbIcons, pTbIcons, false);

                // call Notepad++ api to add icons
                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_ADDTOOLBARICON_FORDARKMODE,
                    PluginBase._funcItems.Items[funcId]._cmdID, pTbIcons);

                // release pointer
                Marshal.FreeHGlobal(pTbIcons);
            }
        }

        public static void OnNotification(ScNotification notification)
        {
            uint code = notification.Header.Code;
            // This method is invoked whenever something is happening in notepad++
            // use eg. as
            // if (code == (uint)NppMsg.NPPN_xxx)
            // { ... }
            // or
            //
            // if (code == (uint)SciMsg.SCNxxx)
            // { ... }
            //// changing tabs
            switch (code)
            {
                // when a file starts opening (but before it is fully loaded)
                case (uint)NppMsg.NPPN_FILEBEFOREOPEN:
                    bufferFinishedOpening = false;
                    break;
                // when a file is finished opening
                case (uint)NppMsg.NPPN_BUFFERACTIVATED:
                    bufferFinishedOpening = true;
                    // When a new buffer is activated, we need to reset the connector to the Scintilla editing component.
                    // This is usually unnecessary, but if there are multiple instances or multiple views,
                    // we need to track which of the currently visible buffers are actually being edited.
                    Npp.editor = new ScintillaGateway(PluginBase.GetCurrentScintilla());
                    //DoesCurrentLexerSupportCloseHtmlTag();
                    // track when it was opened
                    IntPtr bufferOpenedId = notification.Header.IdFrom;
                    activeFname = Npp.notepad.GetFilePath(bufferOpenedId);
                    filesOpenedClosed.Add((activeFname, DateTime.Now, true, 0));
                    modsSinceBufferOpened = 0;
                    return;
                // when the lexer language changed, re-check whether this is a document where we close HTML tags.
                case (uint)NppMsg.NPPN_LANGCHANGED:
                    //DoesCurrentLexerSupportCloseHtmlTag();
                    break;
                // when closing a file
                case (uint)NppMsg.NPPN_FILEBEFORECLOSE:
                    IntPtr bufferClosedId = notification.Header.IdFrom;
                    string bufferClosedPath = Npp.notepad.GetFilePath(bufferClosedId);
                    filesOpenedClosed.Add((bufferClosedPath, DateTime.Now, false, modsSinceBufferOpened));
                    return;
                // the editor color scheme changed, so update form colors
                case (uint)NppMsg.NPPN_WORDSTYLESUPDATED:
                    RestyleEverything();
                    return;
                case (uint)SciMsg.SCN_CHARADDED:
                    //DoInsertHtmlCloseTag(notification.Character);
                    break;
                case (uint)SciMsg.SCN_MODIFIED:
                    modsSinceBufferOpened++;
                    break;
                // this fires when the "Replace all" and "Replace in all open documents" actions of the Notepad++ find/replace form are used
                // You may want to use this because beginning in Notepad++ 8.6.3,
                //     some kinds of SCN_MODIFIED messages are no longer sent during those actions
                //     (because sending messages can have a significant performance cost)
                case (uint)NppMsg.NPPN_GLOBALMODIFIED:
                    // only increment modsSinceBufferOpened if it was a find/replace for the active file
                    // (this message fires once for each buffer modified in a "Replace in all open documents" action)
                    IntPtr bufferModifiedId = notification.Header.hwndFrom;
                    string bufferModified = Npp.notepad.GetFilePath(bufferModifiedId);
                    if (bufferModified == activeFname)
                        modsSinceBufferOpened++;
                    break;
                    //if (code > int.MaxValue) // windows messages
                    //{
                    //    int wm = -(int)code;
                    //    }
                    //}
            }
        }

        static internal void PluginCleanUp()
        {
            // dispose of any forms
            if (selectionRememberingForm != null && !selectionRememberingForm.IsDisposed)
            {
                selectionRememberingForm.Close();
                selectionRememberingForm.Dispose();
            }
            //helpScreen formcopied from selectionRememberingForm
            if (helpScreen != null && !helpScreen.IsDisposed)
            {
                helpScreen.Close();
                helpScreen.Dispose();
            }
        }
        #endregion

        #region " Menu functions "

        /// <summary>
        /// open GitHub repo with the web browser
        /// </summary>
        public static void Docs()
        {
            try
            {
                var ps = new ProcessStartInfo(PluginRepository)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Could not open documentation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //form opening stuff

        static void OpenSettings()
        {
            settings.ShowDialog();
        }

        /// <summary>
        /// Apply the appropriate styling
        /// (either generic control styling or Notepad++ styling as the case may be)
        /// to all forms.
        /// </summary>
        public static void RestyleEverything()
        {
            if (selectionRememberingForm != null && !selectionRememberingForm.IsDisposed)
                FormStyle.ApplyStyle(selectionRememberingForm, settings.use_npp_styling);
            //helpScreen
            if (helpScreen != null && !helpScreen.IsDisposed)
                FormStyle.ApplyStyle(helpScreen, settings.use_npp_styling);

        }

        static void ShowAboutForm()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            aboutForm.Focus();
        }

        static void OnlineHelp()
        {
            //Open Online Helpfiles
            //VariableHelp
            string strPluginPath = "file:///C:/Program%20Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/";
            string strHelpPath = "siemens/sinumerik/hmi/hlps/";
            string strHelpEngPath = "hlp_eng/eng/";
            string strHelpDetail = "programming/";
            string strHelpFileName = "3018717963.html";

            HelpScreen.HandOverURL = strPluginPath + strHelpPath + strHelpEngPath + strHelpDetail + strHelpFileName;
            OpenBrowser();

        }
        public static void OpenBrowser()
        {


            bool wasVisible = helpScreen != null && helpScreen.Visible;
            if (wasVisible)

                helpScreen.RefreshBrowser(HelpScreen.HandOverURL);

            //Npp.notepad.HideDockingForm(helpScreen);
            else if (helpScreen == null || helpScreen.IsDisposed)
            {
                helpScreen = new HelpScreen();
                DisplayHelpScreenForm(helpScreen);
            }
            else
            {
                Npp.notepad.ShowDockingForm(helpScreen);
            }
            helpScreen.RefreshBrowser(HelpScreen.HandOverURL);
        }

        private static void DisplayHelpScreenForm(HelpScreen form)
        {
            using (Bitmap newBmp = new Bitmap(16, 16))
            {
                Graphics g = Graphics.FromImage(newBmp);
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.Fuchsia;
                colorMap[0].NewColor = Color.FromKnownColor(KnownColor.ButtonFace);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                //g.DrawImage(tbBmp_tbTab, new Rectangle(0, 0, 16, 16), 0, 0, 16, 16, GraphicsUnit.Pixel, attr);
                dockingFormIcon = Icon.FromHandle(newBmp.GetHicon());
            }

            NppTbData _nppTbData = new NppTbData();
            _nppTbData.hClient = form.Handle;
            _nppTbData.pszName = form.Text;
            // the dlgDlg should be the index of funcItem where the current function pointer is in
            // this case is 15.. so the initial value of funcItem[15]._cmdID - not the updated internal one !
            _nppTbData.dlgID = IdSelectionRememberingForm;
            // dock on left
            _nppTbData.uMask = NppTbMsg.DWS_DF_CONT_LEFT | NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;
            _nppTbData.hIconTab = (uint)dockingFormIcon.Handle;
            _nppTbData.pszModuleName = PluginName;
            IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
            Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

            Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);
            Npp.notepad.ShowDockingForm(form);
        }

        static void GcodeHelp()
        {
            //+------------------------------------------------------------------------------+
            //|----------------------+---------------+---------------------------------------|
            //|----------------------|   To-Do's     |---------------------------------------|
            //|----------------------+---------------+---------------------------------------|
            //| - Add variable Search for System Variables                                   |
            //| - Add variable Search for Machine Data                                       |
            //| - Make Pop-Up/Form for showing Help                                          |
            //| - Make Buttons for Browsing Help                                             |
            //|______________________________________________________________________________|

            //VariableHelp
            //string strPluginPath = "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/";
            //string strHelpPath = "siemens/sinumerik/hmi/hlps/";
            //string strHelpEngPath = "hlp_eng/eng/";
            //string strHelpDetail = "programming/";
            //string strHelpFileName = "3018717963.html";

            //

            //strHelpEngPath = ReadFiles.LanguageFolder(); 

            ReadFiles readFiles = new ReadFiles(Npp.editor.GetSelText(),
                "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/siemens/sinumerik/hmi/cfg/slhlpgcode.xml",
                "FUNCTION");
            readFiles.GetHTMLFile();
            //string SearchText = Npp.editor.GetSelText();
            //string XmlSourceFile = "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/siemens/sinumerik/hmi/cfg/slhlpgcode.xml";
            //string XmlElementName = "FUNCTION";
            //HelpScreen.HandOverURL = strPluginPath + strHelpPath + strHelpEngPath + strHelpDetail + strHelpFileName;

            //OpenBrowser();

        }



        #endregion
    }
}

class ReadFiles
{

    //string SearchText = Npp.editor.GetSelText();
    //string XmlSourceFile = "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/siemens/sinumerik/hmi/cfg/slhlpgcode.xml";
    //string XmlElementName = "FUNCTION";

    string searchText;
    string xmlSourceFile;
    string xmlElementName;

    //"\card\siemens\sinumerik\hmi\hlps\hlp_eng\eng\"
    string[] XmlVariableSources = { "slhlpgcode.xml",
                                    "sinumerik_md_axis.xml",
                                    "sinumerik_md_chan.xml",
                                    "sinumerik_md_compile.xml",
                                    "sinumerik_md_hmi.xml",
                                    "sinumerik_md_nck.xml",
                                    "sinumerik_md_set.xml",
                                    "sinumerik_btss_a.xml",
                                    "sinumerik_btss_b.xml",
                                    "sinumerik_btss_c.xml",
                                    "sinumerik_btss_m.xml",
                                    "sinumerik_btss_n.xml",
                                    "sinumerik_btss_t.xml"};

    string[] XmlFileFolder =    { "/siemens/sinumerik/hmi/cfg/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/",
                                    "/siemens/sinumerik/hmi/hlps/hlp_eng/eng/"};

    string XmlRootFolder =    "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin" ;

    string[] XmlSearchElement = { "FUNCTION", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY", "ENTRY" };
    int[] XmlTargetAttribute = { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
    string[] XmlWhereIsHTML = { "txt", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1", "atr1" };



    public string Searchtext
    {
        get { return this.searchText; }
        //set { this.searchText = value; }
    }

    public string XmlSourceFile
    {
        get { return this.xmlSourceFile; }
        //set { this.xmlSourceFile = value; }
    }

    public string XmlElementName
    {
        get { return this.xmlElementName; }
        //set { this.xmlElementName = value; }
    }

    public ReadFiles(string searchText, string xmlSourceFile, string xmlElementName)
    {
        this.searchText = searchText;
        this.xmlSourceFile = xmlSourceFile;
        this.xmlElementName = xmlElementName;
    }

    private static String LanguageFolder()
    {
        string strHelpLangPath = "";
        switch (GetLanguage())
        {
            case "DE":
                strHelpLangPath = "hlp_deu/deu/";
                break;
            case "EN":
                strHelpLangPath = "hlp_eng/eng/";
                break;
            default:
                strHelpLangPath = "hlp_eng/eng/";
                break;
        }
        return strHelpLangPath;
    }

    private static String GetLanguage()
    {
        String result = "";
        StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
        Win32.SendMessage(PluginBase.nppData._nppHandle,
                                              (uint)NppMsg.NPPM_GETPLUGINSCONFIGDIR,
                                              Win32.MAX_PATH, sbIniFilePath);
        String iniFilePath = sbIniFilePath.ToString();
        if (iniFilePath.EndsWith(@"plugins\Config"))
        {
            iniFilePath = iniFilePath.Replace(@"\plugins\Config", @"\nativeLang.xml");
            String readline = null;
            Int16 counter = 0;
            //    <Native-Langue name="English" filename="english.xml" version="6.8.2">
            using (System.IO.StreamReader fileReader = System.IO.File.OpenText(iniFilePath))
            {
                while (counter < 30) // check counterMax
                {
                    readline = fileReader.ReadLine();
                    counter++;
                    if (readline.ToLowerInvariant().Contains("<native-langue"))
                    {
                        string[] split = Regex.Split(readline,
                             "^(.*)(<Native-Langue)(\\s+)(name=\")(((?!\").)*)(\")(.*)$");
                        if ((split != null) && (split.Length > 4))
                            readline = split[5];
                        else
                            readline = null;
                        counter = 31; // Set counter to => max
                    }
                    else
                        readline = null;
                }
                fileReader.Close();
            }
            if (readline != null)
            {
                switch (readline.ToLowerInvariant())
                {
                    case "deutsch":
                        result = "DE";
                        break;
                    case "english":
                        result = "EN";
                        break;
                    default:
                        result = "EN";
                        break;
                }
            }
        }
        return result;
    }

    public void GetHTMLFile()
    {

        if (this.searchText.Length > 0)
        {
            string SearchResultLink = "";
            int CheckIndex = 0;
            //Creates an XML Reader for the G-Code Help

            //MessageBox.Show($"Search Text:<{this.searchText}>!", "Debug Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            for (int i = 0; i <=  XmlVariableSources.Length ; i++)
            {
                CheckIndex = i;
                //MessageBox.Show($"XmlRootFolder: <{XmlRootFolder}> XmlFileFolder[{i}] : <{XmlFileFolder[i]}> XmlVariableSources[{i}]: <{XmlVariableSources[i]}> XmlSearchElement[{i}]: <{XmlSearchElement[i]}> ", "Search Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchResultLink = readXmlFile( this.XmlRootFolder + this.XmlFileFolder[i] + this.XmlVariableSources[i], this.XmlSearchElement[i],  this.searchText);
                if ((SearchResultLink.Length > 0) && (SearchResultLink.EndsWith(".html")))
                {
                    break;
                }

            }
            MessageBox.Show($"Search Result Link:<{SearchResultLink}>!", "Debug Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (SearchResultLink.Length == 0)
            {
                MessageBox.Show($"Search for <{this.searchText}> has no Results!", "Search Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((SearchResultLink.Length > 0) & (SearchResultLink.EndsWith(".html")))
                {
                    ExecuteHtml(SearchResultLink);
                }
                else
                {
                    MessageBox.Show($"Search Result for <{this.searchText}> is not a valid HTML-Help!", "Search Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        else
        {
            MessageBox.Show("No Characters selected!", "Search Variable Display", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
    
    static string readXmlFile(string xmlSourceFile, string xmlElementName, string searchText)
    {
        //string result = "";
        bool getHTML = false;
        string SearchResultValue = "";
        string SearchResultLink = "";
        //Creates an XML Reader for the G-Code Help
       
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;
        XmlReader readerXmlFile = XmlReader.Create(xmlSourceFile, settings);
        readerXmlFile.MoveToContent();
        while (readerXmlFile.Read())
        {
            switch (readerXmlFile.NodeType)
            {
                case XmlNodeType.Element:
                    if (readerXmlFile.Name == xmlElementName)
                    {
                        if (readerXmlFile.AttributeCount > 0)
                        {
                            readerXmlFile.MoveToNextAttribute();
                            if (readerXmlFile.Value == searchText)
                            {
                                getHTML = true;
                                SearchResultValue = readerXmlFile.Value;
                            }
                        }
                    }
                    break;
                case XmlNodeType.Text:
                    if (getHTML)
                    {
                        SearchResultLink = readerXmlFile.Value;
                        getHTML = false;
                        goto Finish;
                    }
                    break;
            }
        }
        Finish:
        return SearchResultLink;
    }

    public void GetSearchVariableFromText()
    {
        //-----------------------------------------------------------------------
        //Check if variable is G-Code
        //"card\siemens\sinumerik\hmi\cfg\slhlpgcode.xml"

        //-----------------------------------------------------------------------
        // Check if Systemvariable or BTSS
        //Check Textfile from Sinumerik ONE
        //"card\siemens\sinumerik\hmi\cfg\TraceDB\SignalSvcONE.txt"

        //Check Textfile from Sinumerik 840Dsl, start at line of ONE End
        //"card\siemens\sinumerik\hmi\cfg\TraceDB\SignalSvc840.txt"

        //Check Textfile from SInumerik 828D, start at line of ONE End
        //"card\siemens\sinumerik\hmi\cfg\TraceDB\SignalSvc828.txt"

        //If variable found, get coresponding BTSS Variable

        //Search BTSS Variable in the XML Files, Get HTML File

        //"\card\siemens\sinumerik\hmi\hlps\hlp_eng\eng\"
        //"sinumerik_btss_a.xml"
        //"sinumerik_btss_b.xml"
        //"sinumerik_btss_c.xml"
        //"sinumerik_btss_m.xml"
        //"sinumerik_btss_n.xml"
        //"sinumerik_btss_t.xml"


        //-----------------------------------------------------------------------
        // Check if Machine Data exists
        //"card\siemens\sinumerik\hmi\cfg\mdreference.xml"

        //Search for MD Number in XML Files:
        //"\card\siemens\sinumerik\hmi\hlps\hlp_eng\eng\"
        //"sinumerik_md_axis.xml"
        //"sinumerik_md_chan.xml"
        //"sinumerik_md_compile.xml"
        //"sinumerik_md_hmi.xml"
        //"sinumerik_md_nck.xml"
        //"sinumerik_md_set.xml"

        for (int i = 0; XmlVariableSources.Length <= i; i++)
        {
            xmlSourceFile = "C://Program Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/" + "siemens/sinumerik/hmi/hlps/hlp_eng/eng/" + XmlVariableSources[i];

        }

    }


    private void ExecuteHtml(string executeHtml)
    {
        string LanguageFolder = ReadFiles.LanguageFolder();
        string strPluginPath = "file:///C:/Program%20Files/Notepad++/plugins/Sinumerik-plus-plus-plugin/";
        string strHelpPath = "siemens/sinumerik/hmi/hlps/";
        string strHelpDetail = "programming/";

        string strHyperlink = strPluginPath + strHelpPath + LanguageFolder + strHelpDetail + executeHtml;
        HelpScreen.HandOverURL = strPluginPath + strHelpPath + LanguageFolder + strHelpDetail + executeHtml;
        //System.Diagnostics.Process.Start(strHyperlink);
        //Main main = new Main();
        Main.OpenBrowser();
        //; Main.
    }

}


