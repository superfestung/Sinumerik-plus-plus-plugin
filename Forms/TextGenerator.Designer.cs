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
            this.tabControlSinumerik = new System.Windows.Forms.TabControl();
            this.PLCAlarmText = new System.Windows.Forms.TabPage();
            this.CycleAlarms = new System.Windows.Forms.TabPage();
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
            this.tabControlSinumerik.Location = new System.Drawing.Point(4, 276);
            this.tabControlSinumerik.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlSinumerik.Name = "tabControlSinumerik";
            this.tabControlSinumerik.SelectedIndex = 0;
            this.tabControlSinumerik.Size = new System.Drawing.Size(1087, 750);
            this.tabControlSinumerik.TabIndex = 0;
            this.tabControlSinumerik.SelectedIndexChanged += new System.EventHandler(this.DisplayFoldersAndFiles);
            // 
            // PLCAlarmText
            // 
            this.PLCAlarmText.Location = new System.Drawing.Point(4, 25);
            this.PLCAlarmText.Margin = new System.Windows.Forms.Padding(4);
            this.PLCAlarmText.Name = "PLCAlarmText";
            this.PLCAlarmText.Padding = new System.Windows.Forms.Padding(4);
            this.PLCAlarmText.Size = new System.Drawing.Size(1079, 721);
            this.PLCAlarmText.TabIndex = 0;
            this.PLCAlarmText.Text = "PLC Alarm Text";
            this.PLCAlarmText.UseVisualStyleBackColor = true;
            // 
            // CycleAlarms
            // 
            this.CycleAlarms.Location = new System.Drawing.Point(4, 25);
            this.CycleAlarms.Margin = new System.Windows.Forms.Padding(4);
            this.CycleAlarms.Name = "CycleAlarms";
            this.CycleAlarms.Padding = new System.Windows.Forms.Padding(4);
            this.CycleAlarms.Size = new System.Drawing.Size(1079, 721);
            this.CycleAlarms.TabIndex = 1;
            this.CycleAlarms.Text = "Cycle Alarms(SETAL)";
            this.CycleAlarms.UseVisualStyleBackColor = true;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.dataGridViewMSG);
            this.Messages.Location = new System.Drawing.Point(4, 25);
            this.Messages.Margin = new System.Windows.Forms.Padding(4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(4);
            this.Messages.Size = new System.Drawing.Size(1079, 721);
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
            this.dataGridViewMSG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMSG.Name = "dataGridViewMSG";
            this.dataGridViewMSG.RowTemplate.Height = 24;
            this.dataGridViewMSG.Size = new System.Drawing.Size(1083, 725);
            this.dataGridViewMSG.TabIndex = 0;
            this.dataGridViewMSG.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMSG_CellEnter);
            this.dataGridViewMSG.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMSG_CellValueChanged);
            this.dataGridViewMSG.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewMSG_RowsAdded);
            this.dataGridViewMSG.Click += new System.EventHandler(this.DisplayFoldersAndFiles);
            // 
            // RunMyScreen
            // 
            this.RunMyScreen.Location = new System.Drawing.Point(4, 25);
            this.RunMyScreen.Margin = new System.Windows.Forms.Padding(4);
            this.RunMyScreen.Name = "RunMyScreen";
            this.RunMyScreen.Size = new System.Drawing.Size(1079, 721);
            this.RunMyScreen.TabIndex = 3;
            this.RunMyScreen.Text = "Run MyScreen";
            this.RunMyScreen.UseVisualStyleBackColor = true;
            // 
            // EasyXML
            // 
            this.EasyXML.Location = new System.Drawing.Point(4, 25);
            this.EasyXML.Margin = new System.Windows.Forms.Padding(4);
            this.EasyXML.Name = "EasyXML";
            this.EasyXML.Size = new System.Drawing.Size(1079, 721);
            this.EasyXML.TabIndex = 4;
            this.EasyXML.Text = "EasyXML";
            this.EasyXML.UseVisualStyleBackColor = true;
            // 
            // ToolManagement
            // 
            this.ToolManagement.Location = new System.Drawing.Point(4, 25);
            this.ToolManagement.Margin = new System.Windows.Forms.Padding(4);
            this.ToolManagement.Name = "ToolManagement";
            this.ToolManagement.Size = new System.Drawing.Size(1079, 721);
            this.ToolManagement.TabIndex = 5;
            this.ToolManagement.Text = "Tool Management";
            this.ToolManagement.UseVisualStyleBackColor = true;
            // 
            // MaintenancePlanner
            // 
            this.MaintenancePlanner.Location = new System.Drawing.Point(4, 25);
            this.MaintenancePlanner.Margin = new System.Windows.Forms.Padding(4);
            this.MaintenancePlanner.Name = "MaintenancePlanner";
            this.MaintenancePlanner.Size = new System.Drawing.Size(1079, 721);
            this.MaintenancePlanner.TabIndex = 6;
            this.MaintenancePlanner.Text = "Maintenance Planner(828D)";
            this.MaintenancePlanner.UseVisualStyleBackColor = true;
            // 
            // UserMachineData
            // 
            this.UserMachineData.Location = new System.Drawing.Point(4, 25);
            this.UserMachineData.Margin = new System.Windows.Forms.Padding(4);
            this.UserMachineData.Name = "UserMachineData";
            this.UserMachineData.Size = new System.Drawing.Size(1079, 721);
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
            this.checkedListBoxLanguage.Location = new System.Drawing.Point(16, 134);
            this.checkedListBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxLanguage.Name = "checkedListBoxLanguage";
            this.checkedListBoxLanguage.Size = new System.Drawing.Size(153, 123);
            this.checkedListBoxLanguage.TabIndex = 5;
            this.checkedListBoxLanguage.Click += new System.EventHandler(this.LangCheckBoxItemChange);
            this.checkedListBoxLanguage.SelectedValueChanged += new System.EventHandler(this.LangCheckBoxItemChange);
            this.checkedListBoxLanguage.MouseLeave += new System.EventHandler(this.LangCheckBoxItemChange);
            // 
            // writeTextfile
            // 
            this.writeTextfile.Location = new System.Drawing.Point(188, 134);
            this.writeTextfile.Margin = new System.Windows.Forms.Padding(4);
            this.writeTextfile.Name = "writeTextfile";
            this.writeTextfile.Size = new System.Drawing.Size(128, 36);
            this.writeTextfile.TabIndex = 6;
            this.writeTextfile.Text = "Write to Textfile";
            this.writeTextfile.UseVisualStyleBackColor = true;
            this.writeTextfile.Click += new System.EventHandler(this.writeTextfile_Click);
            // 
            // HelpPreview
            // 
            this.HelpPreview.Location = new System.Drawing.Point(188, 177);
            this.HelpPreview.Margin = new System.Windows.Forms.Padding(4);
            this.HelpPreview.Name = "HelpPreview";
            this.HelpPreview.Size = new System.Drawing.Size(128, 36);
            this.HelpPreview.TabIndex = 7;
            this.HelpPreview.Text = "Help Preview";
            this.HelpPreview.UseVisualStyleBackColor = true;
            // 
            // SourceCode
            // 
            this.SourceCode.Location = new System.Drawing.Point(188, 220);
            this.SourceCode.Margin = new System.Windows.Forms.Padding(4);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Size = new System.Drawing.Size(128, 36);
            this.SourceCode.TabIndex = 8;
            this.SourceCode.Text = "Source Code";
            this.SourceCode.UseVisualStyleBackColor = true;
            this.SourceCode.Click += new System.EventHandler(this.SourceCode_Click);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(324, 134);
            this.Translate.Margin = new System.Windows.Forms.Padding(4);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(128, 36);
            this.Translate.TabIndex = 9;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(324, 177);
            this.Export.Margin = new System.Windows.Forms.Padding(4);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(128, 36);
            this.Export.TabIndex = 10;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(324, 220);
            this.Import.Margin = new System.Windows.Forms.Padding(4);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(128, 36);
            this.Import.TabIndex = 11;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProjectFolder
            // 
            this.textBoxProjectFolder.Location = new System.Drawing.Point(137, 2);
            this.textBoxProjectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProjectFolder.Name = "textBoxProjectFolder";
            this.textBoxProjectFolder.ReadOnly = true;
            this.textBoxProjectFolder.Size = new System.Drawing.Size(421, 22);
            this.textBoxProjectFolder.TabIndex = 13;
            this.textBoxProjectFolder.TextChanged += new System.EventHandler(this.textBoxProjectFolder_TextChanged);
            // 
            // textBoxSourceFileFolder
            // 
            this.textBoxSourceFileFolder.Location = new System.Drawing.Point(137, 31);
            this.textBoxSourceFileFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSourceFileFolder.Name = "textBoxSourceFileFolder";
            this.textBoxSourceFileFolder.ReadOnly = true;
            this.textBoxSourceFileFolder.Size = new System.Drawing.Size(421, 22);
            this.textBoxSourceFileFolder.TabIndex = 14;
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(137, 59);
            this.textBoxSourceFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.ReadOnly = true;
            this.textBoxSourceFile.Size = new System.Drawing.Size(421, 22);
            this.textBoxSourceFile.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sinumerik Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Textfile Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
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
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status Textfile";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(421, 22);
            this.textBox1.TabIndex = 20;
            // 
            // TextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 1025);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextGenerator";
            this.Text = "TextGenerator";
            this.tabControlSinumerik.ResumeLayout(false);
            this.Messages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMSG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSinumerik;
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
        private System.Windows.Forms.TabPage PLCAlarmText;
    }
}