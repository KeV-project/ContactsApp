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
    /// <summary>
    /// Класс "Проект" предназначен для хранение
    /// пользовательской информации приложения
    /// </summary>
    [DataContract]
    public class Project
    {
        /// <summary>
        /// Поле "Последний id" хранит последний 
        /// выданный контакту идентификатор
        /// </summary>
        [DataMember]
        private int _lastId;
        /// <summary>
        /// Возвращает идентификатор для нового контакта
        /// </summary>
        public int NewId => ++_lastId;

        /// <summary>
        /// Хранит все контакты пользователя
        /// </summary>
        [DataMember]
        private LinkedList<Contact> Contacts { get; set; }

        /// <summary>
        /// Создает проект, 
        /// инициализируя поля начальными значениями
        /// </summary>
        public Project()
        {
            _lastId = 0;
            Contacts = new LinkedList<Contact>();
        }

        /// <summary>
        /// Возвращает количество контактов в списке
        /// </summary>
        /// <returns>Значение показывает, скоько контактов в списке</returns>
        public int GetContactsCount()
        {
            return Contacts.Count;
        }

        /// <summary>
        /// Возвращает узел списка, перед которым
        /// следует добавить новый контакт
        /// в соответствии с алфовитным порядком
        /// </summary>
        /// <param name="newContact">Новый контакт</param>
        /// <returns>Узел списка, перед которым рекомендуется
        /// вставку нового объекта</returns>
        public LinkedListNode<Contact> GetNodeBeforeInsert(
            Contact newContact)
        {
            if(Contacts.Count == 0)
            {
                return null;
            }

            LinkedListNode<Contact> currentContact = Contacts.First;
            for (int i = 0; i < Contacts.Count; i++)
            {
                int minLenght = 0;
                if (newContact.LastName.Length 
                    < currentContact.Value.LastName.Length)
                {
                    minLenght = newContact.LastName.Length;
                }
                else
                {
                    minLenght = currentContact.Value.LastName.Length;
                }

                for (int currentSymbol = 0; 
                    currentSymbol < minLenght; 
                    currentSymbol++)
                {
                    if (!char.IsLetter(newContact.LastName[currentSymbol]) 
                        && char.IsLetter(currentContact.Value.
                        LastName[currentSymbol]))
                    {
                        currentContact = currentContact.Next;
                        break;
                    }

                    if (char.IsLetter(newContact.LastName[currentSymbol]) 
                        && !char.IsLetter(currentContact.
                        Value.LastName[currentSymbol]))
                    {
                        return currentContact;
                    }

                    if (newContact.LastName[currentSymbol] 
                        == currentContact.Value.LastName[currentSymbol])
                    {
                        if (currentSymbol == minLenght - 1)
                        {
                            if (newContact.LastName.Length 
                                < currentContact.Value.LastName.Length)
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

                    if (newContact.LastName[currentSymbol] 
                        < currentContact.Value.LastName[currentSymbol])
                    {
                        return currentContact;
                    }

                    if (newContact.LastName[currentSymbol] 
                        > currentContact.Value.LastName[currentSymbol])
                    {
                        currentContact = currentContact.Next;
                        break;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Метод добавляет новый контакт в список проекта
        /// </summary>
        /// <param name="newContact">Новый контакт</param>
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

        /// <summary>
        /// Метод возвращает контакт из списка
        /// по указанному индексу
        /// </summary>
        /// <param name="index">Индекс возвращаемого контакта</param>
        /// <returns>Объект списка по указанному индексу</returns>
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

        /// <summary>
        /// Метод отбирает все контакты,
        /// имя и фамилия которых содержит подстроку
        /// </summary>
        /// <param name="text">Подстрока, наличие которой определяется
        /// в имени и фамилии контакта</param>
        /// <returns>Список контактов, имя и фамилия которых содержит подстроку</returns>
        public LinkedList<Contact> GetContactsWithText(string text)
        {
            LinkedList <Contact> contactsWithText = 
                new LinkedList<Contact>();

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

        /// <summary>
        /// Метод удаляет контакт из списка
        /// </summary>
        /// <param name="removableContact">Удаляемый контакт</param>
        public void RemoveContact(Contact removableContact)
        {
            Contacts.Remove(removableContact);
        }

        /// <summary>
        /// Метод отбирает все контакты, 
        /// у который сегодня день рождения
        /// </summary>
        /// <returns>Список контактов, 
        /// у которых сегодня день рождения</returns>
        public LinkedList<Contact> GetAllBirthContacts()
		{
            LinkedList <Contact> birthCotacts = new LinkedList<Contact>();

            foreach(Contact currentContact in Contacts)
			{
                if(currentContact.BirthDate.Day == DateTime.Today.Day
                    && currentContact.BirthDate.Month 
                    == DateTime.Today.Month)
				{
                    birthCotacts.AddLast(currentContact);
				}
			}
            return birthCotacts;
        }
    }
}
