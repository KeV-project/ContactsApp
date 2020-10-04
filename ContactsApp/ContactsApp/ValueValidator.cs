﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Валидатор значений" предназначен для проверки значений 
    /// перед непосредственным их использованием
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Метод предназначен для проверки числа на вхождение в определенных диапазон
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <param name="minLimit">Минимальное допустимое значение числа</param>
        /// <param name="maxLimit">Максимальное допустимое значение числа</param>
        /// <returns>Значение показывает, входит ли число в допустимый диапазон </returns>
        public static bool IsValueInRange(double number,
            double minLimit, double maxLimit)
        {
            return minLimit <= number && maxLimit >= number;
        }
        /// <summary>
        /// Метод предназначен для проверки длины строки 
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="minLength">Минимальная допустимая длина строки</param>
        /// <param name="maxLength">Максимальная допустимая длина строки</param>
        /// <returns>Значение показывает, является ли длина строки допустимой для использования</returns>
        public static bool IsLengthInRange(string value, int minLength,
            int maxLength)
        {
            return minLength <= value.Length
                && maxLength >= value.Length;
        }
        /// <summary>
        /// Метод предназначен для проверки первой цифры номера телефона
        /// </summary>
        /// <param name="number">Номер телефона в строковом представлении</param>
        /// <returns>Значение показывает, начинается ли номер телефона с цифры 7</returns>
        public static bool IsFirstDigitIs7(string number)
        {
            return number[0] == '7';
        }
        /// <summary>
        /// Метод предназначен для проверки длины строки
        /// и вхождения всех символов имени в допустимый диапазон значений
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="minLenght">Минимальная длина строки</param>
        /// <param name="maxLength">Максимальная длина строки</param>
        /// <returns></returns>
        public static bool IsCorrectName(string value, int minLenght,
            int maxLength)
        {
            if (!IsLengthInRange(value, minLenght, maxLength))
			{
                return false;
			}

            foreach(char symbol in value)
			{
                if(!(symbol >= 'A' && symbol <='Z')
                    && !(symbol >= 'a' && symbol <= 'z')
                    && !(symbol >= 'А' && symbol <= 'Я')
                    && !(symbol >= 'а' && symbol <= 'я')
                    && !(symbol >= '0' && symbol <= '9')
                    && symbol != ' ')
				{
                    return false;
				}
			}

            return true;
        }

        public static bool IsCorrectDate(DateTime date,
            DateTime minDate, DateTime maxDate)
		{
            return minDate <= date && date <= maxDate;
		}
        /// <summary>
        /// Метод предназначен для генерации исключения при несоответствии значения
        /// заданным условиям
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="minLimit">Минимальная граница</param>
        /// <param name="maxLimit">Максимальная граница</param>
        /// <param name="checkType">Тип проверки</param>
        /// <param name="context">Назначение проверяемого значения
        /// Задается в родительном падеже в нижнем регистре</param>
        public static void AssertCorrectValue(string value,
            string minLimit, string maxLimit,
            CheckType checkType, string context)
        {
            switch (checkType)
            {
                case CheckType.IsValueInRange:
                    {
                        if (!IsValueInRange(Convert.ToDouble(value),
                            Convert.ToDouble(minLimit), Convert.ToDouble(maxLimit)))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: Число " + value
                                + "\nне входит в допустимый дипапазон ["
                                + minLimit + ", " + maxLimit + "]"
                                + "\nи не может определять " + context);
                        }
                        break;
                    }

                case CheckType.IsPhoneNumber:
                    {
                        if (!IsFirstDigitIs7(value))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: " + value
                               + "\n" + context + " должен начинаться с цифры 7");
                        }
                        if (!IsLengthInRange(value, Convert.ToInt32(minLimit),
                            Convert.ToInt32(maxLimit)))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: " + value
                                + "\n" + context + " должен содержать 11 цифр");
                        }
                        break;
                    }
                case CheckType.IsLenghtInRange:
                    {
                        if (!IsLengthInRange(value, Convert.ToInt32(minLimit),
                           Convert.ToInt32(maxLimit)))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: строка " + value
                                + "\n превышает допустимую длину [" + minLimit + ", "
                                + maxLimit + "]" + "\nи не может определять " + context);
                        }
                        break;
                    }
                case CheckType.IsCorrectName:
					{
                        if(!IsCorrectName(value, Convert.ToInt32(minLimit), 
                            Convert.ToInt32(maxLimit)))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: строка \""
                                + value + "\",\nопределяющая " + context
                                + ",\nможет соделжать только цифры и буквы"
                                + "\nи состоять не более чем из " + maxLimit
                                + " символов");
                        }
                        break;
					}
                case CheckType.IsCorrectDate:
					{
                        if(!IsCorrectDate(Convert.ToDateTime(value),
                            Convert.ToDateTime(minLimit), 
                            Convert.ToDateTime(maxLimit)))
						{
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: "
                                + "выбранная дата " + context +  " \"" + value
                                + "\"\nне может быть раньше " 
                                + minLimit + " и позже " + maxLimit);
						}
                        break;
					}
            }
        }
    }
}
