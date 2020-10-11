using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
	/// <summary>
	/// Класс <see cref="ProjectManagerTest"/> предназначен
	/// дла тестирования класса <see cref="ProjectManager"/>
	/// </summary>
	class ProjectManagerTest
	{
		private int ContactsCount { get; set; }
		public Contact[] Contacts { get; set; }
		public Project Project { get; set; }

		[SetUp]
		public void InitProject()
		{
			Contacts = new Contact[]
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

			ContactsCount = 4;

			Project = new Project();
			for (int i = 0; i < ContactsCount; i++)
			{
				Project.AddContact(Contacts[i]);
				Contacts[i].Id = i + 1;
			}
		}

		[Test(Description = "Положительный тест метода SaveProject")]
		public void TestSaveProject_CorrectValue()
		{
			//var expected = Project;
			var expected = new Project();

			ProjectManager.SaveProject(expected);

			var actual = ProjectManager.ReadProject();

			var result = Convert.ToBoolean(expected.CompareTo(actual));
			Assert.IsFalse(result, "Потеря данных при сериализации объекта");
		}
	}
}
