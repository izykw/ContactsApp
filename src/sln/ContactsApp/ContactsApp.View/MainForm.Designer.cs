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
            this.FindContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.EditPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.ContactDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.ContactVkId = new System.Windows.Forms.TextBox();
            this.ContactEmail = new System.Windows.Forms.TextBox();
            this.ContactPhoneNumber = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.ContactSurname = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRemoveContact = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Birthday = new System.Windows.Forms.Label();
            this.ContactBirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayPictureBox = new System.Windows.Forms.PictureBox();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).BeginInit();
            this.BirthdayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(0, 27);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SplitContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplitContainer.Panel1.Controls.Add(this.FindLabel);
            this.SplitContainer.Panel1.Controls.Add(this.FindContactTextBox);
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
            this.SplitContainer.Panel2.Controls.Add(this.DateOfBirthLabel);
            this.SplitContainer.Panel2.Controls.Add(this.NameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.SurnameLabel);
            this.SplitContainer.Panel2.Controls.Add(this.ContactDateOfBirth);
            this.SplitContainer.Panel2.Controls.Add(this.ContactVkId);
            this.SplitContainer.Panel2.Controls.Add(this.ContactEmail);
            this.SplitContainer.Panel2.Controls.Add(this.ContactPhoneNumber);
            this.SplitContainer.Panel2.Controls.Add(this.ContactName);
            this.SplitContainer.Panel2.Controls.Add(this.ContactSurname);
            this.SplitContainer.Size = new System.Drawing.Size(761, 455);
            this.SplitContainer.SplitterDistance = 252;
            this.SplitContainer.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 5);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 3;
            this.FindLabel.Text = "Find:";
            // 
            // FindContactTextBox
            // 
            this.FindContactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindContactTextBox.Location = new System.Drawing.Point(45, 3);
            this.FindContactTextBox.Name = "FindContactTextBox";
            this.FindContactTextBox.Size = new System.Drawing.Size(204, 20);
            this.FindContactTextBox.TabIndex = 2;
            this.FindContactTextBox.TextChanged += new System.EventHandler(this.FindContactTextBox_TextChanged);
            // 
            // ContactListBox
            // 
            this.ContactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.IntegralHeight = false;
            this.ContactListBox.Location = new System.Drawing.Point(12, 29);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(237, 370);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditPanel.ColumnCount = 3;
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.EditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.EditPanel.Controls.Add(this.RemoveContactButton, 2, 0);
            this.EditPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.EditPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.EditPanel.Location = new System.Drawing.Point(12, 405);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.RowCount = 1;
            this.EditPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditPanel.Size = new System.Drawing.Size(114, 39);
            this.EditPanel.TabIndex = 0;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.RemoveContact;
            this.RemoveContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Location = new System.Drawing.Point(79, 3);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.AddContact;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Location = new System.Drawing.Point(3, 3);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(32, 32);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.EditContact;
            this.EditContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Location = new System.Drawing.Point(41, 3);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(32, 32);
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Location = new System.Drawing.Point(35, 138);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(45, 13);
            this.SiteLabel.TabIndex = 11;
            this.SiteLabel.Text = "vk.com:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(42, 112);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(38, 13);
            this.MailLabel.TabIndex = 10;
            this.MailLabel.Text = "E-mail:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(39, 86);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(12, 61);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of birth:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(28, 5);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname:";
            // 
            // ContactDateOfBirth
            // 
            this.ContactDateOfBirth.Enabled = false;
            this.ContactDateOfBirth.Location = new System.Drawing.Point(86, 58);
            this.ContactDateOfBirth.Name = "ContactDateOfBirth";
            this.ContactDateOfBirth.Size = new System.Drawing.Size(138, 20);
            this.ContactDateOfBirth.TabIndex = 5;
            // 
            // ContactVkId
            // 
            this.ContactVkId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactVkId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactVkId.Enabled = false;
            this.ContactVkId.Location = new System.Drawing.Point(86, 136);
            this.ContactVkId.Name = "ContactVkId";
            this.ContactVkId.Size = new System.Drawing.Size(404, 20);
            this.ContactVkId.TabIndex = 4;
            // 
            // ContactEmail
            // 
            this.ContactEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactEmail.Enabled = false;
            this.ContactEmail.Location = new System.Drawing.Point(86, 110);
            this.ContactEmail.Name = "ContactEmail";
            this.ContactEmail.Size = new System.Drawing.Size(404, 20);
            this.ContactEmail.TabIndex = 3;
            // 
            // ContactPhoneNumber
            // 
            this.ContactPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactPhoneNumber.Enabled = false;
            this.ContactPhoneNumber.Location = new System.Drawing.Point(86, 84);
            this.ContactPhoneNumber.Name = "ContactPhoneNumber";
            this.ContactPhoneNumber.Size = new System.Drawing.Size(404, 20);
            this.ContactPhoneNumber.TabIndex = 2;
            // 
            // ContactName
            // 
            this.ContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactName.Enabled = false;
            this.ContactName.Location = new System.Drawing.Point(86, 29);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(404, 20);
            this.ContactName.TabIndex = 1;
            // 
            // ContactSurname
            // 
            this.ContactSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactSurname.Enabled = false;
            this.ContactSurname.Location = new System.Drawing.Point(86, 3);
            this.ContactSurname.Name = "ContactSurname";
            this.ContactSurname.Size = new System.Drawing.Size(404, 20);
            this.ContactSurname.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(761, 24);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menu";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddContact,
            this.MenuItemEditContact,
            this.MenuItemRemoveContact});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.MenuItemEdit.Text = "Edit";
            // 
            // MenuItemAddContact
            // 
            this.MenuItemAddContact.Name = "MenuItemAddContact";
            this.MenuItemAddContact.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAddContact.Text = "Add contact";
            this.MenuItemAddContact.Click += new System.EventHandler(this.MenuItemAddContact_Click);
            // 
            // MenuItemEditContact
            // 
            this.MenuItemEditContact.Name = "MenuItemEditContact";
            this.MenuItemEditContact.Size = new System.Drawing.Size(180, 22);
            this.MenuItemEditContact.Text = "Edit contact";
            this.MenuItemEditContact.Click += new System.EventHandler(this.MenuItemEditContact_Click);
            // 
            // MenuItemRemoveContact
            // 
            this.MenuItemRemoveContact.Name = "MenuItemRemoveContact";
            this.MenuItemRemoveContact.Size = new System.Drawing.Size(180, 22);
            this.MenuItemRemoveContact.Text = "Remove contact";
            this.MenuItemRemoveContact.Click += new System.EventHandler(this.MenuItemRemoveContact_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(83, 35);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(132, 13);
            this.Birthday.TabIndex = 0;
            this.Birthday.Text = "Сегодня день рождения:";
            // 
            // ContactBirthdayLabel
            // 
            this.ContactBirthdayLabel.AutoSize = true;
            this.ContactBirthdayLabel.Location = new System.Drawing.Point(83, 53);
            this.ContactBirthdayLabel.Name = "ContactBirthdayLabel";
            this.ContactBirthdayLabel.Size = new System.Drawing.Size(83, 13);
            this.ContactBirthdayLabel.TabIndex = 1;
            this.ContactBirthdayLabel.Text = "Name, Surname";
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
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BirthdayPanel.Controls.Add(this.BirthdayPictureBox);
            this.BirthdayPanel.Controls.Add(this.ContactBirthdayLabel);
            this.BirthdayPanel.Controls.Add(this.Birthday);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 363);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(502, 92);
            this.BirthdayPanel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.SplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(470, 330);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPictureBox)).EndInit();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TableLayoutPanel EditPanel;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.TextBox FindContactTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.DateTimePicker ContactDateOfBirth;
        private System.Windows.Forms.TextBox ContactVkId;
        private System.Windows.Forms.TextBox ContactEmail;
        private System.Windows.Forms.TextBox ContactPhoneNumber;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.TextBox ContactSurname;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddContact;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemoveContact;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditContact;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.PictureBox BirthdayPictureBox;
        private System.Windows.Forms.Label ContactBirthdayLabel;
        private System.Windows.Forms.Label Birthday;
    }
}

