using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
	class ProjectTest
	{
		private int ContactsCount { get; set; }
		public Contact[] Contacts { get; set; }
		public Project Project { get; set; }

		[SetUp]
		public void InitProject()
		{
			Contacts = new Contact[]
			{
				new Contact("Стрельникова", "Мария",
				new PhoneNumber(75564856412), "maria@gmail.com",
				new DateTime(1999, 12, 5)),

				new Contact("Афанасьев", "Генадий",
				new PhoneNumber(79994567842), "gena@gmail.com",
				new DateTime(1990, 7, 13)),

				new Contact("Абитаева", "Светлана",
				new PhoneNumber(75564856412), "abitaeva@gmail.com",
				new DateTime(1995, 4, 3)),

				new Contact("Malehin", "Denis",
				new PhoneNumber(79521145688), "malehin@gmail.com",
				new DateTime(1998, 10, 25))
			};

			ContactsCount = 4;

			Project = new Project();
			for (int i = 0; i < ContactsCount - 1; i++)
			{
				Project.AddContact(Contacts[i]);
				Contacts[i].Id = i + 1;
			}

			Contacts[3].Id = 5;
		}

		[Test(Description = "Позитивный тест геттера NewId")]
		public void TestNewIdGet_CorrectValue()
		{
			var expected = 4;
			var actual = Project.NewId;

			Assert.AreEqual(expected, actual, "Геттер NewId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест геттера " +
			"индексатора")]
		public void TestIndexerGet_CorrectValue()
		{
			var expected = Contacts[1];
			var actual = Project[0];

			Assert.AreEqual(expected, actual,
				"Геттер возвращает неверный объект списка");
		}

		[Test(Description = "Позитивный тест конструктора Project")]
		public void TestConstructor_CorrectValue()
		{
			Project project = new Project();

			var expectedNewId = 1;
			var actualNewId = project.NewId;
			Assert.AreEqual(expectedNewId, actualNewId,
				"Неверная инициализация NewId");

			var expectedContactsCount = 0;
			var actualContactsCount = project.GetContactsCount();
			Assert.AreEqual(expectedContactsCount, actualContactsCount,
				"Неверная инициализация списка контактов");
		}

		[Test(Description = "Позитивный тест метода GetContactsCount")]
		public void TestGetContactsCount_CorrectValue()
		{
			var expected = 3;
			var actual = Project.GetContactsCount();

			Assert.AreEqual(expected, actual, "Функция GetContactsCount " +
				"возвращает неверное количество контактов в списке");
		}

		[Test(Description = "Позитивный тест метода AddContact")]
		public void TestAddContact_CorrectValue()
		{
			Project.AddContact(Contacts[3]);

			var expected = Contacts[3];
			var actual = Project[0];

			Assert.AreEqual(expected, actual, "Контакт не был добавлен " +
				"или добавлен на неверную позицию");
		}

		[Test(Description = "Негативный тест метода AddContact")]
		public void TestAddContact_IncorrectValue()
		{
			Assert.Throws<ArgumentException>(() =>
			{ Project.AddContact(null); }, "Должно генерироваться " +
			"исключение, если совершается попытка добавления в " +
			"список значения null");
		}

		[Test(Description = "Позитивный тест метода RemoveContact")]
		public void TestRemoveContact_CorrectValue()
		{

		}

		[Test(Description = "Негативный тест метода RemoveContact")]
		public void TestRemoveContact_IncorrectValue()
		{

		}
	}
}
