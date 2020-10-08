using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq;

namespace ContactsApp
{
    /// <summary>
    /// Класс <see cref="Project"/> предназначен для хранения
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

        //TODO: Почему не просто список List? +
        /// <summary>
        /// Хранит все контакты пользователя
        /// </summary>
        [DataMember]
        private List<Contact> _contacts;

        //TODO: Лучше сделать индексатор +
        public Contact this[int index]
		{
			get
			{
                return _contacts[index];
            }
			private set
			{
                _contacts.Insert(index, value);
            }
		}

        /// <summary>
        /// Создает проект, 
        /// инициализируя поля начальными значениями
        /// </summary>
        public Project()
        {
            _lastId = 0;
            _contacts = new List<Contact>();
        }

        /// <summary>
        /// Возвращает количество контактов в списке
        /// </summary>
        /// <returns>Значение показывает, скоько контактов в списке</returns>
        public int GetContactsCount()
        {
            return _contacts.Count;
        }

        //TODO: Тут бы я посмотрел в сторону сортируемой коллекции, т.к. алгоритм получается слишком разухабистый
        //TODO: Если коротко, то надо реализовать IComparable для Contact и вызов Sort у листа нормально будет отрабатывать ?
        // https://metanit.com/sharp/tutorial/3.23.php

        /// <summary>
        /// Метод добавляет новый контакт в список проекта
        /// и сортирует список по фамилиям контактов
        /// </summary>
        /// <param name="newContact">Новый контакт</param>
        public void AddContact(Contact newContact)
        {
            newContact.Id = NewId;
            _contacts.Add(newContact);
            _contacts.Sort();
        }

        /// <summary>
        /// Метод удаляет контакт из списка
        /// </summary>
        /// <param name="removableContact">Удаляемый контакт</param>
        public void RemoveContact(Contact removableContact)
        {
            _contacts.Remove(removableContact);
        }

        /// <summary>
        /// Метод отбирает все контакты,
        /// имя и фамилия которых содержит подстроку
        /// </summary>
        /// <param name="text">Подстрока, наличие которой определяется
        /// в имени и фамилии контакта</param>
        /// <returns>Список контактов, имя и фамилия которых содержит подстроку</returns>
        public List<Contact> GetContactsWithText(string text)
        {
            List <Contact> contactsWithText = new List<Contact>();

            foreach (Contact currentContact in _contacts)
            {
                if((currentContact.LastName + " "
                    + currentContact.FirstName).Contains(text))
                {
                    contactsWithText.Add(currentContact);
                }
            }

            return contactsWithText;
        }

        /// <summary>
        /// Метод отбирает все контакты, 
        /// у который сегодня день рождения
        /// </summary>
        /// <returns>Список контактов, 
        /// у которых сегодня день рождения</returns>
        public List<Contact> GetAllBirthContacts()
		{
            List <Contact> birthCotacts = new List<Contact>();

            foreach(Contact currentContact in _contacts)
			{
                if(currentContact.BirthDate.Day == DateTime.Today.Day
                    && currentContact.BirthDate.Month 
                    == DateTime.Today.Month)
				{
                    birthCotacts.Add(currentContact);
				}
			}
            return birthCotacts;
        }
    }
}
