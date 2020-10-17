using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;
using System.IO;
using Microsoft.SqlServer.Server;

namespace ContactsApp.UnitTests
{
	/// <summary>
	/// Класс <see cref="ProjectManagerTest"/> предназначен
	/// дла тестирования класса <see cref="ProjectManager"/>
	/// </summary>
	class ProjectManagerTest
	{
		public const int TESTS_COUNT = 3;
		public string[] Folders { get; set; }
		public string[] FileNames { get; set; }
		/// <summary>
		/// Количество элементов в массиве контактов
		/// </summary>
		private int ContactsCount { get; set; }
		/// <summary>
		/// Массив контактов объекта тестирования 
		/// </summary>
		public Contact[] Contacts { get; set; }
		/// <summary>
		/// Объект для тестирования класса <see cref="ProjectManagerTest"/>
		/// </summary>
		public Project Project { get; set; }

		/// <summary>
		/// Инициализация объекта для тестирования
		/// </summary>
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

			Folders = new string[TESTS_COUNT]
			{
				Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
				"\\Contacts1\\",
				Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
				"\\Contacts2\\",
				Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
				"\\Contacts3\\"
			};

			FileNames = new string[TESTS_COUNT]
			{
				"file1.notes",
				"file2.notes",
				"file3.notes"
			};

			Directory.CreateDirectory(Folders[0]);
			File.Create(Folders[0] + FileNames[0]).Close();
			Directory.CreateDirectory(Folders[1]);
		}

		[Test(Description = "Позитивнынй тест SaveProject")]
		public void TestSaveProject_CorrectValue()
		{
			for(int i = 0; i < TESTS_COUNT; i++)
			{
				var expected = Project;

				ProjectManager.SaveProject(expected, Folders[i], FileNames[i]);

				var actual = ProjectManager.ReadProject(Folders[i], FileNames[i]);

				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, "Искажение данных при сериализации объекта");

				File.Delete(Folders[i] + FileNames[i]);
				Directory.Delete(Folders[i]);
			}
		}

		[Test(Description = "Негативный тест метода SaveProject")]
		public void TestSaveProject_InCorrectValue()
		{
			string fileName = FileNames[2];
			string folder = Folders[2];

			string wrongFileName = "                         ";
			string wrongFolder = "                           ";

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.SaveProject(Project, wrongFolder, fileName);
			}, "Должно возникать исключение, если " +
				"не удается создать каталог по указанному пути");

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.SaveProject(Project, folder, wrongFileName);
			}, "Должно возникать исключение, если " +
				"не удается создать файл с указанным именем");

			File.Delete(Folders[0] + FileNames[0]);
			Directory.Delete(Folders[0]);
			Directory.Delete(Folders[1]);
			Directory.Delete(Folders[2]);
		}

		[Test(Description = "Позитивный тест ReadProject")]
		public void TestReadProject_CorrectValue()
		{
			for (int i = 0; i < TESTS_COUNT; i++)
			{
				var expectedEmptyProject = new Project();
				var actualEmptyProject = ProjectManager.
					ReadProject(Folders[i], FileNames[i]);
				var resultEmptyProject = Convert.
					ToBoolean(expectedEmptyProject.
					CompareTo(actualEmptyProject));
				Assert.IsTrue(resultEmptyProject, 
					"Искажение данных при десериализации объекта");

				var expectedProject = Project;
				ProjectManager.SaveProject(expectedProject, 
					Folders[i], FileNames[i]);
				var actualProject = ProjectManager.
					ReadProject(Folders[i], FileNames[i]);
				var resultProject = Convert.ToBoolean(
					expectedProject.CompareTo(actualProject));
				Assert.IsTrue(resultProject, 
					"Искажение данных при десериализации объекта");

				File.Delete(Folders[i] + FileNames[i]);
				Directory.Delete(Folders[i]);
			}
		}

		[Test(Description = "Негативный тест ReadProject")]
		public void TestReadProject_IncorrectValue()
		{
			string fileName = FileNames[2];
			string folder = Folders[2];

			string wrongFileName = "                         ";
			string wrongFolder = "                           ";

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.ReadProject(wrongFolder, fileName);
			}, "Должно возникать исключение, если " +
				"не удается создать каталог по указанному пути");

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.ReadProject(folder, wrongFileName);
			}, "Должно возникать исключение, если " +
				"не удается создать файл с указанным именем");

			File.Delete(Folders[0] + FileNames[0]);
			Directory.Delete(Folders[0]);
			Directory.Delete(Folders[1]);
			Directory.Delete(Folders[2]);
		}
	}
}
