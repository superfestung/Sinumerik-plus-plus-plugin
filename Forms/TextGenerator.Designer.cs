namespace NppDemo.Forms
{
    partial class TextGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item 1",
            "subitem"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Item2");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("item3");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "item4",
            "subitem1",
            "subitem2"}, -1);
            this.tabControlSinumerik = new System.Windows.Forms.TabControl();
            this.PLCAlarmText = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CycleAlarms = new System.Windows.Forms.TabPage();
            this.tableLayoutSetalarm = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSetalarmTxt1 = new System.Windows.Forms.TextBox();
            this.textBoxSetalarmNum1 = new System.Windows.Forms.TextBox();
            this.textBoxSetalarmNumHeadline = new System.Windows.Forms.TextBox();
            this.textBoxSetalarmTxtHeadline = new System.Windows.Forms.TextBox();
            this.textBoxSetalarmNum0 = new System.Windows.Forms.TextBox();
            this.textBoxSetalarmTxt0 = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.TabPage();
            this.dataGridViewMSG = new System.Windows.Forms.DataGridView();
            this.RunMyScreen = new System.Windows.Forms.TabPage();
            this.EasyXML = new System.Windows.Forms.TabPage();
            this.ToolManagement = new System.Windows.Forms.TabPage();
            this.MaintenancePlanner = new System.Windows.Forms.TabPage();
            this.UserMachineData = new System.Windows.Forms.TabPage();
            this.checkedListBoxLanguage = new System.Windows.Forms.CheckedListBox();
            this.writeTextfile = new System.Windows.Forms.Button();
            this.HelpPreview = new System.Windows.Forms.Button();
            this.SourceCode = new System.Windows.Forms.Button();
            this.Translate = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxProjectFolder = new System.Windows.Forms.TextBox();
            this.textBoxSourceFileFolder = new System.Windows.Forms.TextBox();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSinumerikProject = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlSinumerik.SuspendLayout();
            this.PLCAlarmText.SuspendLayout();
            this.CycleAlarms.SuspendLayout();
            this.tableLayoutSetalarm.SuspendLayout();
            this.Messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMSG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSinumerik
            // 
            this.tabControlSinumerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSinumerik.Controls.Add(this.PLCAlarmText);
            this.tabControlSinumerik.Controls.Add(this.CycleAlarms);
            this.tabControlSinumerik.Controls.Add(this.Messages);
            this.tabControlSinumerik.Controls.Add(this.RunMyScreen);
            this.tabControlSinumerik.Controls.Add(this.EasyXML);
            this.tabControlSinumerik.Controls.Add(this.ToolManagement);
            this.tabControlSinumerik.Controls.Add(this.MaintenancePlanner);
            this.tabControlSinumerik.Controls.Add(this.UserMachineData);
            this.tabControlSinumerik.Location = new System.Drawing.Point(3, 224);
            this.tabControlSinumerik.Name = "tabControlSinumerik";
            this.tabControlSinumerik.SelectedIndex = 0;
            this.tabControlSinumerik.Size = new System.Drawing.Size(815, 609);
            this.tabControlSinumerik.TabIndex = 0;
            this.tabControlSinumerik.SelectedIndexChanged += new System.EventHandler(this.DisplayFoldersAndFiles);
            // 
            // PLCAlarmText
            // 
            this.PLCAlarmText.Controls.Add(this.listView1);
            this.PLCAlarmText.Location = new System.Drawing.Point(4, 22);
            this.PLCAlarmText.Name = "PLCAlarmText";
            this.PLCAlarmText.Padding = new System.Windows.Forms.Padding(3);
            this.PLCAlarmText.Size = new System.Drawing.Size(807, 583);
            this.PLCAlarmText.TabIndex = 0;
            this.PLCAlarmText.Text = "PLC Alarm Text";
            this.PLCAlarmText.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1081, 503);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CycleAlarms
            // 
            this.CycleAlarms.Controls.Add(this.tableLayoutSetalarm);
            this.CycleAlarms.Location = new System.Drawing.Point(4, 22);
            this.CycleAlarms.Name = "CycleAlarms";
            this.CycleAlarms.Padding = new System.Windows.Forms.Padding(3);
            this.CycleAlarms.Size = new System.Drawing.Size(807, 583);
            this.CycleAlarms.TabIndex = 1;
            this.CycleAlarms.Text = "Cycle Alarms(SETAL)";
            this.CycleAlarms.UseVisualStyleBackColor = true;
            // 
            // tableLayoutSetalarm
            // 
            this.tableLayoutSetalarm.AutoScroll = true;
            this.tableLayoutSetalarm.ColumnCount = 2;
            this.tableLayoutSetalarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutSetalarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmTxt1, 1, 2);
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmNum1, 0, 2);
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmNumHeadline, 0, 0);
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmTxtHeadline, 1, 0);
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmNum0, 0, 1);
            this.tableLayoutSetalarm.Controls.Add(this.textBoxSetalarmTxt0, 1, 1);
            this.tableLayoutSetalarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSetalarm.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutSetalarm.Name = "tableLayoutSetalarm";
            this.tableLayoutSetalarm.RowCount = 30;
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutSetalarm.Size = new System.Drawing.Size(801, 577);
            this.tableLayoutSetalarm.TabIndex = 12;
            this.tableLayoutSetalarm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxSetalarmTxt1
            // 
            this.textBoxSetalarmTxt1.Location = new System.Drawing.Point(105, 47);
            this.textBoxSetalarmTxt1.MinimumSize = new System.Drawing.Size(300, 20);
            this.textBoxSetalarmTxt1.Name = "textBoxSetalarmTxt1";
            this.textBoxSetalarmTxt1.Size = new System.Drawing.Size(962, 20);
            this.textBoxSetalarmTxt1.TabIndex = 5;
            this.textBoxSetalarmTxt1.TextChanged += new System.EventHandler(this.textBoxSetalarm_TextChanged);
            // 
            // textBoxSetalarmNum1
            // 
            this.textBoxSetalarmNum1.Location = new System.Drawing.Point(3, 47);
            this.textBoxSetalarmNum1.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNum1.Name = "textBoxSetalarmNum1";
            this.textBoxSetalarmNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNum1.TabIndex = 4;
            this.textBoxSetalarmNum1.TextChanged += new System.EventHandler(this.textBoxSetalarm_TextChanged);
            // 
            // textBoxSetalarmNumHeadline
            // 
            this.textBoxSetalarmNumHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSetalarmNumHeadline.Enabled = false;
            this.textBoxSetalarmNumHeadline.Location = new System.Drawing.Point(3, 3);
            this.textBoxSetalarmNumHeadline.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNumHeadline.Name = "textBoxSetalarmNumHeadline";
            this.textBoxSetalarmNumHeadline.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNumHeadline.TabIndex = 0;
            this.textBoxSetalarmNumHeadline.Text = "Alarm Number";
            // 
            // textBoxSetalarmTxtHeadline
            // 
            this.textBoxSetalarmTxtHeadline.Enabled = false;
            this.textBoxSetalarmTxtHeadline.Location = new System.Drawing.Point(105, 3);
            this.textBoxSetalarmTxtHeadline.MinimumSize = new System.Drawing.Size(300, 20);
            this.textBoxSetalarmTxtHeadline.Name = "textBoxSetalarmTxtHeadline";
            this.textBoxSetalarmTxtHeadline.Size = new System.Drawing.Size(962, 20);
            this.textBoxSetalarmTxtHeadline.TabIndex = 1;
            this.textBoxSetalarmTxtHeadline.Text = "Displayed Alarm Text";
            this.textBoxSetalarmTxtHeadline.TextChanged += new System.EventHandler(this.textBoxSetalarmTxt0_TextChanged);
            // 
            // textBoxSetalarmNum0
            // 
            this.textBoxSetalarmNum0.Location = new System.Drawing.Point(3, 25);
            this.textBoxSetalarmNum0.MinimumSize = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNum0.Name = "textBoxSetalarmNum0";
            this.textBoxSetalarmNum0.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetalarmNum0.TabIndex = 2;
            this.textBoxSetalarmNum0.TextChanged += new System.EventHandler(this.textBoxSetalarm_TextChanged);
            // 
            // textBoxSetalarmTxt0
            // 
            this.textBoxSetalarmTxt0.Location = new System.Drawing.Point(105, 25);
            this.textBoxSetalarmTxt0.MinimumSize = new System.Drawing.Size(300, 20);
            this.textBoxSetalarmTxt0.Name = "textBoxSetalarmTxt0";
            this.textBoxSetalarmTxt0.Size = new System.Drawing.Size(962, 20);
            this.textBoxSetalarmTxt0.TabIndex = 3;
            this.textBoxSetalarmTxt0.TextChanged += new System.EventHandler(this.textBoxSetalarm_TextChanged);
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.dataGridViewMSG);
            this.Messages.Location = new System.Drawing.Point(4, 22);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(807, 583);
            this.Messages.TabIndex = 2;
            this.Messages.Text = "Messages(MSG)";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMSG
            // 
            this.dataGridViewMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMSG.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMSG.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMSG.Name = "dataGridViewMSG";
            this.dataGridViewMSG.RowTemplate.Height = 24;
            this.dataGridViewMSG.Size = new System.Drawing.Size(812, 589);
            this.dataGridViewMSG.TabIndex = 0;
            // 
            // RunMyScreen
            // 
            this.RunMyScreen.Location = new System.Drawing.Point(4, 22);
            this.RunMyScreen.Name = "RunMyScreen";
            this.RunMyScreen.Size = new System.Drawing.Size(807, 583);
            this.RunMyScreen.TabIndex = 3;
            this.RunMyScreen.Text = "Run MyScreen";
            this.RunMyScreen.UseVisualStyleBackColor = true;
            // 
            // EasyXML
            // 
            this.EasyXML.Location = new System.Drawing.Point(4, 22);
            this.EasyXML.Name = "EasyXML";
            this.EasyXML.Size = new System.Drawing.Size(807, 583);
            this.EasyXML.TabIndex = 4;
            this.EasyXML.Text = "EasyXML";
            this.EasyXML.UseVisualStyleBackColor = true;
            // 
            // ToolManagement
            // 
            this.ToolManagement.Location = new System.Drawing.Point(4, 22);
            this.ToolManagement.Name = "ToolManagement";
            this.ToolManagement.Size = new System.Drawing.Size(807, 583);
            this.ToolManagement.TabIndex = 5;
            this.ToolManagement.Text = "Tool Management";
            this.ToolManagement.UseVisualStyleBackColor = true;
            // 
            // MaintenancePlanner
            // 
            this.MaintenancePlanner.Location = new System.Drawing.Point(4, 22);
            this.MaintenancePlanner.Name = "MaintenancePlanner";
            this.MaintenancePlanner.Size = new System.Drawing.Size(807, 583);
            this.MaintenancePlanner.TabIndex = 6;
            this.MaintenancePlanner.Text = "Maintenance Planner(828D)";
            this.MaintenancePlanner.UseVisualStyleBackColor = true;
            // 
            // UserMachineData
            // 
            this.UserMachineData.Location = new System.Drawing.Point(4, 22);
            this.UserMachineData.Name = "UserMachineData";
            this.UserMachineData.Size = new System.Drawing.Size(807, 583);
            this.UserMachineData.TabIndex = 7;
            this.UserMachineData.Text = "User Machine Data";
            this.UserMachineData.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxLanguage
            // 
            this.checkedListBoxLanguage.FormattingEnabled = true;
            this.checkedListBoxLanguage.Items.AddRange(new object[] {
            "eng(default)",
            "deu",
            "esp",
            "fra",
            "kor",
            "chs",
            "cht",
            "ita",
            "ptb",
            "dan",
            "fin",
            "ind",
            "jpn",
            "msl",
            "nld",
            "plk",
            "rom",
            "rus",
            "sve",
            "slv",
            "sky",
            "tha",
            "csy",
            "trk",
            "hun",
            "vit"});
            this.checkedListBoxLanguage.Location = new System.Drawing.Point(12, 109);
            this.checkedListBoxLanguage.Name = "checkedListBoxLanguage";
            this.checkedListBoxLanguage.Size = new System.Drawing.Size(116, 109);
            this.checkedListBoxLanguage.TabIndex = 5;
            this.checkedListBoxLanguage.SelectedValueChanged += new System.EventHandler(this.LangCheckBoxItemChange);
            // 
            // writeTextfile
            // 
            this.writeTextfile.Location = new System.Drawing.Point(141, 109);
            this.writeTextfile.Name = "writeTextfile";
            this.writeTextfile.Size = new System.Drawing.Size(96, 29);
            this.writeTextfile.TabIndex = 6;
            this.writeTextfile.Text = "Write to Textfile";
            this.writeTextfile.UseVisualStyleBackColor = true;
            // 
            // HelpPreview
            // 
            this.HelpPreview.Location = new System.Drawing.Point(141, 144);
            this.HelpPreview.Name = "HelpPreview";
            this.HelpPreview.Size = new System.Drawing.Size(96, 29);
            this.HelpPreview.TabIndex = 7;
            this.HelpPreview.Text = "Help Preview";
            this.HelpPreview.UseVisualStyleBackColor = true;
            // 
            // SourceCode
            // 
            this.SourceCode.Location = new System.Drawing.Point(141, 179);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Size = new System.Drawing.Size(96, 29);
            this.SourceCode.TabIndex = 8;
            this.SourceCode.Text = "Source Code";
            this.SourceCode.UseVisualStyleBackColor = true;
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(243, 109);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(96, 29);
            this.Translate.TabIndex = 9;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(243, 144);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(96, 29);
            this.Export.TabIndex = 10;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(243, 179);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(96, 29);
            this.Import.TabIndex = 11;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 18);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProjectFolder
            // 
            this.textBoxProjectFolder.Location = new System.Drawing.Point(103, 2);
            this.textBoxProjectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProjectFolder.Name = "textBoxProjectFolder";
            this.textBoxProjectFolder.ReadOnly = true;
            this.textBoxProjectFolder.Size = new System.Drawing.Size(317, 20);
            this.textBoxProjectFolder.TabIndex = 13;
            this.textBoxProjectFolder.TextChanged += new System.EventHandler(this.textBoxProjectFolder_TextChanged);
            // 
            // textBoxSourceFileFolder
            // 
            this.textBoxSourceFileFolder.Location = new System.Drawing.Point(103, 25);
            this.textBoxSourceFileFolder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSourceFileFolder.Name = "textBoxSourceFileFolder";
            this.textBoxSourceFileFolder.ReadOnly = true;
            this.textBoxSourceFileFolder.Size = new System.Drawing.Size(317, 20);
            this.textBoxSourceFileFolder.TabIndex = 14;
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(103, 48);
            this.textBoxSourceFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.ReadOnly = true;
            this.textBoxSourceFile.Size = new System.Drawing.Size(317, 20);
            this.textBoxSourceFile.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sinumerik Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Textfile Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Actual Textfile";
            // 
            // folderBrowserDialogSinumerikProject
            // 
            this.folderBrowserDialogSinumerikProject.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status Textfile";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 20;
            // 
            // TextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 833);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSourceFile);
            this.Controls.Add(this.textBoxSourceFileFolder);
            this.Controls.Add(this.textBoxProjectFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.SourceCode);
            this.Controls.Add(this.HelpPreview);
            this.Controls.Add(this.writeTextfile);
            this.Controls.Add(this.checkedListBoxLanguage);
            this.Controls.Add(this.tabControlSinumerik);
            this.Name = "TextGenerator";
            this.Text = "TextGenerator";
            this.tabControlSinumerik.ResumeLayout(false);
            this.PLCAlarmText.ResumeLayout(false);
            this.CycleAlarms.ResumeLayout(false);
            this.tableLayoutSetalarm.ResumeLayout(false);
            this.tableLayoutSetalarm.PerformLayout();
            this.Messages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMSG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSinumerik;
        private System.Windows.Forms.TabPage PLCAlarmText;
        private System.Windows.Forms.TabPage CycleAlarms;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage RunMyScreen;
        private System.Windows.Forms.TabPage EasyXML;
        private System.Windows.Forms.TabPage ToolManagement;
        private System.Windows.Forms.TabPage MaintenancePlanner;
        private System.Windows.Forms.TabPage UserMachineData;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguage;
        private System.Windows.Forms.Button writeTextfile;
        private System.Windows.Forms.Button HelpPreview;
        private System.Windows.Forms.Button SourceCode;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSetalarm;
        private System.Windows.Forms.TextBox textBoxSetalarmNumHeadline;
        private System.Windows.Forms.TextBox textBoxSetalarmTxtHeadline;
        private System.Windows.Forms.TextBox textBoxSetalarmNum0;
        private System.Windows.Forms.TextBox textBoxSetalarmTxt0;
        private System.Windows.Forms.TextBox textBoxSetalarmNum1;
        private System.Windows.Forms.TextBox textBoxSetalarmTxt1;
        private System.Windows.Forms.DataGridView dataGridViewMSG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxProjectFolder;
        private System.Windows.Forms.TextBox textBoxSourceFileFolder;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSinumerikProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}