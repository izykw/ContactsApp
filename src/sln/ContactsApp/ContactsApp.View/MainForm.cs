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
        private List<Contact> _currentContacts;

        /// <summary>
        /// 
        /// </summary>
        string findText = "";

        public MainForm()
        {
            InitializeComponent();
            Project = new Project();
            Project = ProjectManager.LoadFromFile();
            _currentContacts = new List<Contact>(Project.SortBySurname());
            UpdateListBox();
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactListBox.Items.Clear();
            _currentContacts = 
                _currentContacts.OrderBy(contact => contact.Surname).ToList();
            foreach (Contact contact in _currentContacts)
            {
                ContactListBox.Items.Add(contact.Surname);
            }
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
                _currentContacts.Add(newContact);
                Project.Contacts.Add(newContact);
                ProjectManager.SaveToFile(Project);
            }

            ClearSelectedContact();
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

            Contact selectedContact = _currentContacts[index];
            contactForm.Contact = selectedContact;

            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contact updateContact = contactForm.Contact;

                ContactListBox.Items.RemoveAt(index);

                int contactIndex = Project.Contacts.FindIndex(contact => 
                (contact.Surname == _currentContacts[index].Surname 
                && contact.PhoneNumber.Number == _currentContacts[index].PhoneNumber.Number));

                _currentContacts.RemoveAt(index);
                _currentContacts.Insert(index, updateContact);

                Project.Contacts.RemoveAt(contactIndex);
                Project.Contacts.Insert(contactIndex, updateContact);

                ContactListBox.Items.Insert(index, updateContact.Surname);
                ProjectManager.SaveToFile(Project);
            }
            _currentContacts = Project.SearchBySurname(findText);
            ClearSelectedContact();
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
                MessageBox.Show("Item not selected");
                return;
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {_currentContacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == _currentContacts[index].Surname 
                && contact.PhoneNumber.Number == _currentContacts[index].PhoneNumber.Number));

                _currentContacts.RemoveAt(index);
                Project.Contacts.RemoveAt(contactIndex);
                ProjectManager.SaveToFile(Project);
            }
            ClearSelectedContact();
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

            Contact contact = _currentContacts[index];

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
                ProjectManager.SaveToFile(Project);
            }
        }

        private void FindContactTextBox_TextChanged(object sender, EventArgs e)
        {
            findText = FindContactTextBox.Text;
            _currentContacts = Project.SearchBySurname(findText);
            UpdateListBox();
            ClearSelectedContact();
        }
    }
}
