using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    static public class ValueCorrector
    {
        static public long ConvertPhoneNumberToInt(string number)
        {
            number = number.Replace(" ", "");
            number = number.Replace("+", "");
            number = number.Replace("(", "");
            number = number.Replace(")", "");
            number = number.Replace("-", "");
            return Convert.ToInt64(number);
        }

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
