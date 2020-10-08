﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Контакт" предназначен для создания контактов 
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Cодержит идентификатор контакта
        /// </summary>
        private long _id;
        /// <summary>
        /// Возвращает и создает id контакта
        /// Id контакта должно состоять не более чем из 15 символом
        /// </summary>
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 15;
                ValueValidator.AssertLengthInRange(Convert.ToString(value),
                    minLength, maxLength, "id контакта");
                _id = value;
            }
        }

        /// <summary>
        /// Cодержит имя контакта
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Возвращает и создает имя контакта
        /// Имя контакта должна состоять не более чем из 50 символов,
        /// но не менее чем из 1
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                const int minLength = 1;
                const int maxLength = 50;
                ValueValidator.AssertCorrectName(value,
                    minLength, maxLength, "имя контакта");

                _firstName = ValueCorrector.ToUpperFirstLetter(value);
            }
        }

        /// <summary>
        /// Содердит фамилию контакта
        /// </summary>
        private string _lastName;
        /// <summary>
        /// Возвращает и создает фамилию контакта
        /// Фамилия контакта должна состоять не более чем из 50 символов
        /// Данное поле необязательно для заполнения
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectName(value,
                   minLength, maxLength, "фамирия контакта");

                _lastName = ValueCorrector.ToUpperFirstLetter(value);
            }
        }

        /// <summary>
        /// Возвращает и создает номер телефона контакта
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Содержит адрес электронной почты контакта
        /// </summary>
        private string _email;
        /// <summary>
        /// Возвращает и создает e-mail контакта
        /// Адрес электронной почты должен состоять не более чем из 50 символов
        /// Поле необязательное для заполнения
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                value = value.Replace(" ", "");

                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertLengthInRange(value,
                    minLength, maxLength, "e-mail контакта");

                _email = value;
            }
        }
        /// <summary>
        /// Содержит дату рождения контакта
        /// </summary>
        private DateTime _birthDate;
        /// <summary>
        /// Возвращает и создает дату рождения контакта
        /// Дата рождения не может быть раньше 1900 года и
        /// позже текущей даты 
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                DateTime minDate = new DateTime(1900, 12, 31, 23, 59, 59);
                DateTime maxDate = new DateTime(DateTime.Today.Year,
                    DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59);
                ValueValidator.AssertCorrectDate(value, minDate, maxDate,
                     "рождения");

                _birthDate = value;
            }
        }

        /// <summary>
        /// Инициализирует поля класа значениями по умолчанию
        /// </summary>
        public Contact()
        {
            Id = 0;
            FirstName = "неизвестно";
            LastName = "неизвестно";
            Number = new PhoneNumber();
            Email = "Неизвестно";
            BirthDate = DateTime.Today;
        }

        /// <summary>
        /// Инициализирует поля при создании объекта
        /// </summary>
        /// <param name="firstName">Имя контакта</param>
        /// <param name="lastName">Фамилия контакта</param>
        /// <param name="number">Номер телефона контакта</param>
        /// <param name="email">Адрес электронной почты контакта</param>
        /// <param name="birthDate">Дата рождения контакта</param>
        public Contact(string firstName, string lastName,
            PhoneNumber number, string email, DateTime birthDate)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Email = email;
            BirthDate = birthDate;
        }

        /// <summary>
        /// Позволяет создать объект класса, скопировав значения полей другого объекта
        /// </summary>
        /// <returns> Возвращает копию объекта</returns>
        public object Clone()
        {
            PhoneNumber number = new PhoneNumber(Number.Number);
            DateTime birthDate = new DateTime(BirthDate.Year, 
                BirthDate.Month, BirthDate.Day);
            return new Contact(FirstName, LastName, number, Email, birthDate);
        }
    }
}
