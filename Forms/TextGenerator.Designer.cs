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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item 1",
            "subitem"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("item3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "item4",
            "subitem1",
            "subitem2"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PLCAlarmText = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CycleAlarms = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Messages = new System.Windows.Forms.TabPage();
            this.RunMyScreen = new System.Windows.Forms.TabPage();
            this.EasyXML = new System.Windows.Forms.TabPage();
            this.ToolManagement = new System.Windows.Forms.TabPage();
            this.MaintenancePlanner = new System.Windows.Forms.TabPage();
            this.UserMachineData = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.writeTextfile = new System.Windows.Forms.Button();
            this.HelpPreview = new System.Windows.Forms.Button();
            this.SourceCode = new System.Windows.Forms.Button();
            this.Translate = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PLCAlarmText.SuspendLayout();
            this.CycleAlarms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PLCAlarmText);
            this.tabControl1.Controls.Add(this.CycleAlarms);
            this.tabControl1.Controls.Add(this.Messages);
            this.tabControl1.Controls.Add(this.RunMyScreen);
            this.tabControl1.Controls.Add(this.EasyXML);
            this.tabControl1.Controls.Add(this.ToolManagement);
            this.tabControl1.Controls.Add(this.MaintenancePlanner);
            this.tabControl1.Controls.Add(this.UserMachineData);
            this.tabControl1.Location = new System.Drawing.Point(3, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // PLCAlarmText
            // 
            this.PLCAlarmText.Controls.Add(this.listView1);
            this.PLCAlarmText.Location = new System.Drawing.Point(4, 22);
            this.PLCAlarmText.Name = "PLCAlarmText";
            this.PLCAlarmText.Padding = new System.Windows.Forms.Padding(3);
            this.PLCAlarmText.Size = new System.Drawing.Size(1073, 493);
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
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1081, 503);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CycleAlarms
            // 
            this.CycleAlarms.Controls.Add(this.tableLayoutPanel1);
            this.CycleAlarms.Location = new System.Drawing.Point(4, 22);
            this.CycleAlarms.Name = "CycleAlarms";
            this.CycleAlarms.Padding = new System.Windows.Forms.Padding(3);
            this.CycleAlarms.Size = new System.Drawing.Size(1073, 415);
            this.CycleAlarms.TabIndex = 1;
            this.CycleAlarms.Text = "Cycle Alarms(SETAL)";
            this.CycleAlarms.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 416);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(4, 22);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1073, 415);
            this.Messages.TabIndex = 2;
            this.Messages.Text = "Messages(MSG)";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // RunMyScreen
            // 
            this.RunMyScreen.Location = new System.Drawing.Point(4, 22);
            this.RunMyScreen.Name = "RunMyScreen";
            this.RunMyScreen.Size = new System.Drawing.Size(1073, 415);
            this.RunMyScreen.TabIndex = 3;
            this.RunMyScreen.Text = "Run MyScreen";
            this.RunMyScreen.UseVisualStyleBackColor = true;
            // 
            // EasyXML
            // 
            this.EasyXML.Location = new System.Drawing.Point(4, 22);
            this.EasyXML.Name = "EasyXML";
            this.EasyXML.Size = new System.Drawing.Size(1073, 415);
            this.EasyXML.TabIndex = 4;
            this.EasyXML.Text = "EasyXML";
            this.EasyXML.UseVisualStyleBackColor = true;
            // 
            // ToolManagement
            // 
            this.ToolManagement.Location = new System.Drawing.Point(4, 22);
            this.ToolManagement.Name = "ToolManagement";
            this.ToolManagement.Size = new System.Drawing.Size(1073, 415);
            this.ToolManagement.TabIndex = 5;
            this.ToolManagement.Text = "Tool Management";
            this.ToolManagement.UseVisualStyleBackColor = true;
            // 
            // MaintenancePlanner
            // 
            this.MaintenancePlanner.Location = new System.Drawing.Point(4, 22);
            this.MaintenancePlanner.Name = "MaintenancePlanner";
            this.MaintenancePlanner.Size = new System.Drawing.Size(1073, 415);
            this.MaintenancePlanner.TabIndex = 6;
            this.MaintenancePlanner.Text = "Maintenance Planner(828D)";
            this.MaintenancePlanner.UseVisualStyleBackColor = true;
            // 
            // UserMachineData
            // 
            this.UserMachineData.Location = new System.Drawing.Point(4, 22);
            this.UserMachineData.Name = "UserMachineData";
            this.UserMachineData.Size = new System.Drawing.Size(1073, 415);
            this.UserMachineData.TabIndex = 7;
            this.UserMachineData.Text = "User Machine Data";
            this.UserMachineData.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "eng(default)",
            "deu",
            "esp",
            "fra",
            "kor",
            "chs",
            "cht",
            "ita",
            "ptb"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(116, 94);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // writeTextfile
            // 
            this.writeTextfile.Location = new System.Drawing.Point(157, 12);
            this.writeTextfile.Name = "writeTextfile";
            this.writeTextfile.Size = new System.Drawing.Size(80, 29);
            this.writeTextfile.TabIndex = 6;
            this.writeTextfile.Text = "Write Textfile";
            this.writeTextfile.UseVisualStyleBackColor = true;
            // 
            // HelpPreview
            // 
            this.HelpPreview.Location = new System.Drawing.Point(157, 47);
            this.HelpPreview.Name = "HelpPreview";
            this.HelpPreview.Size = new System.Drawing.Size(80, 29);
            this.HelpPreview.TabIndex = 7;
            this.HelpPreview.Text = "Help Preview";
            this.HelpPreview.UseVisualStyleBackColor = true;
            // 
            // SourceCode
            // 
            this.SourceCode.Location = new System.Drawing.Point(157, 82);
            this.SourceCode.Name = "SourceCode";
            this.SourceCode.Size = new System.Drawing.Size(80, 29);
            this.SourceCode.TabIndex = 8;
            this.SourceCode.Text = "Source Code";
            this.SourceCode.UseVisualStyleBackColor = true;
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(259, 12);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(80, 29);
            this.Translate.TabIndex = 9;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(259, 47);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(80, 29);
            this.Export.TabIndex = 10;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(259, 82);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(80, 29);
            this.Import.TabIndex = 11;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // TextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 636);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.SourceCode);
            this.Controls.Add(this.HelpPreview);
            this.Controls.Add(this.writeTextfile);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TextGenerator";
            this.Text = "TextGenerator";
            this.tabControl1.ResumeLayout(false);
            this.PLCAlarmText.ResumeLayout(false);
            this.CycleAlarms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PLCAlarmText;
        private System.Windows.Forms.TabPage CycleAlarms;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage RunMyScreen;
        private System.Windows.Forms.TabPage EasyXML;
        private System.Windows.Forms.TabPage ToolManagement;
        private System.Windows.Forms.TabPage MaintenancePlanner;
        private System.Windows.Forms.TabPage UserMachineData;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}