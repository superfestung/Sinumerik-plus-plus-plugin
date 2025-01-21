using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
//----------
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;
using NppDemo.Forms;
using NppDemo.Utils;
using System.Web;
using System.Net;
//----------------
using System.Web.UI;
using nppTranslateCS;
using System.Runtime.Serialization.Json;
using System.Web.UI.WebControls.WebParts;




namespace NppDemo.Forms
{
    public partial class TextGenerator : Form
    {
        public static Settings settings = new Settings();
        public List<MessagesList> MSGmessages {  get; set; }

        //public List<pair> ListLang;


        public static string SinumerikProjectFolder;
        public string SinumerikProjectName;
        //public object preselectedItems;
        public static bool[] checkedItems = {false, false, false, false, false, false, false, false, false, false, false, false, false, false
                                    , false, false, false, false, false, false, false, false, false, false, false, false};
        public static bool[] PreCheckedItems = {false, false, false, false, false, false, false, false, false, false, false, false, false, false
                                    , false, false, false, false, false, false, false, false, false, false, false, false};
        public static int numLanguagesSelected = 0;
        public static int numLanguagesSelectedOld = 0;

        public TextGenerator()
        {
            CellUpdateForTriggers.newId = false;
            CellUpdateForTriggers.newText = false;
            CellUpdateForTriggers.newLine = false;

            MSGmessages = GetMessages();
            
            InitializeComponent();
            MSGList_Initialize();
            UpdateFoldersAndFiles();
            if (checkedListBoxLanguage.GetItemChecked(0))
            {
                checkedListBoxLanguage.SetItemChecked(0, true);                
            }
            else
            {
                checkedListBoxLanguage.SetItemChecked(0, true);
            }
            //preselectedItems = checkedListBoxLanguage.SelectedItems;

            for (int i = 0; i < checkedListBoxLanguage.Items.Count; i++)
            {                
                checkedItems[i] = checkedListBoxLanguage.GetItemChecked(i);
                PreCheckedItems[i] = checkedListBoxLanguage.GetItemChecked(i);
            }
            //minus 1 for default language English
            //numLanguagesSelected = checkedListBoxLanguage.Items.Count;
            numLanguagesSelected = checkedListBoxLanguage.CheckedItems.Count;
            numLanguagesSelected = numLanguagesSelected - 1;
            numLanguagesSelectedOld = numLanguagesSelected;

        }

        private void LangCheckBoxItemChange(object sender, EventArgs e)
        {
            UpdateSelectedLanguages();
        }

        private void UpdateSelectedLanguages()
        {
            AddNewLines();            
        }

        private void UpdateNewLastLine()
        {
            int LastRowStart = dataGridViewMSG.RowCount - 1;
            //string writeLangText = "";
            
            int addRow = LastRowStart;
            if (checkedListBoxLanguage.Items.Count >1)
            {
                for (int j = 0; j < checkedListBoxLanguage.Items.Count; j++)
                {
                    if (checkedListBoxLanguage.GetItemChecked(j))
                    {
                        string writeLangText = checkedListBoxLanguage.Items[j].ToString();

                        if ((writeLangText != settings.DefaultLanguage) &! (writeLangText.Contains("eng")))
                        {
                            dataGridViewMSG.Rows.Insert(addRow);
                            dataGridViewMSG.Rows[addRow].Cells[0].Value = writeLangText;
                            dataGridViewMSG.Rows[addRow].Cells[0].ReadOnly = true;
                            dataGridViewMSG.Rows[addRow].Cells[0].ToolTipText = "Translation in (" + writeLangText + ") for " + dataGridViewMSG.Columns[0].Name + ": " + dataGridViewMSG.Rows[LastRowStart].Cells[0].Value;
                            dataGridViewMSG.Rows[addRow].Cells[1].Value = dataGridViewMSG.Rows[LastRowStart-1].Cells[1].Value;
                            dataGridViewMSG.Rows[addRow].Cells[1].ToolTipText = "Translation in (" + writeLangText + ")  for " + dataGridViewMSG.Columns[1].Name + ": " + dataGridViewMSG.Rows[LastRowStart].Cells[1].Value;
                            addRow++;
                        }
                    }
                }
            }           
                        
        }

        private void AddNewLines()
        {
            string ThisLanguageHasChanged = "";
            int indexLangaugeAdded = 0;

            //---------------------------------------
            //Here Later Get Default Language
            //---------------------------------------
            //Select English as default always
            if (checkedListBoxLanguage.GetItemChecked(0))
            {
                checkedListBoxLanguage.SetItemChecked(0, true);
            }
            else
            {
                checkedListBoxLanguage.SetItemChecked(0, true);
            }
            //Get all selected Languages
            for (int i = 0; i < checkedListBoxLanguage.Items.Count; i++)
            {
                if (checkedListBoxLanguage.GetItemChecked(i))
                {
                    checkedItems[i] = true;
                }
                else
                {
                    checkedItems[i] = false;
                }
                //MessageBox.Show($"checkedItems[{i}]: {checkedItems[i]}", "Languages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool IsDifferent = false;
            //check if Language Selection has changed
            for (int j = 0; j < checkedListBoxLanguage.Items.Count; j++)
            {
                if (checkedItems[j] != PreCheckedItems[j])
                {
                    IsDifferent = true;
                    ThisLanguageHasChanged = checkedListBoxLanguage.Items[j].ToString();
                    indexLangaugeAdded = j;
                }
                PreCheckedItems[j] = checkedItems[j];
            }
            if (IsDifferent)
            {
                //Check Language and add a additional Line for each selected Language
                //MSG Section
                //------------------------------------------------------------------------------------------------
                if (tabControlSinumerik.SelectedTab.Name == "Messages")
                {
                    //numLanguagesSelected = checkedListBoxLanguage.Items.Count;
                    numLanguagesSelected = checkedListBoxLanguage.CheckedItems.Count;

                    //minus 1 for default language English
                    numLanguagesSelected = numLanguagesSelected - 1;
                    int numRowMax = dataGridViewMSG.RowCount - 1;

                    //Language has been added
                    if ((numLanguagesSelected > numLanguagesSelectedOld) && (numLanguagesSelected > 0))
                    {
                        //Pre Check if Language might already exists
                        int preCheckLanguage = 0;
                        if (numRowMax > numLanguagesSelected)
                        {
                            preCheckLanguage = numLanguagesSelected;
                        }
                        else
                        {
                            preCheckLanguage = numRowMax;
                        }
                        bool skipAddLanguage = false;
                        for (int i = 0; i < preCheckLanguage; i++)
                        {
                            string ThisRowsValue = dataGridViewMSG.Rows[i].Cells[0].Value.ToString();
                            if (ThisLanguageHasChanged == ThisRowsValue)
                            {
                                skipAddLanguage = true;
                            }
                        }
                        if (!skipAddLanguage)
                        {
                            //Get new Language from ticked checkbox
                            int getTextCounter = 0;
                            string writeLangText = "";
                            for (int getText = 0; getText < checkedListBoxLanguage.Items.Count; getText++)
                            {
                                if (checkedListBoxLanguage.GetItemChecked(getText))
                                {
                                    getTextCounter++;
                                    if (getTextCounter == numLanguagesSelected + 1)
                                    {
                                        writeLangText = checkedListBoxLanguage.Items[getText].ToString();
                                    }

                                }
                            }
                            writeLangText = checkedListBoxLanguage.Items[indexLangaugeAdded].ToString();
                            writeLangText = ThisLanguageHasChanged;
                            int Rowcounter = 0;
                            while (Rowcounter <= (numRowMax - numLanguagesSelected))
                            {
                                int addRow = Rowcounter + numLanguagesSelected;

                                dataGridViewMSG.Rows.Insert(addRow);

                                dataGridViewMSG.Rows[addRow].Cells[0].Value = writeLangText;
                                dataGridViewMSG.Rows[addRow].Cells[0].ReadOnly = true;
                                dataGridViewMSG.Rows[addRow].Cells[0].ToolTipText = "Translation in (" + writeLangText + ") for " + dataGridViewMSG.Columns[0].Name + ": " + dataGridViewMSG.Rows[Rowcounter].Cells[0].Value;
                                dataGridViewMSG.Rows[addRow].Cells[1].Value = dataGridViewMSG.Rows[Rowcounter].Cells[1].Value;
                                dataGridViewMSG.Rows[addRow].Cells[1].ToolTipText = "Translation in (" + writeLangText + ")  for " + dataGridViewMSG.Columns[1].Name + ": " + dataGridViewMSG.Rows[Rowcounter].Cells[1].Value;

                                numRowMax = dataGridViewMSG.RowCount - 1;
                                Rowcounter = Rowcounter + numLanguagesSelected + 1;
                            }


                        }

                        //MessageBox.Show($"Selected Languages: {dataGridViewMSG.RowCount}", "Languages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if ((numLanguagesSelected < numLanguagesSelectedOld))
                    {
                        //dataGridViewMSG.Rows[0].Cells[0].Selected = true;
                        for (int intRows = numRowMax - 1; intRows > 0; intRows--)
                        {
                            string CheckForDeleteRow = dataGridViewMSG.Rows[intRows].Cells[0].Value.ToString();

                            if (CheckForDeleteRow == ThisLanguageHasChanged)
                            {
                                dataGridViewMSG.Rows.RemoveAt(intRows);
                            }
                        }
                    }
                }
            }


            numLanguagesSelectedOld = numLanguagesSelected;
        }


        private List<MessagesList> GetMessages()
        {
            //throw new NotImplementedException();
            var MSGlist = new List<MessagesList> ();
            MSGlist.Add(new MessagesList() { MessageID = 1, MessageTransEng = "Text English 1" });
            MSGlist.Add(new MessagesList() { MessageID = 2, MessageTransEng = "Text English 2" });
            MSGlist.Add(new MessagesList() { MessageID = 3, MessageTransEng = "Text English 3" });

            return MSGlist;

        }
 
        private void MSGList_Initialize()
        {

            dataGridViewMSG.ColumnCount = 2;
            dataGridViewMSG.RowCount = 2;
            dataGridViewMSG.Columns[0].Name = "Message ID";
            dataGridViewMSG.Columns[0].Width= 120;
            dataGridViewMSG.Columns[1].Name = "MSG Text";
            dataGridViewMSG.Columns[1].Width = 400;

            //dataGridViewMSG.DataSource = MSGmessages;
            dataGridViewMSG.AllowUserToAddRows = true;
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSetalarmTxt0_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
             
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SinumerikProjectFolder = dialog.SelectedPath;
            }
            else 
            {
                SinumerikProjectFolder = "";
            }

            textBoxProjectFolder.Text = SinumerikProjectFolder;
            settings.SinPPRootFolder = SinumerikProjectFolder;
        }

        private void DisplayFoldersAndFiles(object sender, EventArgs e)
        {

            UpdateFoldersAndFiles();

        }
        private void UpdateFoldersAndFiles()
        {
            string strLanguage = "eng";
            if (tabControlSinumerik.SelectedTab.Name == "Messages")
            {
                if (dataGridViewMSG.Rows[dataGridViewMSG.CurrentCell.RowIndex].Cells[0].ReadOnly)
                {
                    strLanguage = dataGridViewMSG.Rows[dataGridViewMSG.CurrentCell.RowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    strLanguage = "eng";
                }
            }
                

            switch (tabControlSinumerik.SelectedTab.Name)
            {
                case "PLCAlarmText":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "oem_alarms_plc_" + strLanguage + ".ts";
                    break;
                case "CycleAlarms":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "oem_alarms_cycles_" + strLanguage + ".ts";
                    break;
                case "Messages":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "oem_partprogram_messages_" + strLanguage + ".ts";
                    break;
                case "RunMyScreen":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "aluc_" + strLanguage + ".txt";
                    break;
                case "EasyXML":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "oem_aggregate_" + strLanguage + ".ts";
                    break;
                case "ToolManagement":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "sltmlistdialog_" + strLanguage + ".ts";
                    break;
                case "MaintenancePlanner":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "oem_maintenance_" + strLanguage + ".ts";
                    break;
                case "UserMachineData":
                    textBoxSourceFileFolder.Text = "/card/oem/sinumerik/hmi/lng/";
                    textBoxSourceFile.Text = "user_machine_data_" + strLanguage + ".ts";
                    break;
            }

        }



        private void textBoxProjectFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            //CheckSelectedLanguages();
        }

        private void writeTextfile_Click(object sender, EventArgs e)
        {
            CreateOutputFile();
        }

        private void CreateOutputFile()
        {
            if (SinumerikProjectFolder == "")
            {
                MessageBox.Show("Create a Sinumerik Project First!", "Project is Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string outputfile = SinumerikProjectFolder + "/" + textBoxSourceFile.Text;
                //MessageBox.Show($"I write xml here: {outputfile}","Here is the Output", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                //settings.IndentChars = ("   ");
                settings.OmitXmlDeclaration = true;
                //settings.ConformanceLevel = ConformanceLevel.Fragment;
                settings.NewLineOnAttributes = true;


                int numRowMax = dataGridViewMSG.RowCount - 1;

                using (XmlWriter writer = XmlWriter.Create(outputfile,settings))                  
                {
                    writer.WriteDocType("TS",null,null,null);
                    writer.WriteStartElement("TS");
                    writer.WriteStartElement("context");
                    writer.WriteElementString("name", "partprogmsg01");

                    foreach (DataGridViewRow row in dataGridViewMSG.Rows)
                    {
                        if (row.Cells[0].RowIndex < dataGridViewMSG.RowCount-1)
                        {
                            writer.WriteStartElement("message");
                            writer.WriteElementString("source", row.Cells[0].Value.ToString());
                            writer.WriteElementString("translation", row.Cells[1].Value.ToString());
                            writer.WriteEndElement();
                        }

                    }
                }
            }
        }

        private void SourceCode_Click(object sender, EventArgs e)
        {
            string outputfile = SinumerikProjectFolder + "/" + textBoxSourceFile.Text;
            Npp.notepad.OpenFile(outputfile);
            //Npp.notepad.GetOpenFileNames
            Npp.notepad.SetCurrentLanguage(LangType.L_XML);
            
        }
       
        private void Translate_Click(object sender, EventArgs e)
        {
            string[] SinuLang = { "chs", "cht", "csy", "dan", "nld", "eng", "fin", "fra", "deu", "hun", "ind", "ita", "jpn", "kor", "msl", "plk", "ptb", "rom", "rus", "sky", "slv", "esp", "sve", "tha", "trk", "vit" };

            string[] MyMemLang = { "zh-CHS", "zh-CHT", "cs", "da", "nl", "en", "fi", "fr", "de", "hu", "id", "it", "ja", "ko", "ms", "pl", "pt", "ro", "ru", "sk", "sl", "es", "sv", "th", "tr", "vi" };

            int addRow = dataGridViewMSG.CurrentCell.RowIndex;
            //dataGridViewMSG.Rows[addRow].Cells[1].Value = TranslateMyMem( "en", "de", (dataGridViewMSG.Rows[addRow].Cells[1].Value.ToString()));

            string FromLang = "en";
            string ToLang = "en";

            MyMemoryTranslateEngine myMemoryTranslateEngine = new MyMemoryTranslateEngine();
            if (dataGridViewMSG.Rows[addRow].Cells[0].ReadOnly)
            {
                ToLang = dataGridViewMSG.Rows[addRow].Cells[0].Value.ToString();
                //myMemoryTranslateEngine.SupportedSinumerikLanguages. ;

                for (int i = 0; i < SinuLang.Length; i++)
                {
                    if (SinuLang[i] == ToLang)
                    {
                        ToLang = MyMemLang[i].ToString();
                        break;
                    }
                }

                 if(ToLang != FromLang)
                {
                    dataGridViewMSG.Rows[addRow].Cells[1].Value = myMemoryTranslateEngine.Translate(FromLang, ToLang, (dataGridViewMSG.Rows[addRow].Cells[1].Value.ToString()));
                }
                else
                {
                    MessageBox.Show($"Translation of text:{dataGridViewMSG.Rows[addRow].Cells[1].Value.ToString()} from<{FromLang}> to <{ToLang}> is not possible ", "Same Language Selected!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateNewLastLine(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CellUpdateForTriggers.newLine = true;
            if ((CellUpdateForTriggers.newId) && (CellUpdateForTriggers.newText) && (CellUpdateForTriggers.newLine))
            {
                CellUpdateForTriggers.newId = false;
                CellUpdateForTriggers.newText = false;
                CellUpdateForTriggers.newLine = false;
                UpdateNewLastLine();
            }
        }

        private void dataGridViewMSG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewMSG.RowCount >=2)
            {
                if ((dataGridViewMSG.Rows[dataGridViewMSG.CurrentCell.RowIndex].Cells[0].ReadOnly == false) && (dataGridViewMSG.CurrentCell.RowIndex == dataGridViewMSG.RowCount - 2))
                {
                    if (dataGridViewMSG.CurrentCell.ColumnIndex == 0)
                    {
                        CellUpdateForTriggers.newId = true;
                    }
                    if (dataGridViewMSG.CurrentCell.ColumnIndex == 1)
                    {
                        CellUpdateForTriggers.newText = true;
                    }
                }
                if ((CellUpdateForTriggers.newId) && (CellUpdateForTriggers.newText) && (CellUpdateForTriggers.newLine))
                {
                    CellUpdateForTriggers.newId = false;
                    CellUpdateForTriggers.newText = false;
                    CellUpdateForTriggers.newLine = false;
                    UpdateNewLastLine();
                }
            }
           
            
            
        }

        private void dataGridViewMSG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((CellUpdateForTriggers.newId) && (CellUpdateForTriggers.newText) && (CellUpdateForTriggers.newLine))
            {
                CellUpdateForTriggers.newId = false;
                CellUpdateForTriggers.newText = false;
                CellUpdateForTriggers.newLine = false;
                UpdateNewLastLine();
            }
        }

        private void dataGridViewMSG_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CellUpdateForTriggers.newLine = true;
            if ((CellUpdateForTriggers.newId) && (CellUpdateForTriggers.newText) && (CellUpdateForTriggers.newLine))
            {
                CellUpdateForTriggers.newId = false;
                CellUpdateForTriggers.newText = false;
                CellUpdateForTriggers.newLine = false;
                UpdateNewLastLine();
            }
        }
    }

    class CellUpdateForTriggers
    {
        public static bool newLine;
        public static bool newId;
        public static bool newText;
    }
}
