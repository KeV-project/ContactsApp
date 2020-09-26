using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Дата" предназначен для хранения даты события
    /// </summary>
    public class Date
    {
        /// <summary>
        /// Поле "день" хранит день события
        /// </summary>
        private int _day;
        /// <summary>
        /// Возвращает и создает день события
        /// День должен быть целым числом в диапазоне [1, 31]
        /// </summary>
        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                const int minDay = 1;
                const int maxDay = 31;
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    Convert.ToString(minDay), Convert.ToString(maxDay),
                    CheckType.IsValueInRange, "день");
                _day = value;
            }
        }

        /// <summary>
        /// Поде "месяц" хранит месяц события
        /// </summary>
        private int _month;
        /// <summary>
        /// Возвращает и задает месяц события
        /// Месяц должен быть целым числом в диапазоне [1, 12]
        /// </summary>
        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                const int minMonth = 1;
                const int maxMonth = 12;
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    Convert.ToString(minMonth), Convert.ToString(maxMonth),
                    CheckType.IsValueInRange, "месяц");
                _month = value;
            }
        }

        /// <summary>
        /// Поле "год" хранит год события
        /// </summary>
        private int _year;
        /// <summary>
        /// Возвращает и задает год события
        /// Год должен быть числом в диапазоне [1900, 2020]
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                const int minYear = 1900;
                const int maxYear = 2020;
                ValueValidator.AssertCorrectValue(Convert.ToString(value),
                    Convert.ToString(minYear), Convert.ToString(maxYear),
                    CheckType.IsValueInRange, "год");
            }
        }
    }
}
