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
	/// для тестирования класса <see cref="ProjectManager"/>
	/// </summary>
	class ProjectManagerTest
	{
		//TODO: SetUp не очень прозрачная конструкция, т.к. всегда надо помнить, что она выполняется перед основным тестом
		//TODO: Корректнее будет сделать ПРИВАТНЫЕ свойства только на гет. Там где данные не должны меняться - их можно прописать
		//TODO: в приватные поля +

		// При передаче корректного пути к файлу предназначенного
		// для сериализации и десериализации объекта класса Project
		// в методы SaveProject и ReadProject возможны 3 варианта
		// развития событий:
		// 1. Указанный файл был создан заранее
		// 2. Каталог по указанному пути существует,
		//    а файл требуется создать
		// 3. Требуется создать каталог по указанному пути
		//    и файл для сериализации в данном каталоге

		/// <summary>
		/// Количество корректных путей выполнения методов 
		/// ReadProject и SaveProject в зависимости от наличия 
		/// каталога и файла для сериализации объекта
		/// класса <see cref="ProjectManager"/>
		/// </summary>
		private const int POSITIVE_TESTS_COUNT = 3;

		/// <summary>
		/// Возвращает массив путей к каталогам,
		/// в которых предполагается наличие файла
		/// для сериализации и десериализации объекта
		/// класса <see cref=Project"">
		/// </summary>
		private string[] Folders
		{
			get
			{
				string[] folders = new string[POSITIVE_TESTS_COUNT]
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
				Directory.CreateDirectory(folders[0]);
				Directory.CreateDirectory(folders[1]);
				return folders;
			}
		}

		/// <summary>
		/// Возвращает массив имен файлов для
		/// сериализации и десериализации объектов
		/// класса <see cref="Project">
		/// </summary>
		private string[] FileNames
		{
			get
			{
				string[] fileNames = new string[POSITIVE_TESTS_COUNT]
				{
					"file1.notes",
					"file2.notes",
					"file3.notes"
				};
				File.Create(Folders[0] + fileNames[0]).Close();
				return fileNames;
			}
		}

		/// <summary>
		/// Массив контактов для заполнения списка контактов
		/// объекта класса <see cref="Project">
		/// </summary>
		private Contact[] Contacts
		{
			get
			{
				return new Contact[]
					{
						//TODO: Duplication
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
		/// Количество элементов в массиве контактов
		/// </summary>
		private int ContactsCount
		{
			get
			{
				return 4;
			}
		}

		/// <summary>
		/// Объект для тестирования класса <see cref="ProjectManagerTest"/>
		/// </summary>
		private Project Project
		{
			get
			{
				Project project = new Project();
				for (int i = 0; i < ContactsCount; i++)
				{
					Project.AddContact(Contacts[i]);
					Contacts[i].Id = i + 1;
				}
				return project;
			}
		}


		[Test(Description = "Позитивнынй тест SaveProject")]
		public void TestSaveProject_CorrectValue()
		{
			//TODO: А какой смысл в этих тестах, если они однообразные и по факту тестируют одно и тоже?
			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				// arrange
				var expected = Project;

				// act
				ProjectManager.SaveProject(expected, Folders[i], FileNames[i]);
				var actual = ProjectManager.ReadProject(Folders[i], FileNames[i]);

				// assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, "Искажение данных при сериализации объекта");

				File.Delete(Folders[i] + FileNames[i]);
				Directory.Delete(Folders[i]);
			}
		}

		[Test(Description = "Негативный тест метода SaveProject")]
		public void TestSaveProject_InCorrectValue()
		{
			// arrange
			string fileName = FileNames[2];
			string folder = Folders[2];

			string wrongFileName = "                         ";
			string wrongFolder = "                           ";

			// assert
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

			//TODO: Duplication +
			File.Delete(Folders[0] + FileNames[0]);
			for(int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				Directory.Delete(Folders[i]);
			}
		}

		[Test(Description = "Позитивный тест ReadProject")]
		public void TestReadProject_CorrectValue()
		{
			//TODO: А какой смысл в этих тестах, если они однообразные и по факту тестируют одно и тоже?
			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				// arrange
				var expectedEmptyProject = new Project();

				// act
				var actualEmptyProject = ProjectManager.
					ReadProject(Folders[i], FileNames[i]);

				// assert
				var resultEmptyProject = Convert.
					ToBoolean(expectedEmptyProject.
					CompareTo(actualEmptyProject));
				Assert.IsTrue(resultEmptyProject,
					"Искажение данных при десериализации объекта");

				// arrange
				var expectedProject = Project;
				ProjectManager.SaveProject(expectedProject,
					Folders[i], FileNames[i]);

				// act
				var actualProject = ProjectManager.
					ReadProject(Folders[i], FileNames[i]);

				// assert
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
			// arrange
			string fileName = FileNames[2];
			string folder = Folders[2];

			string wrongFileName = "                         ";
			string wrongFolder = "                           ";

			// assert
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

			//TODO: Duplication +
			File.Delete(Folders[0] + FileNames[0]);
			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				Directory.Delete(Folders[i]);
			}
		}
	}
}
