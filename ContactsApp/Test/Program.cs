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
                Contact contact = new Contact("123", "катя", "кабанова", 
                    new PhoneNumber(79521777644), "katovskaya009@gmail.com", 
                    new Date(13, 12, 2015));
                Console.WriteLine($"Id: {contact.Id}");
                Console.WriteLine($"Имя: {contact.FirstName}");
                Console.WriteLine($"Фамилия: {contact.LastName}");
                Console.WriteLine($"Номер телефона: {contact.Number.Number}");
                Console.WriteLine($"E-mail: {contact.Email}");
                Console.WriteLine($"Дата рождения: {contact.BirthDate.GetData()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
