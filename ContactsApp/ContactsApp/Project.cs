using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        public LinkedList<Contact> Contacts;

        public Project()
        {
            Contacts = new LinkedList<Contact>();
        }

        public void AddContact(Contact contacts)
        {
            Contacts.AddLast(contacts);
        }

        public int FindContactIndex(string lastName, string firstName)
        {
            int i = 0;
            foreach (Contact currentContact in Contacts)
            {
                if(currentContact.FirstName == firstName
                    && currentContact.LastName == lastName)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public Contact GetContact(int index)
        {
            int i = 0;
            foreach (Contact currentContact in Contacts)
            {
                if (i == index)
                {
                    return currentContact;
                }
                i++;
            }
            return null;
        }

        public void ChangeContact(int index, Contact changedContact)
        {
            LinkedListNode<Contact> currentContact = Contacts.First;
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    Contacts.AddBefore(currentContact, changedContact);
                    Contacts.Remove(currentContact);
                }
                currentContact = currentContact.Next;
            }
        }
    }
}
