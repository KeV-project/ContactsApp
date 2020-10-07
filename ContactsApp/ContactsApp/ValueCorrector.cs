﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    //TODO: Правильнее писать в следующем порядке public static
    /// <summary>
    /// Класс "Корректор значений" предназначен
    /// для корректировки введенных пользователем данных
    /// </summary>
    static public class ValueCorrector
    {
        /// <summary>
        /// Метод предназначен для исключения из строки,
        /// содержащей номер телефона, всех поосторонних символов
        /// </summary>
        /// <param name="number">Корректируемый номер телефона</param>
        /// <returns>Возвращает номер телефона в целочисленном формате</returns>
        static public long ConvertPhoneNumberToInt(string number)
        {
            number = number.Replace(" ", "");
            number = number.Replace("+", "");
            number = number.Replace("(", "");
            number = number.Replace(")", "");
            number = number.Replace("-", "");
            return Convert.ToInt64(number);
        }

        /// <summary>
        /// Метод предназначен для корректирови 
        /// введенного пользователем имени или фамилии
        /// </summary>
        /// <param name="value">Корректируемая строка</param>
        /// <returns>Если строка пустая возвращает исходную строку.
        /// Если строка начинается с буквы, 
        /// возвращает ту же строку, первая буква которой - заглавная</returns>
        static public string ToUpperFirstLetter(string value)
		{
            if (value.Length > 0)
            {
                value = Convert.ToString(value[0]).ToUpper()
                    + value.Substring(1);
            }
            return value;
        }
    }
}
