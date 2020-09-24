using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ContactsApp
{
    public static class ValueValidator
    {
        public static bool IsValueInRange(double number, 
            double minLimit, double maxLimit)
        {
            return minLimit <= number && maxLimit >= number;
        }

        public static bool IsLengthInRange(string number, int minLength,
            int maxLength)
        {
            return minLength <= number.Length 
                && maxLength >= number.Length;
        }

        public static bool IsFirstDigitIs7(string number)
        {
            return number[0] == 7;
        }

        public static void AssertCorrectValue(string value, 
            string minLimit, string maxLimit, 
            CheckType checkType, string context)
        {
            switch(checkType)
            {
                case CheckType.IsValueInRange:
                    {
                        if(!IsValueInRange(Convert.ToDouble(value), 
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
                        if(!IsFirstDigitIs7(value))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: " + value
                               + "\n" + context + " должен начинаться с цифры 7");
                        }
                        if(!IsLengthInRange(value, Convert.ToInt32(minLimit),
                            Convert.ToInt32(maxLimit)))
                        {
                            throw new ArgumentException("ИСКЛЮЧЕНИЕ: " + value
                                + "\n" + context + "должен содержать 11 цифр");
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
                                + maxLimit + "]"  + "\nи не может определять " + context);
                        }
                        break;
                    }
            }
        }
    }
}
