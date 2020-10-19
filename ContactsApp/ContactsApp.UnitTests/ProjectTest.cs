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
	/// Класс <see cref="ProjectTest"/> пердназначен для
	/// тестирования класса <see cref="Project"/>
	/// </summary>
	class ProjectTest
	{
		/// <summary>
		/// Количестов объектов в массиве
		/// </summary>
		private int ContactsCount { get; set; }
		/// <summary>
		/// Массив объектов списка тестируемого объекта
		/// </summary>
		public Contact[] Contacts { get; set; }
		/// <summary>
		/// Тестируемый объект
		/// </summary>
		public Project Project { get; set; }

		//TODO: SetUp не очень прозрачная конструкция, т.к. всегда надо помнить, что она выполняется перед основным тестом
		//TODO: Корректнее будет сделать ПРИВАТНЫЕ свойства только на гет. Там где данные не должны меняться - их можно прописать
		//TODO: в приватные поля
		/// <summary>
		/// Инициализация тесируемого объекта
		/// </summary>
		[SetUp]
		public void InitProject()
		{
			Contacts = new Contact[]
			{
				//TODO: Duplication
				//TODO: Отступами в коде показать кто куда передаётся
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

		[Test(Description = "Позитивный тест геттера " +
			"индексатора")]
		public void TestIndexerGet_CorrectValue()
		{
			var expected = Contacts[0];
			var actual = Project[0];

			Assert.AreEqual(expected, actual,
				"Геттер возвращает неверный объект списка");
		}

		[Test(Description = "Позитивный тест геттера LastId")]
		public void TestLastIdGet_CorrectValue()
		{
			var expected = 4;
			var actual = Project.LastId;

			Assert.AreEqual(expected, actual, "Геттер LastId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест конструктора Project")]
		public void TestConstructor_CorrectValue()
		{
			Project project = new Project();

			var expectedLastId = 0;
			var actualLastId = project.LastId;
			Assert.AreEqual(expectedLastId, actualLastId,
				"Неверная инициализация LastId");

			var expectedContactsCount = 0;
			var actualContactsCount = project.GetContactsCount();
			Assert.AreEqual(expectedContactsCount, actualContactsCount,
				"Неверная инициализация списка контактов");
		}

		[Test(Description = "Позитивный тест метода GetNewId")]
		public void TestNewIdGet_CorrectValue()
		{
			var expected = 5;
			var actual = Project.GetNewId();

			Assert.AreEqual(expected, actual, "Метод GetNewId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест метода GetContactsCount")]
		public void TestGetContactsCount_CorrectValue()
		{
			var expected = ContactsCount;
			var actual = Project.GetContactsCount();

			Assert.AreEqual(expected, actual, "Функция GetContactsCount " +
				"возвращает неверное количество контактов в списке");
		}

		[Test(Description = "Позитивный тест метода AddContact")]
		public void TestAddContact_CorrectValue()
		{
			var expected = new Contact("Ivan", "Astahov", 
				new PhoneNumber(79991453321), "ivan@gmail.com", 
				new DateTime(1995, 6, 28));

			Project.AddContact(expected);

			var actual = Project[0];

			Assert.AreEqual(expected, actual, "Контакт не был добавлен " +
				"или добавлен на неверную позицию");
		}

		[Test(Description = "Негативный тест метода AddContact")]
		public void TestAddContact_IncorrectValue()
		{
			Assert.Throws<ArgumentException>(() =>
			{ Project.AddContact(null); }, "Должно генерироваться " +
			"исключение, если совершается попытка добавить в " +
			"список значения null");
		}

		[Test(Description = "Позитивный тест метода RemoveContact")]
		public void TestRemoveContact_CorrectValue()
		{
			Project.RemoveContact(Contacts[3]);

			Assert.Throws<ArgumentOutOfRangeException>(() =>
				{ Contact removedContact = Project[3]; },
				"Должно генерироваться исключение при обращении к " +
				"несуществующему элементу списка");
		}

		[Test(Description = "Негативный тест метода RemoveContact")]
		public void TestRemoveContact_IncorrectValue()
		{
			Assert.Throws<ArgumentException>(() =>
			{ Project.RemoveContact(null); },
				"Должно генерироваться исключение при попытке удалить " +
				"несуществующий элемент списка");
		}

		[Test(Description = "Позитивный тест метода GetContactsWithText")]
		public void TestGetContactsWithText_CorrectValue()
		{
			string text = "ев";

			var expected = new List<Contact>() { Contacts[1], Contacts[2] };
			var actual = Project.GetContactsWithText(text);

			Assert.AreEqual(expected[0], actual[0], "Метод вернул " +
				"некорректный список объектов");
			Assert.AreEqual(expected[1], actual[1], "Метод вернул " +
				"некорректный список объектов");
		}

		[Test(Description = "Позитивный тест метода GetAllBirthContacts")]
		public void TestGetAllBirthContacts_CorrectValue()
		{
			var expected = new List<Contact>() { Contacts[0], Contacts[3] };
			var actual = Project.GetAllBirthContacts();

			Assert.AreEqual(expected[0], actual[0], "Метод вернул " +
				"некорректный список объектов");
			Assert.AreEqual(expected[1], actual[1], "Метод вернул " +
				"некорректный список объектов");
		}

		[Test(Description = "Позитивный тест метода CompareTo")]
		public void TestCompareTo_CorrectValue()
		{
			int positiveExpectedResult = 1;
			int positiveActualResult = Project.CompareTo(Project);
			Assert.AreEqual(positiveExpectedResult, positiveActualResult,
				"Метод неверно сравнивает одинаковые объекты");

			Project project = new Project();
			int negativeExpectedResult = 0;
			int newgativeActualResult = Project.CompareTo(project);
			Assert.AreEqual(negativeExpectedResult, newgativeActualResult, 
				"Метод неверно сравнивает разные объекты");

			for(int i = 0; i < ContactsCount; i++)
			{
				project.AddContact(Contacts[0]);
			}
			int negativeExpectedResult2 = 0;
			int newgativeActualResult2 = Project.CompareTo(project);
			Assert.AreEqual(negativeExpectedResult2, newgativeActualResult2,
				"Метод неверно сравнивает разные объекты");
		}
	}
}
