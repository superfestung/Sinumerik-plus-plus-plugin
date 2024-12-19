namespace NppDemo.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Title = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.Description = new System.Windows.Forms.Label();
            this.DebugInfoLabel = new System.Windows.Forms.Label();
            this.ThanksWowLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(281, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sinumerik++ Plugin vX.Y.Z.A";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.LinkArea = new System.Windows.Forms.LinkArea(26, 58);
            this.GitHubLink.Location = new System.Drawing.Point(13, 178);
            this.GitHubLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(299, 42);
            this.GitHubLink.TabIndex = 1;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "Sinumerik++ on Github:\r\n\r\nhttps://github.com/superfestung/Sinumerik-plus-plus-plu" +
    "gin";
            this.GitHubLink.UseCompatibleTextRendering = true;
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(21, 43);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(233, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "The best Notepad++ addon for Sinumerik users ";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // DebugInfoLabel
            // 
            this.DebugInfoLabel.AutoSize = true;
            this.DebugInfoLabel.Location = new System.Drawing.Point(11, 129);
            this.DebugInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DebugInfoLabel.Name = "DebugInfoLabel";
            this.DebugInfoLabel.Size = new System.Drawing.Size(136, 13);
            this.DebugInfoLabel.TabIndex = 4;
            this.DebugInfoLabel.Text = "Notepad++ version: X.Y.Z. ";
            this.DebugInfoLabel.Click += new System.EventHandler(this.DebugInfoLabel_Click);
            // 
            // ThanksWowLinkLabel
            // 
            this.ThanksWowLinkLabel.AutoSize = true;
            this.ThanksWowLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(228, 234);
            this.ThanksWowLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ThanksWowLinkLabel.Location = new System.Drawing.Point(13, 152);
            this.ThanksWowLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThanksWowLinkLabel.Name = "ThanksWowLinkLabel";
            this.ThanksWowLinkLabel.Size = new System.Drawing.Size(228, 17);
            this.ThanksWowLinkLabel.TabIndex = 5;
            this.ThanksWowLinkLabel.Text = "Special thanks to the Notepad++ Community";
            this.ThanksWowLinkLabel.UseCompatibleTextRendering = true;
            this.ThanksWowLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ThanksWowLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 238);
            this.Controls.Add(this.ThanksWowLinkLabel);
            this.Controls.Add(this.DebugInfoLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AboutForm";
            this.Text = "About Sinumerik++ Plugin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label DebugInfoLabel;
        private System.Windows.Forms.LinkLabel ThanksWowLinkLabel;
    }
}