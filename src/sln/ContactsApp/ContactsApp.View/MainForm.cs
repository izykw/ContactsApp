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

        private void UpdateListBox()
        {
            ContactListBox.Items.Clear();

            foreach (Contact contact in _project.Contacts)
            {
                ContactListBox.Items.Add(contact.Surname);
            }
        }

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

        private void RemoveContact(int index) => _project.Contacts.RemoveAt(index);

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
            int index = ContactListBox.SelectedIndex;

            if (index == -1)
            {
                throw new ArgumentException("Item not selected");
            }
            MessageBox.Show($"Do you really want to remove {_project.Contacts[index].Surname}?");

            RemoveContact(index);
            UpdateListBox();
        }
    }
}
