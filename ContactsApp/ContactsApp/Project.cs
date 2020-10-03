using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ContactsApp
{
    [DataContract]
    public class Project
    {
        [DataMember]
        private int _lastId;
        public int NewId => ++_lastId;

        [DataMember]
        private LinkedList<Contact> Contacts { get; set; }

        public Project()
        {
            _lastId = 0;
            Contacts = new LinkedList<Contact>();
        }

        public int GetContactsCount()
        {
            return Contacts.Count;
        }

        public void AddContact(Contact newContact)
        {
            newContact.Id = NewId;
            Contacts.AddLast(newContact);
        }

        public Contact GetContact(int index)
        {
            if(index >= Contacts.Count)
            {
                return null;
            }

            LinkedListNode<Contact> currentContact = Contacts.First;
            for(int i = 0; i <= index; i++)
            {
                if(i == index)
                {
                    return currentContact.Value;
                }
                currentContact = currentContact.Next;
            }

            return null;
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
