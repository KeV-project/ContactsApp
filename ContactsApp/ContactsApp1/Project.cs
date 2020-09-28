using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        public LinkedList<Contact> _contacts;

        public Project()
        {
            _contacts = new LinkedList<Contact>();
        }

        public void AddContact(Contact contacts)
        {
            _contacts.AddLast(contacts);
        }
    }
}
