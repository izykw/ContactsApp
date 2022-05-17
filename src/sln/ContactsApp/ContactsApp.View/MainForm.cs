using System;
using System.Windows.Forms;
using ContactsApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса Project.
        /// </summary>
        private Project Project { get; set; }


        /// <summary>
        /// Текущие объекты в списке
        /// </summary>
        private List<Contact> currentContacts;


        public MainForm()
        {
            InitializeComponent();
            Project = new Project();
            AddRandomContact(2);
            AddRandomContact(0);
            AddRandomContact(1);
            currentContacts = new List<Contact>(Project.SortBySurname());
            UpdateListBox();
        }


        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactListBox.Items.Clear();
            currentContacts = currentContacts.OrderBy(contact => contact.Surname).ToList();
            foreach (Contact contact in currentContacts)
            {
                ContactListBox.Items.Add(contact.Surname);
            }
        }


        /// <summary>
        /// Добавляет новый контакт.
        /// </summary>
        private void AddRandomContact(int index)
        {
            string[] names = new string[3] { "Obito", "Neji", "Naruto" };
            string[] surnames = new string[3] { "Raz", "Dva", "Tri" };
            string[] emails = new string[3] { "uchiha@gmail.com", "hyugo@gmail.com", "uzumaki@gmail.com" };
            string[] vkId = new string[3] { "mstun", "vsevizhy", "rasengan" };

            Contact newContact = new Contact(
                names[index],
                surnames[index],
                new PhoneNumber(79991234567),
                DateTime.Now,
                emails[index],
                vkId[index]);
            ContactListBox.Items.Add(newContact.Surname);
            Project.Contacts.Add(newContact);
        }


        /// <summary>
        /// Добавляет контакта в список.
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contact newContact = contactForm.Contact;
                currentContacts.Add(newContact);
                Project.Contacts.Add(newContact);
            }
        }


        /// <summary>
        /// Редактирует контакта в списке.
        /// </summary>
        private void EditContact(int index)
        {
            if (index == -1)
            {
                MessageBox.Show("Choose contact");
                return;
            }

            ContactForm contactForm = new ContactForm();

            Contact selectedContact = currentContacts[index];
            contactForm.Contact = selectedContact;

            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contact updateContact = contactForm.Contact;

                ContactListBox.Items.RemoveAt(index);

                int contactIndex = Project.Contacts.FindIndex(contact => 
                (contact.Surname == currentContacts[index].Surname && contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

                currentContacts.RemoveAt(index);
                currentContacts.Insert(index, updateContact);

                Project.Contacts.RemoveAt(contactIndex);
                Project.Contacts.Insert(contactIndex, updateContact);

                ContactListBox.Items.Insert(index, updateContact.Surname);
            }
        }


        /// <summary>
        /// Удаляет контакт и обновляет ListBox.
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentException"></exception>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                throw new ArgumentException("Item not selected");
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {currentContacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == currentContacts[index].Surname && contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

                currentContacts.RemoveAt(index);
                Project.Contacts.RemoveAt(contactIndex);
            }
        }


        /// <summary>
        /// Вызывает форму с информацией о разработчике.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }


        /// <summary>
        /// Добавляет контакт в ListBox и обновляет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }


        /// <summary>
        /// Вызывает форму редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactListBox.SelectedIndex);
            UpdateListBox();
        }


        /// <summary>
        /// Вызывает форму редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEditContact_Click(object sender, EventArgs e)
        {
            EditContact(ContactListBox.SelectedIndex);
            UpdateListBox();
        }


        /// <summary>
        /// Добавляет контакт и обновлят ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactListBox.SelectedIndex);
            UpdateListBox();
        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemRemoveContact_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactListBox.SelectedIndex);
            UpdateListBox();
        }


        /// <summary>
        /// Очищает информацию о пользователе.
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
        /// Выводит полную информацию о пользователе.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }

            Contact contact = currentContacts[index];

            ContactSurname.Text = contact.Surname;
            ContactName.Text = contact.Name;
            ContactDateOfBirth.Value = contact.DateOfBirth;
            ContactPhoneNumber.Text = contact.PhoneNumber.Number.ToString();
            ContactEmail.Text = contact.Email;
            ContactVkId.Text = contact.VkId;
        }


        /// <summary>
        /// Выхывает функцию UpdateSelectedContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateSelectedContact(ContactListBox.SelectedIndex);


        /// <summary>
        /// Закрывает приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close application?",
                "Message", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FindContactTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = FindContactTextBox.Text;
            currentContacts = Project.SearchBySurname(text);
            UpdateListBox();
        }
    }
}
