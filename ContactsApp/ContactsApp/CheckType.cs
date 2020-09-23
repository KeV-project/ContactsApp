using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    /// <summary>
    /// Перечисление категории проверок предназначено для организации 
    /// системы проверки значений на корректность
    /// </summary>
    public enum CheckType
    {
        /// <summary>
        /// Значение предназначено для индентификации проверки
        /// на вхождение числа в определенный диапазон значений
        /// </summary>
        IsValueInRange,
        /// <summary>
        /// Значение предназначено для идентификации проверки
        /// на содержание в переменной номера телефона
        /// </summary>
        IsPhoneNumber,
        /// <summary>
        /// Значение предназначено для идентификации проверки
        /// на допустимое количества символов в строке
        /// </summary>
        IsLenghtLessThen
    }
}
