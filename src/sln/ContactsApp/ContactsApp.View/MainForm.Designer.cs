namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ContactFind = new System.Windows.Forms.TextBox();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.EditPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BirthdayName = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.ContactBirthday = new System.Windows.Forms.DateTimePicker();
            this.ContactSite = new System.Windows.Forms.TextBox();
            this.ContactMail = new System.Windows.Forms.TextBox();
            this.ContactPhone = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.ContactSurname = new System.Windows.Forms.TextBox();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.LabelBirthday = new System.Windows.Forms.Label();
            this.BirthdayContactLabel = new System.Windows.Forms.Label();
            this.AddContact = new System.Windows.Forms.Button();
            this.RemoveContact = new System.Windows.Forms.Button();
            this.EditContact = new System.Windows.Forms.Button();
            this.BirthdayPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.FindLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ContactFind);
            this.splitContainer1.Panel1.Controls.Add(this.ContactListBox);
            this.splitContainer1.Panel1.Controls.Add(this.EditPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayPanel);
            this.splitContainer1.Panel2.Controls.Add(this.SiteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneLabel);
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayName);
            this.splitContainer1.Panel2.Controls.Add(this.NameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SurnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ContactBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.ContactSite);
            this.splitContainer1.Panel2.Controls.Add(this.ContactMail);
            this.splitContainer1.Panel2.Controls.Add(this.ContactPhone);
            this.splitContainer1.Panel2.Controls.Add(this.ContactName);
            this.splitContainer1.Panel2.Controls.Add(this.ContactSurname);
            this.splitContainer1.Size = new System.Drawing.Size(876, 566);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 15);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 3;
            this.FindLabel.Text = "Find:";
            // 
            // ContactFind
            // 
            this.ContactFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactFind.Location = new System.Drawing.Point(45, 12);
            this.ContactFind.Name = "ContactFind";
            this.ContactFind.Size = new System.Drawing.Size(243, 20);
            this.ContactFind.TabIndex = 2;
            // 
            // ContactListBox
            // 
            this.ContactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.Location = new System.Drawing.Point(12, 38);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(276, 472);
            this.ContactListBox.TabIndex = 1;
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditPanel.ColumnCount = 3;
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.EditPanel.Controls.Add(this.AddContact, 0, 0);
            this.EditPanel.Controls.Add(this.RemoveContact, 2, 0);
            this.EditPanel.Controls.Add(this.EditContact, 1, 0);
            this.EditPanel.Location = new System.Drawing.Point(12, 516);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.RowCount = 1;
            this.EditPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditPanel.Size = new System.Drawing.Size(102, 39);
            this.EditPanel.TabIndex = 0;
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Location = new System.Drawing.Point(20, 145);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(45, 13);
            this.SiteLabel.TabIndex = 11;
            this.SiteLabel.Text = "vk.com:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(27, 119);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(38, 13);
            this.MailLabel.TabIndex = 10;
            this.MailLabel.Text = "E-mail:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(24, 93);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone:";
            // 
            // BirthdayName
            // 
            this.BirthdayName.AutoSize = true;
            this.BirthdayName.Location = new System.Drawing.Point(20, 67);
            this.BirthdayName.Name = "BirthdayName";
            this.BirthdayName.Size = new System.Drawing.Size(48, 13);
            this.BirthdayName.TabIndex = 8;
            this.BirthdayName.Text = "Birthday:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(13, 15);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname:";
            // 
            // ContactBirthday
            // 
            this.ContactBirthday.Location = new System.Drawing.Point(71, 64);
            this.ContactBirthday.Name = "ContactBirthday";
            this.ContactBirthday.Size = new System.Drawing.Size(138, 20);
            this.ContactBirthday.TabIndex = 5;
            // 
            // ContactSite
            // 
            this.ContactSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSite.Location = new System.Drawing.Point(70, 142);
            this.ContactSite.Name = "ContactSite";
            this.ContactSite.Size = new System.Drawing.Size(499, 20);
            this.ContactSite.TabIndex = 4;
            // 
            // ContactMail
            // 
            this.ContactMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactMail.Location = new System.Drawing.Point(71, 116);
            this.ContactMail.Name = "ContactMail";
            this.ContactMail.Size = new System.Drawing.Size(498, 20);
            this.ContactMail.TabIndex = 3;
            // 
            // ContactPhone
            // 
            this.ContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactPhone.Location = new System.Drawing.Point(71, 90);
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.Size = new System.Drawing.Size(498, 20);
            this.ContactPhone.TabIndex = 2;
            // 
            // ContactName
            // 
            this.ContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactName.Location = new System.Drawing.Point(71, 38);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(498, 20);
            this.ContactName.TabIndex = 1;
            // 
            // ContactSurname
            // 
            this.ContactSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSurname.Location = new System.Drawing.Point(71, 12);
            this.ContactSurname.Name = "ContactSurname";
            this.ContactSurname.Size = new System.Drawing.Size(498, 20);
            this.ContactSurname.TabIndex = 0;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BirthdayPanel.Controls.Add(this.BirthdayPictureBox);
            this.BirthdayPanel.Controls.Add(this.BirthdayContactLabel);
            this.BirthdayPanel.Controls.Add(this.LabelBirthday);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 474);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(578, 92);
            this.BirthdayPanel.TabIndex = 12;
            // 
            // LabelBirthday
            // 
            this.LabelBirthday.AutoSize = true;
            this.LabelBirthday.Location = new System.Drawing.Point(83, 33);
            this.LabelBirthday.Name = "LabelBirthday";
            this.LabelBirthday.Size = new System.Drawing.Size(132, 13);
            this.LabelBirthday.TabIndex = 0;
            this.LabelBirthday.Text = "Сегодня день рождения:";
            // 
            // BirthdayContactLabel
            // 
            this.BirthdayContactLabel.AutoSize = true;
            this.BirthdayContactLabel.Location = new System.Drawing.Point(83, 55);
            this.BirthdayContactLabel.Name = "BirthdayContactLabel";
            this.BirthdayContactLabel.Size = new System.Drawing.Size(83, 13);
            this.BirthdayContactLabel.TabIndex = 1;
            this.BirthdayContactLabel.Text = "Name, Surname";
            // 
            // AddContact
            // 
            this.AddContact.BackgroundImage = global::ContactsApp.View.Properties.Resources.AddContact;
            this.AddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContact.FlatAppearance.BorderSize = 0;
            this.AddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContact.Location = new System.Drawing.Point(3, 3);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(26, 32);
            this.AddContact.TabIndex = 0;
            this.AddContact.UseVisualStyleBackColor = true;
            // 
            // RemoveContact
            // 
            this.RemoveContact.BackgroundImage = global::ContactsApp.View.Properties.Resources.RemoveContact;
            this.RemoveContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveContact.FlatAppearance.BorderSize = 0;
            this.RemoveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContact.Location = new System.Drawing.Point(67, 3);
            this.RemoveContact.Name = "RemoveContact";
            this.RemoveContact.Size = new System.Drawing.Size(32, 32);
            this.RemoveContact.TabIndex = 2;
            this.RemoveContact.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.EditContact.BackgroundImage = global::ContactsApp.View.Properties.Resources.EditContact;
            this.EditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditContact.FlatAppearance.BorderSize = 0;
            this.EditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContact.Location = new System.Drawing.Point(35, 3);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(26, 32);
            this.EditContact.TabIndex = 1;
            this.EditContact.UseVisualStyleBackColor = true;
            // 
            // BirthdayPictureBox
            // 
            this.BirthdayPictureBox.BackgroundImage = global::ContactsApp.View.Properties.Resources.ExclamationMark;
            this.BirthdayPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BirthdayPictureBox.Location = new System.Drawing.Point(13, 19);
            this.BirthdayPictureBox.Name = "BirthdayPictureBox";
            this.BirthdayPictureBox.Size = new System.Drawing.Size(64, 64);
            this.BirthdayPictureBox.TabIndex = 13;
            this.BirthdayPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(876, 566);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button EditContact;
        private System.Windows.Forms.Button RemoveContact;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel EditPanel;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.TextBox ContactFind;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthdayName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.DateTimePicker ContactBirthday;
        private System.Windows.Forms.TextBox ContactSite;
        private System.Windows.Forms.TextBox ContactMail;
        private System.Windows.Forms.TextBox ContactPhone;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.TextBox ContactSurname;
        private System.Windows.Forms.PictureBox BirthdayPictureBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirthdayContactLabel;
        private System.Windows.Forms.Label LabelBirthday;
    }
}

