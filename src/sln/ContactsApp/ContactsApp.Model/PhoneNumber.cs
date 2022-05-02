using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Номер телефона контакта
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Максимальная длина номера телефона
        /// </summary>
        private const int _MAX_LENGTH = 11;

        /// <summary>
        /// Номер телефона
        /// </summary>
        private long _number;

        public long Number
        {
            get => _number;
            set
            {
                Console.WriteLine(value);
                if (value.ToString().Length > _MAX_LENGTH)
                {
                    throw new ArgumentException("The max length of a phone number is 11");
                }
                _number = value;
            }
        }
        public PhoneNumber(long value)
        {
            Number = value;
        }
    }
}
