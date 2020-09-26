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
                Contact contact = new Contact("катя", "кабанова", "katovskaya009@gmail.com", "123");
                Console.WriteLine($"Имя: {contact.FirstName}");
                Console.WriteLine($"Фамилия: {contact.LastName}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
