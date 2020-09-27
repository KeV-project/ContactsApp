using System;
using System.Collections.Generic;
using System.Text;

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
