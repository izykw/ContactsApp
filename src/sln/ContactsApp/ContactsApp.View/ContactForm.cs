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
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Экземпляр контакта
        /// </summary>
        private Contact _contact;


        /// <summary>
        /// Сообщение об ошибке в поле _surname
        /// </summary>
        private string _surnameError;


        /// <summary>
        /// Сообщение об ошибке в поле _name
        /// </summary>
        private string _nameError;


        /// <summary>
        /// Сообщение об ошибке в поле _email
        /// </summary>
        private string _emailError;


        /// <summary>
        /// Сообщение об ошибке в поле _vkId
        /// </summary>
        private string _vkIdError;


        /// <summary>
        /// Сообщение об ошибке в поле _vkId
        /// </summary>
        private string _dateOfBirthError;


        /// <summary>
        /// Сообщение об ошибке в поле _number
        /// </summary>
        private string _phoneNumberError;


        /// <summary>
        /// Конструктор
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact("Postavte", "Avtomat", new PhoneNumber(79991234567), DateTime.Now, "spasibo@mail.ru", "helloWorld");
            UpdateForm();
        }


        /// <summary>
        /// Заполняет поля формы данными
        /// </summary>
        private void UpdateForm()
        {
            ContactSurname.Text = _contact.Surname;
            ContactName.Text = _contact.Name;
            ContactEmail.Text = _contact.Email;
            ContactDateOfBirth.Value = _contact.DateOfBirth;
            ContactPhone.Text = _contact.PhoneNumber.Number.ToString();
            ContactVkId.Text = _contact.VkId;
        }


        /// <summary>
        /// Проверяет есть ли ошибки валидации в полях
        /// </summary>
        private void CheckFormOnErrors()
        {
            if(_surnameError != "")
            {
                MessageBox.Show(_surnameError);
            }
            if (_nameError != "")
            {
                MessageBox.Show(_nameError);
            }
            if (_dateOfBirthError != "")
            {
                MessageBox.Show(_dateOfBirthError);
            }
            if (_phoneNumberError != "")
            {
                MessageBox.Show(_phoneNumberError);
            }
            if (_emailError != "")
            {
                MessageBox.Show(_emailError);
            }
            if (_vkIdError != "")
            {
                MessageBox.Show(_vkIdError);
            }
        }


        /// <summary>
        /// Добавляет данные контакта
        /// </summary>
        private void CompleteButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
        }


        /// <summary>
        /// Закрывает форму
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Отслеживает изменения в ContactSurname
        /// </summary>
        private void ContactSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = ContactSurname.Text;
                ContactSurname.BackColor = Color.White;
                _surnameError = "";
            }
            catch (Exception exception)
            {
                ContactSurname.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }


        /// <summary>
        /// Отслеживает изменения в ContactName
        /// </summary>
        private void ContactName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = ContactName.Text;
                ContactName.BackColor = Color.White;
                _nameError = "";
            }
            catch (Exception exception)
            {
                ContactName.BackColor = Color.LightPink;
                _nameError = exception.Message;
            }
        }


        /// <summary>
        /// Отслеживает изменения в ContactPhone
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
        /// Отслеживает изменения в ContactEmail
        /// </summary>
        private void ContactEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = ContactEmail.Text;
                ContactEmail.BackColor = Color.White;
                _emailError = "";
            }
            catch (Exception exception)
            {
                ContactEmail.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }



        /// <summary>
        /// Отслеживает изменения в ContactVkId
        /// </summary>
        private void ContactVkId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = ContactVkId.Text;
                ContactVkId.BackColor = Color.White;
                _vkIdError = "";
            }
            catch (Exception exception)
            {
                ContactVkId.BackColor = Color.LightPink;
                _vkIdError = exception.Message;
            }
        }



        /// <summary>
        /// Отслеживает изменения в ContactBirthday
        /// </summary>
        private void ContactBirthday_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = ContactDateOfBirth.Value;
                ContactDateOfBirth.BackColor = Color.White;
                _dateOfBirthError = "";
            }
            catch (Exception exception)
            {
                ContactDateOfBirth.BackColor = Color.LightPink;
                _dateOfBirthError = exception.Message;
            }
        }
    }
}
