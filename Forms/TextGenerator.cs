using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NppDemo.Forms
{
    public partial class TextGenerator : Form
    {
        public List<MessagesList> MSGmessages {  get; set; }

        public string SinumerikProjectFolder;
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
                if (checkedListBoxLanguage.GetItemChecked(i))
                {
                    numLanguagesSelected++;
                }
            }
            //minus 1 for default language English
            numLanguagesSelected = numLanguagesSelected - 1;
            numLanguagesSelectedOld = numLanguagesSelected;

        }

        private void LangCheckBoxItemChange(object sender, EventArgs e)
        {
            UpdateSelectedLanguages();
        }

        private void UpdateSelectedLanguages()
        {
            string ThisLanguageHasChanged = "";

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
                    numLanguagesSelected = 0;
                    for (int i = 0; i < checkedListBoxLanguage.Items.Count; i++)
                    {
                        if (checkedListBoxLanguage.GetItemChecked(i))
                        {
                            numLanguagesSelected++;
                        }
                    }
                    //minus 1 for default language English
                    numLanguagesSelected = numLanguagesSelected - 1;
                    if ((numLanguagesSelected > numLanguagesSelectedOld) && (numLanguagesSelected > 0))
                    {
                        int numRowMax = dataGridViewMSG.RowCount - 1;
                        //Pre Check if Language might already exists
                        int preCheckLanguage = 0;
                        if (numRowMax> numLanguagesSelected)
                        {
                            preCheckLanguage = numLanguagesSelected;
                        }
                        else
                        {
                            preCheckLanguage = numRowMax;
                        }
                        bool skipAddLanguage = false;
                        for (int i = 0;i < preCheckLanguage; i++)
                        {
                            string ThisRowsValue = dataGridViewMSG.Rows[i].Cells[0].Value.ToString();
                            if (ThisLanguageHasChanged == ThisRowsValue)                                
                            {
                                skipAddLanguage = true;
                            }
                        }
                        if (!skipAddLanguage)
                        {
                            //Get Row numbers without the translation lines
                            int GetRealLanguageLineNumber = 0;
                            for (int i = 0; i<numRowMax; i++)
                            {
                                if(dataGridViewMSG.Rows[i].Cells[0].ReadOnly != true)
                                {
                                    GetRealLanguageLineNumber++;
                                }
                            }


                            for (int intDefaulLanguageRow = 0; intDefaulLanguageRow < GetRealLanguageLineNumber; intDefaulLanguageRow++)
                            {

                                for (int addRow = 1; addRow <= numLanguagesSelected; addRow++)
                                {
                                    //Get new Language from ticked checkbox
                                    int getTextCounter = 0;
                                    string writeLangText = "";
                                    for (int getText = 0; getText < checkedListBoxLanguage.Items.Count; getText++)
                                    {
                                        if (checkedListBoxLanguage.GetItemChecked(getText))
                                        {
                                            getTextCounter++;
                                            if (getTextCounter == addRow + 1)
                                            {
                                                //writeLangText = checkedListBoxLanguage.GetItemText(getText);
                                                writeLangText = checkedListBoxLanguage.Items[getText].ToString();
                                            }

                                        }
                                    }
                                    //Scan Table for already used langues lines
                                    bool LanguageLineIsNew = true;
                                    int intLastSearchRow = 0;
                                    //if ((numRowMax - numLanguagesSelected) > intDefaulLanguageRow) //Hier ist vermutlich irgendwo der Fehler

                                    if ((numLanguagesSelected* (intDefaulLanguageRow + 1)) < numRowMax) //Hier ist vermutlich irgendwo der Fehler
                                    {
                                        intLastSearchRow = numLanguagesSelected *(intDefaulLanguageRow  + 1);
                                        //intLastSearchRow = intDefaulLanguageRow + numLanguagesSelected;
                                    }
                                    else
                                    {
                                        //intLastSearchRow = numRowMax - intRows- 1;
                                        intLastSearchRow = numRowMax;
                                    }

                                    for (int SearchRows = intDefaulLanguageRow; SearchRows <= intLastSearchRow; SearchRows++)
                                    {
                                        string ThisCellValue = dataGridViewMSG.Rows[SearchRows].Cells[0].Value.ToString();
                                        if (writeLangText == ThisCellValue)
                                        {
                                            LanguageLineIsNew = false;
                                        }
                                    }

                                    //if the new ticked Language is not existing in Table add the line
                                    if (LanguageLineIsNew)
                                    {                                     
                                        dataGridViewMSG.Rows.Insert(intDefaulLanguageRow * numLanguagesSelected + addRow);


                                        dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected + addRow].Cells[0].Value = writeLangText;
                                        dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected + addRow].Cells[0].ReadOnly = true;
                                        dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected + addRow].Cells[0].ToolTipText = "Translation in (" + writeLangText + ") for " + dataGridViewMSG.Columns[0].Name + ": " + dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected].Cells[0].Value;
                                        dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected + addRow].Cells[1].Value = dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected].Cells[1].Value;
                                        dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected + addRow].Cells[1].ToolTipText = "Translation in (" + writeLangText + ")  for " + dataGridViewMSG.Columns[1].Name + ": " + dataGridViewMSG.Rows[intDefaulLanguageRow * numLanguagesSelected].Cells[1].Value;
                                        /*
                                        dataGridViewMSG.Rows.Insert(intRows * (numLanguagesSelected + 1) + addRow);


                                        dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1) + addRow].Cells[0].Value = writeLangText;
                                        dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1) + addRow].Cells[0].ReadOnly = true;
                                        dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1) + addRow].Cells[0].ToolTipText = "Translation in (" + writeLangText + ") for " + dataGridViewMSG.Columns[0].Name + ": " + dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1)].Cells[0].Value;
                                        dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1) + addRow].Cells[1].Value = dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1)].Cells[1].Value;
                                        dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1) + addRow].Cells[1].ToolTipText = "Translation in (" + writeLangText + ")  for " + dataGridViewMSG.Columns[1].Name + ": " + dataGridViewMSG.Rows[intRows * (numLanguagesSelected + 1)].Cells[1].Value;
                                        */

                                    }
                                }

                            }

                        }

                        //MessageBox.Show($"Selected Languages: {dataGridViewMSG.RowCount}", "Languages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if ((numLanguagesSelected < numLanguagesSelectedOld))
                    {
                        int numRowMax = dataGridViewMSG.RowCount - 1;
                        for (int intRows = numRowMax-1; intRows > 0 ; intRows--)
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

            //Store the number of selected Languages in numLanguagesSelectedOld
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
        private void MoreMessages()
        {
            //throw new NotImplementedException();
            //var MSGlist = new List<MessagesList>();
            //MSGlist.Add(new MessagesList() { MessageID = 11, MessageTransEng = "Text English 11" });

            //MSGmessages.Add(MSGmessages(){ MessageID = 11,MessageTransEng = "Text English 11"});
            MSGmessages.Insert(3, new MessagesList() { MessageID = 11, MessageTransEng = "Text English 11" });


            //return MSGlist;

        }


        private void MSGList_Form_Load(object sender, EventArgs e)
        {
            //this.MSGmessages = 
                
            //this.MSGmessages = GetMessages();

            //var MSGmessages = this.MSGmessages;
            dataGridViewMSG.ColumnCount = 2;
            dataGridViewMSG.RowCount = 2;
            dataGridViewMSG.Columns[0].Name = "Message ID";
            dataGridViewMSG.Columns[1].Name = "MSG Text";
            
            //dataGridViewMSG.DataSource = MSGmessages;
            dataGridViewMSG.AllowUserToAddRows = true;
            //dataGridViewMSG.Columns["MessageID"].Name = "Message ID";
            //dataGridViewMSG.Columns["MessageID"].DataPropertyName = "Message ID"; 
            //dataGridViewMSG.Columns[0].Name = "Message ID";
            // column.H
            //dataGridViewMSG.Columns["MessageTransEng"].Name = "MSG Text";

            //MoreMessages();
            //dataGridViewMSG.Refresh();
            //dataGridViewMSG.DataSource = MSGmessages;
            //dataGridViewMSG.Rows.Add(MSGmessages);
        }
        private void MSGList_Initialize()
        {
            //this.MSGmessages = 

            //this.MSGmessages = GetMessages();

            //var MSGmessages = this.MSGmessages;
            dataGridViewMSG.ColumnCount = 2;
            dataGridViewMSG.RowCount = 2;
            dataGridViewMSG.Columns[0].Name = "Message ID";
            dataGridViewMSG.Columns[0].Width= 120;
            dataGridViewMSG.Columns[1].Name = "MSG Text";
            dataGridViewMSG.Columns[1].Width = 400;

            //dataGridViewMSG.DataSource = MSGmessages;
            dataGridViewMSG.AllowUserToAddRows = true;
            //dataGridViewMSG.Columns["MessageID"].Name = "Message ID";
            //dataGridViewMSG.Columns["MessageID"].DataPropertyName = "Message ID"; 
            //dataGridViewMSG.Columns[0].Name = "Message ID";
            // column.H
            //dataGridViewMSG.Columns["MessageTransEng"].Name = "MSG Text";

            //MoreMessages();
            //dataGridViewMSG.Refresh();
            //dataGridViewMSG.DataSource = MSGmessages;
            //dataGridViewMSG.Rows.Add(MSGmessages);
        }

        private void MSGList_Form_AddRow(object sender, EventArgs e)
        {

            //dataGridViewMSG.SelectedCells.Contains();
            //if (dataGridViewMSG.SelectedRows[0] == dataGridViewMSG.RowCount) 
            //dataGridViewMSG.RowCount = dataGridViewMSG.RowCount + 1;

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

        private void textBoxSetalarm_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Notepad Textgenerator Text Changed", "Text Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //tableLayoutSetalarm.
            switch (tableLayoutSetalarm.GetColumn(tableLayoutSetalarm))
            {
                case 0:
                   // if (tableLayoutSetalarm.)
                    break;


            }
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
        }

        private void DisplayFoldersAndFiles(object sender, EventArgs e)
        {

            UpdateFoldersAndFiles();

        }
        private void UpdateFoldersAndFiles()
        {

            string strLanguage = "eng";
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
    }
}
