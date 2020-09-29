using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    static class ValueCorrector
    {
        static public long ConvertPhoneNumberToIn(string number)
        {
            number = number.Replace(" ", "");
            number = number.Replace("+", "");
            number = number.Replace("(", "");
            number = number.Replace(")", "");
            number = number.Replace("-", "");
            return Convert.ToInt64(number);
        }
    }
}
