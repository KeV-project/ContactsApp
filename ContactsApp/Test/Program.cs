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
                Contact contact1 = new Contact("1", "катя", "кабанова",
                    new PhoneNumber(79521777644), "katovskaya009@gmail.com",
                    new Date(13, 12, 2015));

                Contact contact2 = new Contact("2", "надя", "крылова",
                    new PhoneNumber(79994651234), "nadya@gmail.com",
                    new Date(22, 10, 1999));

                Contact contact3 = new Contact("3", "вера", "сабина",
                   new PhoneNumber(79134688894), "vera009@gmail.com",
                   new Date(10, 01, 1980));


                Project project1 = new Project();
                project1.AddContact(contact1);
                project1.AddContact(contact2);
                project1.AddContact(contact3);

                ProjectManager.SaveProject(project1);

                Project project2 = ProjectManager.ReadProject();
               
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
