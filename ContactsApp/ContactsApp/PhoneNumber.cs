using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Номера телефона", хранящий номер телефона контакта
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
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                   Convert.ToString(minNumbersLength),
                   Convert.ToString(maxNumbersLength), CheckType.IsPhoneNumber,
                   "номер телефона");
                _number = value;
            }
        }
        /// <summary>
        /// Инициализирует поля класса при создании объекта
        /// </summary>
        /// <param name="number">Номер телефона контакта</param>
        public PhoneNumber(long number)
        {
            Number = number;
        }
    }
}
