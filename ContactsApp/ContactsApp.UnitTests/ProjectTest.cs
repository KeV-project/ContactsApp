﻿using System;
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
		//TODO: SetUp не очень прозрачная конструкция, т.к. всегда надо помнить, что она выполняется перед основным тестом
		//TODO: Корректнее будет сделать ПРИВАТНЫЕ свойства только на гет. Там где данные не должны меняться - их можно прописать
		//TODO: в приватные поля +

		/// <summary>
		/// Возвращает массив контактов
		/// </summary>
		private Contact[] Contacts 
		{ 
			get
			{
				return new Contact[]
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
			}
		}

		/// <summary>
		/// Возвращает количество контактов в массиве
		/// </summary>
		private int ContactsCount
		{
			get
			{
				return 4;
			}
		}

		/// <summary>
		/// Возвращает объект для тестирования
		/// </summary>
		private Project Project
		{
			get
			{
				Project project = new Project();
				for (int i = 0; i < ContactsCount; i++)
				{
					project.AddContact(Contacts[i]);
					Contacts[i].Id = i + 1;
				}
				return project;
			}
		}

		

		[Test(Description = "Позитивный тест геттера " +
			"индексатора")]
		public void TestIndexerGet_CorrectValue()
		{
			// arrange
			var expected = Contacts[0];

			// act
			var actual = Project[0];

			// assert
			Assert.AreEqual(expected, actual,
				"Геттер возвращает неверный объект списка");
		}

		[Test(Description = "Позитивный тест геттера LastId")]
		public void TestLastIdGet_CorrectValue()
		{
			// arrange
			var expected = 4;

			// act
			var actual = Project.LastId;

			// assert
			Assert.AreEqual(expected, actual, "Геттер LastId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест конструктора Project")]
		public void TestConstructor_CorrectValue()
		{
			// arrange
			Project project = new Project();
			var expectedLastId = 0;
			var expectedContactsCount = 0;

			// act
			var actualLastId = project.LastId;
			var actualContactsCount = project.GetContactsCount();

			// assert
			Assert.AreEqual(expectedLastId, actualLastId,
				"Неверная инициализация LastId");

			Assert.AreEqual(expectedContactsCount, actualContactsCount,
				"Неверная инициализация списка контактов");
		}

		[Test(Description = "Позитивный тест метода GetNewId")]
		public void TestNewIdGet_CorrectValue()
		{
			// arrange
			var expected = 5;

			// act
			var actual = Project.GetNewId();

			// assert
			Assert.AreEqual(expected, actual, "Метод GetNewId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест метода GetContactsCount")]
		public void TestGetContactsCount_CorrectValue()
		{
			// arrange
			var expected = ContactsCount;

			// act
			var actual = Project.GetContactsCount();

			// assert
			Assert.AreEqual(expected, actual, "Функция GetContactsCount " +
				"возвращает неверное количество контактов в списке");
		}

		[Test(Description = "Позитивный тест метода AddContact")]
		public void TestAddContact_CorrectValue()
		{
			// arrange
			var expected = new Contact("Ivan", "Astahov", 
				new PhoneNumber(79991453321), "ivan@gmail.com", 
				new DateTime(1995, 6, 28));

			// act
			Project.AddContact(expected);
			var actual = Project[0];

			// assert
			Assert.AreEqual(expected, actual, "Контакт не был добавлен " +
				"или добавлен на неверную позицию");
		}

		[Test(Description = "Негативный тест метода AddContact")]
		public void TestAddContact_IncorrectValue()
		{
			// assert
			Assert.Throws<ArgumentException>(() =>
			{ Project.AddContact(null); }, "Должно генерироваться " +
			"исключение, если совершается попытка добавить в " +
			"список значения null");
		}

		[Test(Description = "Позитивный тест метода RemoveContact")]
		public void TestRemoveContact_CorrectValue()
		{
			// act
			Project.RemoveContact(Contacts[3]);

			// assert
			Assert.Throws<ArgumentOutOfRangeException>(() =>
				{ Contact removedContact = Project[3]; },
				"Должно генерироваться исключение при обращении к " +
				"несуществующему элементу списка");
		}

		[Test(Description = "Негативный тест метода RemoveContact")]
		public void TestRemoveContact_IncorrectValue()
		{
			// assert
			Assert.Throws<ArgumentException>(() =>
			{ Project.RemoveContact(null); },
				"Должно генерироваться исключение при попытке удалить " +
				"несуществующий элемент списка");
		}

		[Test(Description = "Позитивный тест метода GetContactsWithText")]
		public void TestGetContactsWithText_CorrectValue()
		{
			// arrange
			string text = "ев";
			var expected = new List<Contact>() { Contacts[1], Contacts[2] };

			// act
			var actual = Project.GetContactsWithText(text);

			// assert
			Assert.IsTrue(actual.Count == expected.Count, "Метод вернул " +
				"список неверной длины ");
			Assert.AreEqual(expected[0], actual[0], "Метод вернул " +
				"некорректный список объектов");
			Assert.AreEqual(expected[1], actual[1], "Метод вернул " +
				"некорректный список объектов");
		}

		[Test(Description = "Позитивный тест метода GetAllBirthContacts")]
		public void TestGetAllBirthContacts_CorrectValue()
		{
			// arrange
			var expected = new List<Contact>() { Contacts[0], Contacts[3] };

			// act
			var actual = Project.GetAllBirthContacts();

			// assert
			Assert.IsTrue(actual.Count == expected.Count, "Метод вернул " +
				"список неверной длины");
			Assert.AreEqual(expected[0], actual[0], "Метод вернул " +
				"некорректный список объектов");
			Assert.AreEqual(expected[1], actual[1], "Метод вернул " +
				"некорректный список объектов");
		}

		[Test(Description = "Позитивный тест метода CompareTo")]
		public void TestCompareTo_CorrectValue()
		{
			// arrange
			int positiveExpectedResult = 1;
			// act
			int positiveActualResult = Project.CompareTo(Project);
			// assert
			Assert.AreEqual(positiveExpectedResult, positiveActualResult,
				"Метод неверно сравнивает одинаковые объекты");

			// arrange
			Project project = new Project();
			int negativeExpectedResult = 0;
			// act
			int newgativeActualResult = Project.CompareTo(project);
			// assert
			Assert.AreEqual(negativeExpectedResult, newgativeActualResult, 
				"Метод неверно сравнивает разные объекты");

			// arrange
			for (int i = 0; i < ContactsCount; i++)
			{
				project.AddContact(Contacts[0]);
			}
			int negativeExpectedResult2 = 0;
			// act
			int newgativeActualResult2 = Project.CompareTo(project);
			// assert
			Assert.AreEqual(negativeExpectedResult2, newgativeActualResult2,
				"Метод неверно сравнивает разные объекты");
		}
	}
}
