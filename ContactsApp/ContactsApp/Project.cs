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

        public int FindContactIndex(string firstName, string lastName)
        {
            foreach(Contact currentContact in _contacts)
            {
                int i = 0;
                if(currentContact.FirstName == firstName
                    && currentContact.LastName == lastName)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
