using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона, хранящий номер телефона контакта
    /// </summary>
    public class PhoneNumber
    {
        private long _number;
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
        public PhoneNumber(long number)
        {
            Number = number;
        }
    }
}
