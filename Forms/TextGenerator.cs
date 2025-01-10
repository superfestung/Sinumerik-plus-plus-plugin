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

        public TextGenerator()
        {
            MSGmessages = GetMessages();
            
            InitializeComponent();
            MSGList_Initialize();
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
            dataGridViewMSG.RowCount = dataGridViewMSG.RowCount + 1;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
