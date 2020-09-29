using System;
using System.Collections.Generic;
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
        private string _id;
        /// <summary>
        /// Возвращает и создает id контакта
        /// Id контакта должно состоять не более чем из 15 символом
        /// </summary>
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 15;
                ValueValidator.AssertCorrectValue(value,
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
        /// Имя контакта должна состоять не более чем из 50 символов,
        /// но и не менее чем их одного
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
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "имя контакта");
                _firstName = Convert.ToString(value[0]).ToUpper()
                    + value.Substring(1);
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
                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "фамилию контакта");
                if (value.Length > 0)
                {
                    _lastName = Convert.ToString(value[0]).ToUpper()
                        + value.Substring(1);
                }
                else
                {
                    _lastName = value;
                }
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
        /// <summary>
        /// Возвращает и создает дату рождения контакта
        /// </summary>
        public EventDate BirthDate { get; set; }

        /// <summary>
        /// Инициализирует поля при создании объекта
        /// </summary>
        /// <param name="id">Идентификатор контакта</param>
        /// <param name="firstName">Имя контакта</param>
        /// <param name="lastName">Фамилия контакта</param>
        /// <param name="number">Номер телефона контакта</param>
        /// <param name="email">Адрес электронной почты контакта</param>
        /// <param name="birthDate">Дата рождения контакта</param>
        public Contact(string id, string firstName, string lastName,
            PhoneNumber number, string email, EventDate birthDate)
        {
            Id = id;
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
            EventDate birthDate = new EventDate
                (new DateTime(BirthDate.Date.Year, 
                BirthDate.Date.Month, BirthDate.Date.Day));
            return new Contact(Id, FirstName, LastName, number, Email, birthDate);
        }
    }
}
