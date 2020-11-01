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
		[Test(Description = "Позитивный тест геттера " +
			"индексатора")]
		public void TestIndexerGet_CorrectValue()
		{
			// arrange
			var expected = InitProject.Contacts[0];

			// act
			var actual = InitProject.Project[0];

			// assert
			Assert.AreEqual(expected.FirstName, actual.FirstName,
				"Геттер возвращает объект с неверным именем");
			Assert.AreEqual(expected.LastName, actual.LastName,
				"Геттер возвращает объект с неверной фамилией");
			Assert.AreEqual(expected.Number.Number, actual.Number.Number,
				"Геттер возвращает объект с неверным номером телефона");
			Assert.AreEqual(expected.Email, actual.Email,
				"Геттер возвращает объект с неверным адресом " +
				"электронной почнты");
			Assert.AreEqual(expected.BirthDate, actual.BirthDate,
				"Геттер возвращает объект с неверной датой рождения");
		}

		[Test(Description = "Позитивный тест геттера LastId")]
		public void TestLastIdGet_CorrectValue()
		{
			// arrange
			var expected = 4;

			// act
			var actual = InitProject.Project.LastId;

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
			var actual = InitProject.Project.GetNewId();

			// assert
			Assert.AreEqual(expected, actual, "Метод GetNewId " +
				"возвращает неверное значение");
		}

		[Test(Description = "Позитивный тест метода GetContactsCount")]
		public void TestGetContactsCount_CorrectValue()
		{
			// arrange
			var expected = InitProject.Contacts.Length;

			// act
			var actual = InitProject.Project.GetContactsCount();

			// assert
			Assert.AreEqual(expected, actual, "Функция GetContactsCount " +
				"возвращает неверное количество контактов в списке");
		}

		[Test(Description = "Позитивный тест метода AddContact")]
		public void TestAddContact_CorrectValue()
		{
			// arrange
			Project project = InitProject.Project;
			var expected = new Contact("Ivan", "Astahov", 
				new PhoneNumber(79991453321), "ivan@gmail.com", 
				new DateTime(1995, 6, 28));
			
			// act
			project.AddContact(expected);
			var actual = project[0];

			// assert
			Assert.AreEqual(expected, actual,
				"Контакт не был добавлен " +
				"или добавлен на неверную позицию");
		}

		[Test(Description = "Негативный тест метода AddContact")]
		public void TestAddContact_IncorrectValue()
		{
			// assert
			Assert.Throws<ArgumentException>(() =>
			{ 
				InitProject.Project.AddContact(null); 
			}, "Должно генерироваться " +
			"исключение, если совершается попытка добавить в " +
			"список значения null");
		}

		[Test(Description = "Позитивный тест метода RemoveContact")]
		public void TestRemoveContact_CorrectValue()
		{
			// arrange
			Project project = InitProject.Project;

			// act
			project.RemoveContact(project[3]);

            //TODO: Скобочки на разных строках +
			// assert
			Assert.Throws<ArgumentOutOfRangeException>(() =>
			{ 
				Contact removedContact = project[3]; 
			}, "Должно генерироваться исключение при обращении к " +
			"несуществующему элементу списка");
		}

		[Test(Description = "Негативный тест метода RemoveContact")]
		public void TestRemoveContact_IncorrectValue()
		{
            //TODO: Скобочки на разных строках +
			// assert
			Assert.Throws<ArgumentException>(() =>
			{ 
				InitProject.Project.RemoveContact(null); 
			}, "Должно генерироваться исключение при попытке удалить " +
			"несуществующий элемент списка");
		}

		[Test(Description = "Позитивный тест метода GetContactsWithText")]
		public void TestGetContactsWithText_CorrectValue()
		{
			// arrange
			Project project = InitProject.Project;
            //TODO: Скобочки на разных строках +
			var expected = new List<Contact>() 
			{ 
				project[1], 
				project[2] 
			};
			string text = "ев";

			// act
			var actual = project.GetContactsWithText(text);

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
			Project project = InitProject.Project;
            //TODO: Скобочки на разных строках +
			var expected = new List<Contact>() 
			{ 
				project[0], 
				project[3] 
			};

			// act
			var actual = project.GetAllBirthContacts();

			// assert
			Assert.IsTrue(actual.Count == expected.Count, "Метод вернул " +
				"список неверной длины");
			Assert.AreEqual(expected[0], actual[0], "Метод вернул " +
				"некорректный список объектов");
			Assert.AreEqual(expected[1], actual[1], "Метод вернул " +
				"некорректный список объектов");
		}

		//TODO: Почему три разных тестовых случая собраны в одном тесте? +
		[Test(Description = "Позитивный тест метода CompareTo")]
		public void TestCompareTo_CorrectValue()
		{
			// arrange
			int expectedResult = 1;

			// act
			int actualResult = InitProject.Project.
				CompareTo(InitProject.Project);

			// assert
			Assert.AreEqual(expectedResult, actualResult,
				"Метод неверно сравнивает одинаковые объекты");
		}

		[Test(Description = "Негативный тест метода CompareTo " +
			"(проекты содержат список контактов разной длины)")]
		public void TestCompareTo_DifferentListsLenght()
		{
			// arrange
			int expectedResult = 0;
			Project project = new Project();

			// act
			int actualResult = InitProject.Project.CompareTo(project);

			// assert
			Assert.AreEqual(expectedResult, actualResult,
				"Метод неверно сравнивает разные объекты");
		}

		[Test(Description = "Негативный тест метода CompareTo " +
			"(списки контактов различны, но одинаковы по длине)")]
		public void TestCompareTo_IncorrectValue()
		{
			// arrange
			int expectedResult = 0;
			Project project = new Project();
			for (int i = 0; i < InitProject.Contacts.Length; i++)
			{
				project.AddContact(InitProject.Contacts[0]);
			}

			// act
			int actualResult = InitProject.Project.CompareTo(project);

			// assert
			Assert.AreEqual(expectedResult, actualResult,
				"Метод неверно сравнивает разные объекты");
		}
	}
}
