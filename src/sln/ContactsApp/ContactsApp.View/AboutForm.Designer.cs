namespace ContactsApp.View
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
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.AppAuthorLabel = new System.Windows.Forms.Label();
            this.AuthorMailLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.AuthorMailLink = new System.Windows.Forms.LinkLabel();
            this.ProjectLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppNameLabel.Location = new System.Drawing.Point(12, 9);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(148, 26);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "ContactsApp";
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Location = new System.Drawing.Point(14, 35);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(43, 13);
            this.AppVersionLabel.TabIndex = 1;
            this.AppVersionLabel.Text = "v. 1.0.0";
            // 
            // AppAuthorLabel
            // 
            this.AppAuthorLabel.AutoSize = true;
            this.AppAuthorLabel.Location = new System.Drawing.Point(14, 76);
            this.AppAuthorLabel.Name = "AppAuthorLabel";
            this.AppAuthorLabel.Size = new System.Drawing.Size(128, 13);
            this.AppAuthorLabel.TabIndex = 3;
            this.AppAuthorLabel.Text = "Author: Maxim Pakhomov";
            // 
            // AuthorMailLabel
            // 
            this.AuthorMailLabel.AutoSize = true;
            this.AuthorMailLabel.Location = new System.Drawing.Point(14, 125);
            this.AuthorMailLabel.Name = "AuthorMailLabel";
            this.AuthorMailLabel.Size = new System.Drawing.Size(101, 13);
            this.AuthorMailLabel.TabIndex = 2;
            this.AuthorMailLabel.Text = "E-mail for feedback:";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(14, 147);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(43, 13);
            this.ProjectLabel.TabIndex = 4;
            this.ProjectLabel.Text = "GitHub:";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(14, 289);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(130, 13);
            this.CopyrightLabel.TabIndex = 5;
            this.CopyrightLabel.Text = "2022 Maxim Pakhomov ©";
            // 
            // AuthorMailLink
            // 
            this.AuthorMailLink.AutoSize = true;
            this.AuthorMailLink.Location = new System.Drawing.Point(121, 125);
            this.AuthorMailLink.Name = "AuthorMailLink";
            this.AuthorMailLink.Size = new System.Drawing.Size(113, 13);
            this.AuthorMailLink.TabIndex = 6;
            this.AuthorMailLink.TabStop = true;
            this.AuthorMailLink.Text = "velikkqwe@gmail.com";
            // 
            // ProjectLink
            // 
            this.ProjectLink.AutoSize = true;
            this.ProjectLink.Location = new System.Drawing.Point(63, 147);
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Size = new System.Drawing.Size(129, 13);
            this.ProjectLink.TabIndex = 7;
            this.ProjectLink.TabStop = true;
            this.ProjectLink.Text = "Amaterasud/ContactsApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.ProjectLink);
            this.Controls.Add(this.AuthorMailLink);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.AppAuthorLabel);
            this.Controls.Add(this.AuthorMailLabel);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.AppNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.Label AppAuthorLabel;
        private System.Windows.Forms.Label AuthorMailLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.LinkLabel AuthorMailLink;
        private System.Windows.Forms.LinkLabel ProjectLink;
    }
}