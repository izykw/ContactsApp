﻿using System;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса Project.
        /// </summary>
        private Project project { get; set; }


        public MainForm()
        {
            InitializeComponent();
            project = new Project();
            AddRandomContact();
            AddRandomContact();
            AddRandomContact();
        }


        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactListBox.Items.Clear();

            foreach (Contact contact in project.Contacts)
            {
                ContactListBox.Items.Add(contact.Surname);
            }
        }
        

        /// <summary>
        /// Добавляет новый контакт.
        /// </summary>
        private void AddRandomContact()
        {
            string[] names = new string[3] { "Obito", "Neji", "Naruto" };
            string[] surnames = new string[3] { "Uchiha", "Hyugo", "Uzumaki" };
            string[] emails = new string[3] { "uchiha@gmail.com", "hyugo@gmail.com", "uzumaki@gmail.com" };
            string[] vkId = new string[3] { "mstun", "vsevizhy", "rasengan" };

            Random random = new Random();
            Contact newContact = new Contact(
                names[random.Next(names.Length)],
                surnames[random.Next(surnames.Length)],
                new PhoneNumber(79991234567),
                DateTime.Now,
                emails[random.Next(emails.Length)],
                vkId[random.Next(vkId.Length)]);
            ContactListBox.Items.Add(newContact.Surname);
            project.Contacts.Add(newContact);
        }


        /// <summary>
        /// Добавляет контакта в список
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            DialogResult result = contactForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                Contact newContact = contactForm.Contact;
                project.Contacts.Add(newContact);
            }
           
        }


        /// <summary>
        /// Редактирует контакта в списке
        /// </summary>
        private void EditContact(int index)
        {
            if (ContactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose contact");
                return;
            }

            ContactForm contactForm = new ContactForm();

            Contact selectedContact = project.Contacts[index];
            contactForm.Contact = selectedContact;

            DialogResult result = contactForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                Contact updateContact = contactForm.Contact;

                ContactListBox.Items.RemoveAt(index);
                project.Contacts.RemoveAt(index);

                project.Contacts.Insert(index, updateContact);
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

            DialogResult result = MessageBox.Show($"Do you really want to remove {project.Contacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                project.Contacts.RemoveAt(index);
                UpdateListBox();
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
        }


        /// <summary>
        /// Вызывает форму редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEditContact_Click(object sender, EventArgs e)
        {
            EditContact(ContactListBox.SelectedIndex);
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
        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemRemoveContact_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactListBox.SelectedIndex);
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

            Contact contact = project.Contacts[index];

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

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
