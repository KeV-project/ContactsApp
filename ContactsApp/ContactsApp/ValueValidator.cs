using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    public static class ValueValidator
    {
        public static bool IsNumbersLengthIs(int number, int digitCount)
        {
            int digitCounter = 0;
            while (number > 0)
            {
                digitCounter++;
                number /= 10;
            }

            return digitCounter == digitCount;
        }

        public static bool IsFirstDigitIs7(int number)
        {
            if(number / 10000000000 == 7)
            {
                return true;
            }
            return false;
        }

        public static void IsCorrectValue()
        {

        }
    }
}
