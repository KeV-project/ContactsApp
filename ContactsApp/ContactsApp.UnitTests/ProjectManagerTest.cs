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
		/// Возвращает массив имен файлов для
		/// сериализации и десериализации объектов
		/// класса <see cref="Project">
		/// </summary>
		private FileInfo[] Path
		{
			get
			{
			FileInfo[] path = new FileInfo[POSITIVE_TESTS_COUNT]
				{
					new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\Contacts1\\" + "file1.notes"),
					new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\Contacts2\\" + "file2.notes"),
					new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\Contacts2\\" + "file2.notes")
				};

				if(!path[0].Directory.Exists)
				{
					path[0].Directory.Create();
				}

				if (!path[1].Directory.Exists)
				{
					path[1].Directory.Create();
					if(!path[1].Exists)
					{
						path[1].Create().Close();
					}
				}

				return path;
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
				Contact[] contacts = new Contact[]
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

				for(int i = 0; i < contacts.Length; i++)
				{
					contacts[i].Id = i + 1;
				}

				return contacts;
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
				for (int i = 0; i < Contacts.Length; i++)
				{
					project.AddContact(Contacts[i]);
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
				ProjectManager.SaveProject(expected, Path[i]);
				var actual = ProjectManager.ReadProject(Path[i]);

				// assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, "Искажение данных при сериализации объекта");

				Path[i].Delete();
				Path[i].Directory.Delete();
			}
		}

		[Test(Description = "Негативный тест метода SaveProject")]
		public void TestSaveProject_InCorrectValue()
		{
			// arrange
			FileInfo wrongFileName = new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\Contacts1\\" + "                                    ");

			FileInfo wrongPath = new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\                          \\" + "file.notes");

			// assert
			Assert.Throws<Exception>(() =>
			{
				ProjectManager.SaveProject(Project, wrongFileName);
			}, "Должно возникать исключение, если " +
				"не удается создать файл с указанным именем");

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.SaveProject(Project, wrongPath);
			}, "Должно возникать исключение, если " +
				"не удается создать каталог по указанному пути");

			//TODO: Duplication +
			Path[0].Delete();
			for (int i = 0; i < POSITIVE_TESTS_COUNT - 1; i++)
			{
				Path[i].Directory.Delete();
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
					ReadProject(Path[i]);

				// assert
				var resultEmptyProject = Convert.
					ToBoolean(expectedEmptyProject.
					CompareTo(actualEmptyProject));
				Assert.IsTrue(resultEmptyProject,
					"Искажение данных при десериализации объекта");

				// arrange
				var expectedProject = Project;
				ProjectManager.SaveProject(expectedProject,
					Path[i]);

				// act
				var actualProject = ProjectManager.
					ReadProject(Path[i]);

				// assert
				var resultProject = Convert.ToBoolean(
					expectedProject.CompareTo(actualProject));
				Assert.IsTrue(resultProject,
					"Искажение данных при десериализации объекта");

				Path[i].Delete();
				Path[i].Directory.Delete();
			}
		}

		[Test(Description = "Негативный тест ReadProject")]
		public void TestReadProject_IncorrectValue()
		{
			// arrange
			FileInfo wrongFileName = new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\Contacts1\\" + "                                    ");

			FileInfo wrongPath = new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\                          \\" + "file.notes");

			// assert
			Assert.Throws<Exception>(() =>
			{
				ProjectManager.ReadProject(wrongPath);
			}, "Должно возникать исключение, если " +
				"не удается создать каталог по указанному пути");

			Assert.Throws<Exception>(() =>
			{
				ProjectManager.ReadProject(wrongFileName);
			}, "Должно возникать исключение, если " +
				"не удается создать файл с указанным именем");

			//TODO: Duplication +
			Path[0].Delete();
			for (int i = 0; i < POSITIVE_TESTS_COUNT - 1; i++)
			{
				Path[i].Directory.Delete();
			}
		}
	}
}
