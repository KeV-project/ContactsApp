﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс <see cref="PhoneNumber"/> хранит информацию 
    /// о номере телефона контакта
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Поле "номер" предназначено для хранения номера телефона контакта
        /// </summary>
        private long _number;

        /// <summary>
        /// Возвращает и создает номер телефона контакта
        /// Номер телефона должен начинаться с цифры "7" и состоять из 11 цифр
        /// </summary>
        public long Number
        {
            get
            {
                return _number;
            }
            set
            {
                const int minNumbersLength = 11;
                const int maxNumbersLength = 11;
                ValueValidator.AssertRussianPhoneNumber(value,
                    minNumbersLength, maxNumbersLength,
                   "номер телефона");
                _number = value;
            }
        }

        /// <summary>
        /// Инициализирует поля объекта при создании 
        /// значениями по умолчанию
        /// </summary>
        public PhoneNumber()
        {
            Number = 70000000000;
        }

        /// <summary>
        /// Инициализирует поля объекта при создании
        /// </summary>
        /// <param name="number">Номер телефона контакта</param>
        public PhoneNumber(long number)
        {
            Number = number;
        }
    }
}
