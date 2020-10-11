using System;
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
    public class PhoneNumber : IComparable <PhoneNumber>
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
                ValueValidator.AssertRussianPhoneNumber(value, 
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

        /// <summary>
        /// Сравнивает два объекта класса
        /// Если объекты равны, возвращает 1.
        /// Если объекты не равны, позвращает 0
        /// </summary>
        /// <param name="number">Объект класса, который будет сравниваться
        /// с текущим объектом</param>
        /// <returns>Возвращаемое значение показывает
        /// рывны или нерфвны сравниваемые объекты класса</returns>
        public int CompareTo(PhoneNumber number)
		{
            if(this.Number == number.Number)
			{
                return 1;
			}
            return 0;
		}
    }
}
