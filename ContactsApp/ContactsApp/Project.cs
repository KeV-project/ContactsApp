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

        public LinkedListNode<Contact> GetNodeBeforeInsert(Contact newContact)
        {
            if(Contacts.Count == 0)
            {
                return null;
            }

            if(newContact.LastName[0] >= 'A' && newContact.LastName[0] <= 'Z'
                || newContact.LastName[0] >= 'А' && newContact.LastName[0] <= 'Я')
            {
                LinkedListNode<Contact> currentNode = Contacts.First;
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (newContact.LastName[0] < currentNode.Value.LastName[0]
                        || !(currentNode.Value.LastName[0] >= 'A' && currentNode.Value.LastName[0] <= 'Z'
                        || currentNode.Value.LastName[0] >= 'А' && currentNode.Value.LastName[0] <= 'Я'))
                    {
                        return currentNode;
                    }
                    currentNode = currentNode.Next;
                }
            }

            return null;
        }

        public void AddContact(Contact newContact)
        {
            newContact.Id = NewId;
            LinkedListNode<Contact> afterInserted = 
                GetNodeBeforeInsert(newContact);
            if(afterInserted == null)
            {
                Contacts.AddLast(newContact);
            }
            else
            {
                Contacts.AddBefore(afterInserted, newContact);
            }
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

        public void RemoveContact(Contact removableContact)
        {
            Contacts.Remove(removableContact);
        }
    }
}
