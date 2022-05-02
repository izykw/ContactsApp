namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.CompleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.ContactSite = new System.Windows.Forms.TextBox();
            this.ContactSurname = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.ContactPhone = new System.Windows.Forms.TextBox();
            this.ContactMail = new System.Windows.Forms.TextBox();
            this.ContactBirthday = new System.Windows.Forms.DateTimePicker();
            this.Container = new System.Windows.Forms.Panel();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.Location = new System.Drawing.Point(187, 185);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteButton.TabIndex = 24;
            this.CompleteButton.Text = "OK";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(268, 185);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 14);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 26;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(16, 67);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(48, 13);
            this.BirthdayLabel.TabIndex = 28;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(23, 92);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 29;
            this.PhoneLabel.Text = "Phone:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(26, 118);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(38, 13);
            this.MailLabel.TabIndex = 30;
            this.MailLabel.Text = "E-mail:";
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Location = new System.Drawing.Point(19, 144);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(45, 13);
            this.SiteLabel.TabIndex = 31;
            this.SiteLabel.Text = "vk.com:";
            // 
            // ContactSite
            // 
            this.ContactSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSite.Location = new System.Drawing.Point(70, 142);
            this.ContactSite.Name = "ContactSite";
            this.ContactSite.Size = new System.Drawing.Size(273, 20);
            this.ContactSite.TabIndex = 32;
            // 
            // ContactSurname
            // 
            this.ContactSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSurname.Location = new System.Drawing.Point(70, 12);
            this.ContactSurname.Name = "ContactSurname";
            this.ContactSurname.Size = new System.Drawing.Size(273, 20);
            this.ContactSurname.TabIndex = 33;
            // 
            // ContactName
            // 
            this.ContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactName.Location = new System.Drawing.Point(70, 38);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(273, 20);
            this.ContactName.TabIndex = 34;
            // 
            // ContactPhone
            // 
            this.ContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactPhone.Location = new System.Drawing.Point(70, 90);
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.Size = new System.Drawing.Size(273, 20);
            this.ContactPhone.TabIndex = 35;
            // 
            // ContactMail
            // 
            this.ContactMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactMail.Location = new System.Drawing.Point(70, 116);
            this.ContactMail.Name = "ContactMail";
            this.ContactMail.Size = new System.Drawing.Size(273, 20);
            this.ContactMail.TabIndex = 36;
            // 
            // ContactBirthday
            // 
            this.ContactBirthday.Location = new System.Drawing.Point(70, 64);
            this.ContactBirthday.Name = "ContactBirthday";
            this.ContactBirthday.Size = new System.Drawing.Size(138, 20);
            this.ContactBirthday.TabIndex = 37;
            // 
            // Container
            // 
            this.Container.Controls.Add(this.ContactBirthday);
            this.Container.Controls.Add(this.ContactMail);
            this.Container.Controls.Add(this.ContactPhone);
            this.Container.Controls.Add(this.ContactName);
            this.Container.Controls.Add(this.ContactSurname);
            this.Container.Controls.Add(this.ContactSite);
            this.Container.Controls.Add(this.SiteLabel);
            this.Container.Controls.Add(this.MailLabel);
            this.Container.Controls.Add(this.PhoneLabel);
            this.Container.Controls.Add(this.BirthdayLabel);
            this.Container.Controls.Add(this.NameLabel);
            this.Container.Controls.Add(this.SurnameLabel);
            this.Container.Controls.Add(this.CancelButton);
            this.Container.Controls.Add(this.CompleteButton);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(355, 211);
            this.Container.TabIndex = 0;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 211);
            this.Controls.Add(this.Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.TextBox ContactSite;
        private System.Windows.Forms.TextBox ContactSurname;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.TextBox ContactPhone;
        private System.Windows.Forms.TextBox ContactMail;
        private System.Windows.Forms.DateTimePicker ContactBirthday;
        private System.Windows.Forms.Panel Container;
    }
}