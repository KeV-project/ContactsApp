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
        /// Поле "id" содержит идентификатор контакта
        /// </summary>
        private int _id;
        /// <summary>
        /// Возвращает и создает id контакта
        /// Id контакта должно состоять не более чем из 15 символом
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 15;
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "id контакта");
                _id = value;
            }
        }

        /// <summary>
        /// Поле "имя" содержит имя контакта
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Возвращает и создает имя контакта
        /// Имя контакта должна состоять не более чем из 50 символов
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                value = value.TrimStart();

                const int minLength = 1;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsCorrectName,
                    "имя контакта");

                ValueCorrector.ToUpperFirstLetter(value);

                _firstName = value;
            }
        }

        /// <summary>
        /// Поле "фамилия" содердит фамилию контакта
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
                value = value.TrimStart();

                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsCorrectName,
                    "фамилию контакта");

                ValueCorrector.ToUpperFirstLetter(value);

                _lastName = value;
            }
        }

        /// <summary>
        /// Возвращает и создает номер телефона контакта
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Поле "e-mail" содержит адрес электронной почты контакта
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
                value = value.TrimStart();

                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "e-mail контакта");
                _email = value;
            }
        }
        private DateTime _birthDate;
        /// <summary>
        /// Возвращает и создает дату рождения контакта
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                string minDate = Convert.ToString(new DateTime(1900, 12, 31, 23, 59, 59));
                string maxDate = Convert.ToString(new DateTime(DateTime.Today.Year,
                    DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59));
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    minDate, maxDate,
                    CheckType.IsCorrectDate, "рождения");
                _birthDate = value;
            }
        }

        public Contact()
        {
            Id = 0;
            FirstName = "Не определено";
            LastName = "Не определено";
            Number = new PhoneNumber();
            Email = "Не определен";
            BirthDate = DateTime.Now;
        }

        /// <summary>
        /// Инициализирует поля при создании объекта
        /// </summary>
        /// <param name="id">Идентификатор контакта</param>
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
        /// <returns></returns>
        public object Clone()
        {
            PhoneNumber number = new PhoneNumber(Number.Number);
            DateTime birthDate = new DateTime(BirthDate.Year, 
                BirthDate.Month, BirthDate.Day);
            return new Contact(FirstName, LastName, number, Email, birthDate);
        }
    }
}
