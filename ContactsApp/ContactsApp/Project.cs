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

            LinkedListNode<Contact> currentContact = Contacts.First;
            for (int i = 0; i < Contacts.Count; i++)
            {
                int minLenght = 0;
                if (newContact.LastName.Length < currentContact.Value.LastName.Length)
                {
                    minLenght = newContact.LastName.Length;
                }
                else
                {
                    minLenght = currentContact.Value.LastName.Length;
                }

                for (int currentSymbol = 0; currentSymbol < minLenght; currentSymbol++)
                {
                    if (!char.IsLetter(newContact.LastName[currentSymbol]) && char.IsLetter(currentContact.Value.LastName[currentSymbol]))
                    {
                        currentContact = currentContact.Next;
                        break;
                    }
                    if (char.IsLetter(newContact.LastName[currentSymbol]) && !char.IsLetter(currentContact.Value.LastName[currentSymbol]))
                    {
                        return currentContact;
                    }
                    if (newContact.LastName[currentSymbol] == currentContact.Value.LastName[currentSymbol])
                    {
                        if (currentSymbol == minLenght - 1)
                        {
                            if (newContact.LastName.Length < currentContact.Value.LastName.Length)
                            {
                                return currentContact;
                            }
                            else
                            {
                                currentContact = currentContact.Next;
                                break;
                            }
                        }
                        continue;
                    }
                    if (newContact.LastName[currentSymbol] < currentContact.Value.LastName[currentSymbol])
                    {
                        return currentContact;
                    }
                    if (newContact.LastName[currentSymbol] > currentContact.Value.LastName[currentSymbol])
                    {
                        currentContact = currentContact.Next;
                        break;
                    }
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

        public LinkedList<Contact> GetContactsWithText(string text)
        {
            LinkedList <Contact> contactsWithText = new LinkedList<Contact>();

            foreach (Contact currentContact in Contacts)
            {
                if((currentContact.LastName + " "
                    + currentContact.FirstName).Contains(text))
                {
                    contactsWithText.AddLast(currentContact);
                }
            }

            return contactsWithText;
        }

        public void RemoveContact(Contact removableContact)
        {
            Contacts.Remove(removableContact);
        }

        public LinkedList<Contact> GetAllBirthContacts()
		{
            LinkedList <Contact> birthCotacts = new LinkedList<Contact>();

            foreach(Contact currentContact in Contacts)
			{
                if(currentContact.BirthDate.Day == DateTime.Today.Day
                    && currentContact.BirthDate.Month == DateTime.Today.Month)
				{
                    birthCotacts.AddLast(currentContact);
				}
			}
            return birthCotacts;
        }
    }
}
