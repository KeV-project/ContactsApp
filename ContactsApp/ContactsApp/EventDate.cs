using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Дата события" предназначен для хранения даты события
    /// </summary>
    public class EventDate
    {
        /// <summary>
        /// Поле "дата" хранит дату события
        /// </summary>
        private DateTime _date;
        /// <summary>
        /// Возвращает и создает дату события
        /// Год события не должен быть раньше 1900
        /// и не должен превышать текущий год
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                const int minYear = 1900;
                int maxYear = Convert.ToInt32(DateTime.Now.Year);
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    Convert.ToString(minYear), Convert.ToString(maxYear),
                    CheckType.IsValueInRange, "дату рождения");
                _date = value;
            }
        }
        /// <summary>
        /// Инициализирует поля объекта класса при создании объекта
        /// </summary>
        /// <param name="date">Хранит дату события
        /// Год события не должен быть раньше 1900
        /// и не должен превышать текущий год</param>
        public EventDate(DateTime date)
        {
            Date = date;
        }
    }
}
