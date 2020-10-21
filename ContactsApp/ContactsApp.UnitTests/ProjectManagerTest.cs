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
					"\\ContactsApp1\\" + "file1.notes"),
					new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\ContactsApp2\\" + "file2.notes"),
					new FileInfo(Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData) +
					"\\ContactsApp3\\" + "file3.notes")
					};

				path[0].Directory.Create();
				path[0].Create().Close();
				path[1].Directory.Create();
				
				return path;
			}
		}

		/// <summary>
		/// Возвращает массив контактов для заполнения списка контактов
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
					new DateTime(2001, 10, 5)),

					new Contact("Светлана", "Абитаева",
					new PhoneNumber(75564856412), "abitaeva@gmail.com",
					new DateTime(1995, 4, 3)),

					new Contact("Генадий", "Афанасьев",
					new PhoneNumber(79994567842), "gena@gmail.com",
					new DateTime(1990, 10, 25)),

					new Contact("Мария", "Стрельникова",
					new PhoneNumber(75564856412), "maria@gmail.com",
					new DateTime(1999, 4, 15))
				};

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
			// arrange
			FileInfo[] path = Path;
			var expected = Project;

			//TODO: А какой смысл в этих тестах, если они однообразные и по факту тестируют одно и тоже?
			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				// act
				ProjectManager.SaveProject(expected, path[i]);
				var actual = ProjectManager.ReadProject(path[i]);

				// assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, "Искажение данных при сериализации объекта");

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}

		[Test(Description = "Позитивный тест ReadProject")]
		public void TestReadProject_CorrectValue()
		{
			// arrange
			FileInfo[] path = Path;
			var expectedEmptyProject = new Project();
			var expectedProject = Project;

			//TODO: А какой смысл в этих тестах, если они однообразные и по факту тестируют одно и тоже?
			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				
				// act
				var actualEmptyProject = ProjectManager.
					ReadProject(path[i]);

				// assert
				var resultEmptyProject = Convert.
					ToBoolean(expectedEmptyProject.
					CompareTo(actualEmptyProject));
				Assert.IsTrue(resultEmptyProject,
					"Искажение данных при десериализации объекта");

				// arrange
				ProjectManager.SaveProject(expectedProject,
					path[i]);

				// act
				var actualProject = ProjectManager.
					ReadProject(path[i]);

				// assert
				var resultProject = Convert.ToBoolean(
					expectedProject.CompareTo(actualProject));
				Assert.IsTrue(resultProject,
					"Искажение данных при десериализации объекта");

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}
	}
}
