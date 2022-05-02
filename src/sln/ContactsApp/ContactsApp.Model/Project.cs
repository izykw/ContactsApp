using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Список всех контактов, созданных в приложении
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех контактов
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();
        public List<Contact> Contacts { get; set; }
    }
}
