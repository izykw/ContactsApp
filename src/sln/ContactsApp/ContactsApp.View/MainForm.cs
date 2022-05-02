using System;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Project _project { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
        }

        /// <summary>
        /// Обновляет данные в ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ContactListBox.Items.Clear();

            foreach (Contact contact in _project.Contacts)
            {
                ContactListBox.Items.Add(contact.Surname);
            }
        }
        
        /// <summary>
        /// Добавляет новый контакт
        /// </summary>
        private void AddContact()
        {
            string[] names = new string[3] { "Obtio", "Neji", "Naruto" };
            string[] surnames = new string[3] { "Uchiha", "Hyugo", "Uzumaki" };
            string[] emails = new string[3] { "uchiha@gmail.com", "hyugo@gmail.com", "uzumaki@gmail.com" };
            string[] vkId = new string[3] { "mstun", "vsevizhy", "rasengan" };

            PhoneNumber newPhone = new PhoneNumber(12345);

            Random random = new Random();
            Contact newContact = new Contact(
                names[random.Next(names.Length)],
                surnames[random.Next(surnames.Length)],
                new PhoneNumber(random.Next()),
                DateTime.Now,
                emails[random.Next(emails.Length)],
                vkId[random.Next(vkId.Length)]);

            _project.Contacts.Add(newContact);
        }

        /// <summary>
        /// Удаляет контакт и обновляет ListBox
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentException"></exception>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                throw new ArgumentException("Item not selected");
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {_project.Contacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(index);
                UpdateListBox();
            }
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void MenuItemAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactListBox.SelectedIndex);
        }

        private void MenuItemRemoveContact_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactListBox.SelectedIndex);
        }

        /// <summary>
        /// Очищает информацию о пользователе
        /// </summary>
        private void ClearSelectedContact()
        {
            ContactSurname.Clear();
            ContactName.Clear();
            ContactDateOfBirth.Value = DateTime.Now;
            ContactPhoneNumber.Clear();
            ContactEmail.Clear();
            ContactVkId.Clear();
        }

        /// <summary>
        /// Выводит полную информацию о пользователе
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }

            Contact contact = _project.Contacts[index];

            ContactSurname.Text = contact.Surname;
            ContactName.Text = contact.Name;
            ContactDateOfBirth.Value = contact.DateOfBirth;
            ContactPhoneNumber.Text = contact.PhoneNumber.Number.ToString();
            ContactEmail.Text = contact.Email;
            ContactVkId.Text = contact.VkId;
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e) => 
            UpdateSelectedContact(ContactListBox.SelectedIndex);


        /// <summary>
        /// Закрывает приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close application?", 
                "Message", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
