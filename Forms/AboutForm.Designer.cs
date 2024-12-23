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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Title = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.Description = new System.Windows.Forms.Label();
            this.DebugInfoLabel = new System.Windows.Forms.Label();
            this.Donate = new System.Windows.Forms.Button();
            this.YouTube = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(158, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 200);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(13, 7);
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
            this.GitHubLink.Location = new System.Drawing.Point(10, 218);
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
            this.Description.Location = new System.Drawing.Point(15, 46);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(138, 26);
            this.Description.TabIndex = 3;
            this.Description.Text = "The best Notepad++ addon\r\nfor Sinumerik users ";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // DebugInfoLabel
            // 
            this.DebugInfoLabel.AutoSize = true;
            this.DebugInfoLabel.Location = new System.Drawing.Point(15, 87);
            this.DebugInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DebugInfoLabel.Name = "DebugInfoLabel";
            this.DebugInfoLabel.Size = new System.Drawing.Size(81, 26);
            this.DebugInfoLabel.TabIndex = 4;
            this.DebugInfoLabel.Text = "Notepad++\r\nVersion: X.Y.Z. ";
            this.DebugInfoLabel.Click += new System.EventHandler(this.DebugInfoLabel_Click);
            // 
            // Donate
            // 
            this.Donate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Donate.Location = new System.Drawing.Point(14, 178);
            this.Donate.Name = "Donate";
            this.Donate.Size = new System.Drawing.Size(60, 27);
            this.Donate.TabIndex = 7;
            this.Donate.Text = "Donate";
            this.Donate.UseVisualStyleBackColor = true;
            this.Donate.Click += new System.EventHandler(this.donate_ButtonClick);
            // 
            // YouTube
            // 
            this.YouTube.Location = new System.Drawing.Point(80, 178);
            this.YouTube.Name = "YouTube";
            this.YouTube.Size = new System.Drawing.Size(60, 27);
            this.YouTube.TabIndex = 8;
            this.YouTube.Text = "YouTube";
            this.YouTube.UseVisualStyleBackColor = true;
            this.YouTube.Click += new System.EventHandler(this.youtube_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Learn more and Support";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YouTube);
            this.Controls.Add(this.Donate);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.DebugInfoLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AboutForm";
            this.Text = "About Sinumerik++ Plugin";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label DebugInfoLabel;
        public System.Windows.Forms.Button Donate;
        private System.Windows.Forms.Button YouTube;
        private System.Windows.Forms.Label label1;
    }
}