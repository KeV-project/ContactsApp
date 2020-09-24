using System;
using ContactsApp;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PhoneNumber phoneNumber = new PhoneNumber(795217776444);
                Console.WriteLine(phoneNumber.Number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
