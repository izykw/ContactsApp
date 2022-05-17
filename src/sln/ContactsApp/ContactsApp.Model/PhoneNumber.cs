using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Максимальная длина номера телефона.
        /// </summary>
        private const int MAXLENGTH = 11;


        /// <summary>
        /// Номер телефона.
        /// </summary>
        private long _number;


        /// <summary>
        /// Геттер и Сеттер для _number.
        /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                string newValue = value.ToString();
                if (newValue.Length > MAXLENGTH || newValue[0] != '7')
                {
                    throw new ArgumentException("The max length of a phone number is 11 and it should start with 7");
                }
                _number = value;
            }
        }


        /// <summary>
        /// Конструктор для номера телефона
        /// </summary>
        /// <param name="value">номер телефона</param>
        public PhoneNumber(long value)
        {
            Number = value;
        }
    }
}
