using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    //УЗНАТЬ МОЖНО ЛИ ДЕЛАТЬ КОНСТРУКТОР БЕЗ ПАРАМЕТРОВ. НО ТОГДА ПРИДЕТСЯ СОЗДАТЬ КОНСТРУКТОР ПО УМОЛЧАНИЮ И ДЛЯ НОМЕРА ТЕЛЕФОНА
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Экземпляр контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Геттер и Сеттер для контакта.
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = (Contact)value.Clone();
                if (value != null)
                {
                    ContactSurname.Text = _contact.Surname;
                    ContactName.Text = _contact.Name;
                    ContactDateOfBirth.Value = _contact.DateOfBirth;
                    ContactPhone.Text = _contact.PhoneNumber.Number.ToString();
                    ContactEmail.Text = _contact.Email;
                    ContactVkId.Text = _contact.VkId;
                }
            }
        }

        /// <summary>
        /// Сообщение об ошибке в поле _surname.
        /// </summary>
        private string _surnameError;

        /// <summary>
        /// Сообщение об ошибке в поле _name.
        /// </summary>
        private string _nameError;

        /// <summary>
        /// Сообщение об ошибке в поле _email.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Сообщение об ошибке в поле _vkId.
        /// </summary>
        private string _vkIdError;

        /// <summary>
        /// Сообщение об ошибке в поле _dateOfBirth.
        /// </summary>
        private string _dateOfBirthError;

        /// <summary>
        /// Сообщение об ошибке в поле _number.
        /// </summary>
        private string _phoneNumberError;

        private Color _errorColor = Color.LightPink;

        private Color _defaultColor = Color.White;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact("Postavte", "Avtomat", new PhoneNumber(79991234567), DateTime.Now, "spasibo@mail.ru", "helloWorld");
            UpdateForm();
        }

        /// <summary>
        /// Обновляет поля формы.
        /// </summary>
        private void UpdateForm()
        {
            ContactSurname.Text = _contact.Surname;
            ContactName.Text = _contact.Name;
            ContactDateOfBirth.Value = _contact.DateOfBirth;
            ContactPhone.Text = _contact.PhoneNumber.Number.ToString();
            ContactEmail.Text = _contact.Email;
            ContactVkId.Text = _contact.VkId;
        }

        /// <summary>
        /// Проверяет есть ли ошибки валидации в полях.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            string textError = "";
            if(_surnameError != "")
            {
                textError += "Enter surname\n";
            }
            if (_nameError != "")
            {
                textError += "Enter name\n";
            }
            if (_dateOfBirthError != "")
            {
                textError += "Enter date of birth\n";
            }
            if (_phoneNumberError != "")
            {
                textError += "Enter phone number\n";
            }
            if (_emailError != "")
            {
                textError += "Enter email\n";
            }
            if (_vkIdError != "")
            {
                textError += "Enter vk id\n";
            }
            if(textError != "")
            {
                MessageBox.Show(textError);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Добавляет данные контакта.
        /// </summary>
        private void CompleteButton_Click(object sender, EventArgs e)
        {
           if(CheckFormOnErrors())
           {
                DialogResult = DialogResult.OK;
                this.Close();
           }
        }

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Отслеживает изменения в ContactSurname.
        /// </summary>
        private void ContactSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = ContactSurname.Text;
                ContactSurname.BackColor = _defaultColor;
                _surnameError = "";
            }
            catch (Exception exception)
            {
                ContactSurname.BackColor = _errorColor;
                _surnameError = exception.Message;
            }
        }

        /// <summary>
        /// Отслеживает изменения в ContactName.
        /// </summary>
        private void ContactName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = ContactName.Text;
                ContactName.BackColor = _defaultColor;
                _nameError = "";
            }
            catch (Exception exception)
            {
                ContactName.BackColor = _errorColor;
                _nameError = exception.Message;
            }
        }

        /// <summary>
        /// Отслеживает изменения в ContactPhone.
        /// </summary>
        private void ContactPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber.Number = Int64.Parse(ContactPhone.Text);
                ContactPhone.BackColor = Color.White;
                _phoneNumberError = "";
            }
            catch (Exception exception)
            {
                ContactPhone.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Отслеживает изменения в ContactEmail.
        /// </summary>
        private void ContactEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = ContactEmail.Text;
                ContactEmail.BackColor = _defaultColor;
                _emailError = "";
            }
            catch (Exception exception)
            {
                ContactEmail.BackColor = _errorColor;
                _emailError = exception.Message;
            }
        }

        /// <summary>
        /// Отслеживает изменения в ContactVkId.
        /// </summary>
        private void ContactVkId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = ContactVkId.Text;
                ContactVkId.BackColor = _defaultColor;
                _vkIdError = "";
            }
            catch (Exception exception)
            {
                ContactVkId.BackColor = _errorColor;
                _vkIdError = exception.Message;
            }
        }

        /// <summary>
        /// Отслеживает изменения в ContactBirthday.
        /// </summary>
        private void ContactBirthday_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = ContactDateOfBirth.Value;
                ContactDateOfBirth.BackColor = _defaultColor;
                _dateOfBirthError = "";
            }
            catch (Exception exception)
            {
                ContactDateOfBirth.BackColor = _errorColor;
                _dateOfBirthError = exception.Message;
            }
        }
    }
}
