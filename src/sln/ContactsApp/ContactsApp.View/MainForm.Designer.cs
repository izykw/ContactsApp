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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ContactFind = new System.Windows.Forms.TextBox();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.EditPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayContactLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
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
            this.FileButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddContact = new System.Windows.Forms.Button();
            this.RemoveContact = new System.Windows.Forms.Button();
            this.EditContact = new System.Windows.Forms.Button();
            this.BirthdayPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SplitContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplitContainer.Panel1.Controls.Add(this.NavigationPanel);
            this.SplitContainer.Panel1.Controls.Add(this.FindLabel);
            this.SplitContainer.Panel1.Controls.Add(this.ContactFind);
            this.SplitContainer.Panel1.Controls.Add(this.ContactListBox);
            this.SplitContainer.Panel1.Controls.Add(this.EditPanel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SplitContainer.Panel2.Controls.Add(this.BirthdayPanel);
            this.SplitContainer.Panel2.Controls.Add(this.SiteLabel);
            this.SplitContainer.Panel2.Controls.Add(this.MailLabel);
            this.SplitContainer.Panel2.Controls.Add(this.PhoneLabel);
            this.SplitContainer.Panel2.Controls.Add(this.BirthdayName);
            this.SplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.SurnameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.ContactBirthday);
            this.SplitContainer.Panel2.Controls.Add(this.ContactSite);
            this.SplitContainer.Panel2.Controls.Add(this.ContactMail);
            this.SplitContainer.Panel2.Controls.Add(this.ContactPhone);
            this.SplitContainer.Panel2.Controls.Add(this.ContactName);
            this.SplitContainer.Panel2.Controls.Add(this.ContactSurname);
            this.SplitContainer.Size = new System.Drawing.Size(761, 482);
            this.SplitContainer.SplitterDistance = 252;
            this.SplitContainer.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 40);
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
            this.ContactFind.Location = new System.Drawing.Point(45, 38);
            this.ContactFind.Name = "ContactFind";
            this.ContactFind.Size = new System.Drawing.Size(204, 20);
            this.ContactFind.TabIndex = 2;
            // 
            // ContactListBox
            // 
            this.ContactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.IntegralHeight = false;
            this.ContactListBox.Location = new System.Drawing.Point(12, 67);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(237, 359);
            this.ContactListBox.TabIndex = 1;
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditPanel.ColumnCount = 3;
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.EditPanel.Controls.Add(this.AddContact, 0, 0);
            this.EditPanel.Controls.Add(this.RemoveContact, 2, 0);
            this.EditPanel.Controls.Add(this.EditContact, 1, 0);
            this.EditPanel.Location = new System.Drawing.Point(12, 432);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.RowCount = 1;
            this.EditPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditPanel.Size = new System.Drawing.Size(102, 39);
            this.EditPanel.TabIndex = 0;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BirthdayPanel.Controls.Add(this.BirthdayPictureBox);
            this.BirthdayPanel.Controls.Add(this.BirthdayContactLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayLabel);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 390);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(502, 92);
            this.BirthdayPanel.TabIndex = 12;
            // 
            // BirthdayContactLabel
            // 
            this.BirthdayContactLabel.AutoSize = true;
            this.BirthdayContactLabel.Location = new System.Drawing.Point(83, 53);
            this.BirthdayContactLabel.Name = "BirthdayContactLabel";
            this.BirthdayContactLabel.Size = new System.Drawing.Size(83, 13);
            this.BirthdayContactLabel.TabIndex = 1;
            this.BirthdayContactLabel.Text = "Name, Surname";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(83, 35);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(132, 13);
            this.BirthdayLabel.TabIndex = 0;
            this.BirthdayLabel.Text = "Сегодня день рождения:";
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Location = new System.Drawing.Point(23, 170);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(45, 13);
            this.SiteLabel.TabIndex = 11;
            this.SiteLabel.Text = "vk.com:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(30, 144);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(38, 13);
            this.MailLabel.TabIndex = 10;
            this.MailLabel.Text = "E-mail:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(27, 118);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone:";
            // 
            // BirthdayName
            // 
            this.BirthdayName.AutoSize = true;
            this.BirthdayName.Location = new System.Drawing.Point(20, 93);
            this.BirthdayName.Name = "BirthdayName";
            this.BirthdayName.Size = new System.Drawing.Size(48, 13);
            this.BirthdayName.TabIndex = 8;
            this.BirthdayName.Text = "Birthday:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(30, 68);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(16, 40);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname:";
            // 
            // ContactBirthday
            // 
            this.ContactBirthday.Enabled = false;
            this.ContactBirthday.Location = new System.Drawing.Point(71, 90);
            this.ContactBirthday.Name = "ContactBirthday";
            this.ContactBirthday.Size = new System.Drawing.Size(138, 20);
            this.ContactBirthday.TabIndex = 5;
            // 
            // ContactSite
            // 
            this.ContactSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSite.Enabled = false;
            this.ContactSite.Location = new System.Drawing.Point(70, 168);
            this.ContactSite.Name = "ContactSite";
            this.ContactSite.Size = new System.Drawing.Size(423, 20);
            this.ContactSite.TabIndex = 4;
            // 
            // ContactMail
            // 
            this.ContactMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactMail.Enabled = false;
            this.ContactMail.Location = new System.Drawing.Point(71, 142);
            this.ContactMail.Name = "ContactMail";
            this.ContactMail.Size = new System.Drawing.Size(422, 20);
            this.ContactMail.TabIndex = 3;
            // 
            // ContactPhone
            // 
            this.ContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactPhone.Enabled = false;
            this.ContactPhone.Location = new System.Drawing.Point(71, 116);
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.Size = new System.Drawing.Size(422, 20);
            this.ContactPhone.TabIndex = 2;
            // 
            // ContactName
            // 
            this.ContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactName.Enabled = false;
            this.ContactName.Location = new System.Drawing.Point(71, 64);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(422, 20);
            this.ContactName.TabIndex = 1;
            // 
            // ContactSurname
            // 
            this.ContactSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSurname.Enabled = false;
            this.ContactSurname.Location = new System.Drawing.Point(71, 38);
            this.ContactSurname.Name = "ContactSurname";
            this.ContactSurname.Size = new System.Drawing.Size(422, 20);
            this.ContactSurname.TabIndex = 0;
            // 
            // FileButton
            // 
            this.FileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileButton.FlatAppearance.BorderSize = 0;
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Location = new System.Drawing.Point(3, 3);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(38, 23);
            this.FileButton.TabIndex = 4;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(47, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(38, 23);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Location = new System.Drawing.Point(91, 3);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(41, 23);
            this.HelpButton.TabIndex = 14;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.ColumnCount = 3;
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.NavigationPanel.Controls.Add(this.FileButton, 0, 0);
            this.NavigationPanel.Controls.Add(this.HelpButton, 2, 0);
            this.NavigationPanel.Controls.Add(this.EditButton, 1, 0);
            this.NavigationPanel.Location = new System.Drawing.Point(12, 3);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.RowCount = 1;
            this.NavigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationPanel.Size = new System.Drawing.Size(135, 29);
            this.NavigationPanel.TabIndex = 15;
            // 
            // AddContact
            // 
            this.AddContact.BackgroundImage = global::ContactsApp.View.Properties.Resources.AddContact;
            this.AddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContact.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.RemoveContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveContact.FlatAppearance.BorderSize = 0;
            this.RemoveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContact.Location = new System.Drawing.Point(69, 3);
            this.RemoveContact.Name = "RemoveContact";
            this.RemoveContact.Size = new System.Drawing.Size(30, 32);
            this.RemoveContact.TabIndex = 2;
            this.RemoveContact.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.EditContact.BackgroundImage = global::ContactsApp.View.Properties.Resources.EditContact;
            this.EditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContact.FlatAppearance.BorderSize = 0;
            this.EditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContact.Location = new System.Drawing.Point(36, 3);
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
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.SplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 330);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button EditContact;
        private System.Windows.Forms.Button RemoveContact;
        private System.Windows.Forms.SplitContainer SplitContainer;
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
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.TableLayoutPanel NavigationPanel;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button EditButton;
    }
}

