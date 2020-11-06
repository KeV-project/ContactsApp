using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.UnitTests
{
	public static class InitProject
	{
		/// <summary>
		/// Возвращает массив контактов для заполнения списка контактов
		/// объекта класса <see cref="Project">
		/// </summary>
		public static Contact[] Contacts
		{
			get
			{
				Contact[] contacts = 
                {
					new Contact("Denis", "Malehin",
							new PhoneNumber(79521145688), "malehin@gmail.com",
							DateTime.Today),

					new Contact("Светлана", "Абитаева",
							new PhoneNumber(75564856412), "abitaeva@gmail.com",
							new DateTime(1995, 4, 3)),

					new Contact("Генадий", "Афанасьев",
							new PhoneNumber(79994567842), "gena@gmail.com",
							new DateTime(1990, 10, 25)),

					new Contact( "Мария", "Стрельникова",
							new PhoneNumber(75564856412), "maria@gmail.com",
							DateTime.Today)
				};

				for (int i = 0; i < contacts.Length; i++)
				{
					contacts[i].Id = i + 1;
				}

				return contacts;
			}
		}

		/// <summary>
		/// Возвращает объект класса <see cref="Project">
		/// </summary>
		public static Project Project
		{
			get
			{
				Project project = new Project();
				for (int i = 0; i < Contacts.Length; i++)
				{
					project.AddContact(Contacts[i]);
				}
				return project;
			}
		}
	}
}
