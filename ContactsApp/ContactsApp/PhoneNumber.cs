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
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                const int numbersLength = 11;
                
            }
        }
    }
}
