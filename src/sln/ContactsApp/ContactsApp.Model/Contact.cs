using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Максимальная длина строк: _name, _surname, _mail.
        /// </summary>
        private const int MAXLETTERCOUNT = 50;


        /// <summary>
        /// Максимальная длина _vlId.
        /// </summary>
        private const int MAXIDSIZE = 15;


        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;


        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;


        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirth;


        /// <summary>
        /// Почта.
        /// </summary>
        private string _email;


        /// <summary>
        /// Вк id.
        /// </summary>
        private string _vkId;


        /// <summary>
        /// Возвращает строку, где первый символ возведен в верхний регистр.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns></returns>
        private static string FirstLetterToUpper(string value)
        {
            return Char.ToUpper(value[0]) + value.Substring(1);
        }


        /// <summary>
        /// Возвращает строку, если она не превышает максимально допустимую длину, иначе - исключение.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="maxLength">Максимальный размер строки</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static string CheckMaxLengthString(string value, int maxLength)
        {
            if (value.Length > maxLength || value.Length == 0)
            {
                throw new ArgumentException($"The maximum number of characters is {maxLength} and field should not be empty");
            }
            return value;
        }


        /// <summary>
        /// Геттер и Сеттер для _name.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = FirstLetterToUpper(CheckMaxLengthString(value, MAXLETTERCOUNT));
        }


        /// <summary>
        /// Геттер и Сеттер для _surname.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = FirstLetterToUpper(CheckMaxLengthString(value, MAXLETTERCOUNT));
        }


        /// <summary>
        /// Геттер и Сеттер для _phoneNumber.
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; }


        /// <summary>
        /// Геттер и Сеттер для _dateOfBirth.
        /// </summary>
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


        /// <summary>
        /// Геттер и Сеттер для _email.
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = CheckMaxLengthString(value, MAXLETTERCOUNT);
        }


        /// <summary>
        /// Геттер и Сеттер для _vkId.
        /// </summary>
        public string VkId
        {
            get => _vkId;
            set => _vkId = CheckMaxLengthString(value, MAXIDSIZE);
        }


        /// <summary>
        /// Конструктор для контакта.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="phoneNumber">Номер телефона, начинается с 7 максимум 11 символов</param>
        /// <param name="dateOfBirth">Дата рождения</param>
        /// <param name="email">Почта</param>
        /// <param name="vkId">Вк id</param>
        public Contact(string name, string surname, PhoneNumber phoneNumber, DateTime dateOfBirth, string email, string vkId)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            VkId = vkId;
        }


        /// <summary>
        /// Создает клон контакта.
        /// </summary>
        /// <returns></returns>
        public Object Clone() => 
            new Contact(Name, Surname, new PhoneNumber(PhoneNumber.Number), DateOfBirth, Email, VkId);
    }
}
