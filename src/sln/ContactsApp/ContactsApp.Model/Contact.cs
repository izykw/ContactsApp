using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Максимальная длина строк: _name, _surname, _mail
        /// </summary>
        private const int _MAX_LENGTH = 50;

        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона
        /// </summary>
        private PhoneNumber _phoneNumber;


        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Почта
        /// </summary>
        private string _email;

        /// <summary>
        /// Вк id
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Возвращает строку, где первый символ возведен в верхний регистр
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string FirstLetterToUpper(string str)
        {
            return Char.ToUpper(str[0]) + str.Substring(1);
        }

        /// <summary>
        /// Возвращает строку, если она не превышает максимально допустимую длину, иначе - исключение
        /// </summary>
        /// <param name="str"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static string CheckMaxLengthString(string str, int maxLength)
        {
            if (str.Length > maxLength)
            {
                throw new ArgumentException($"The maximum number of characters is {maxLength}");
            }
            return str;
        }

        public string Name
        {
            get => _name;
            set => _name = FirstLetterToUpper(CheckMaxLengthString(value, _MAX_LENGTH));
        }

        public string Surname
        {
            get => _surname;
            set => _surname = FirstLetterToUpper(CheckMaxLengthString(value, _MAX_LENGTH));
        }

        public PhoneNumber PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (value > DateTime.Now || value.Year < 1900)
                {
                    throw new ArgumentException("The date cannot be greater than today and less than 1900");
                }
                _dateOfBirth = value;
            }
        }

        public string Email
        {
            get => _email;
            set => _email = CheckMaxLengthString(value, _MAX_LENGTH);
        }

        public string VkId
        {
            get => _vkId;
            set => _vkId = CheckMaxLengthString(value, 15);
        }

        public Contact(string name, string surname, PhoneNumber phoneNumber, DateTime dateOfBirth, string email, string vkId)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            VkId = vkId;
        }
        public object Clone() => 
            new Contact(Name, Surname, new PhoneNumber(PhoneNumber.Number), DateOfBirth, Email, VkId);
    }
}
