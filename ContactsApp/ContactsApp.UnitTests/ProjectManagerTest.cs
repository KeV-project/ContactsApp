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
                //TODO: Отступы +
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

		[Test(Description = "Позитивнынй тест SaveProject")]
		public void TestSaveProject_CorrectValue()
		{
			// arrange
			FileInfo[] path = Path;
			var expected = InitProject.Project;

			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				// act
				ProjectManager.SaveProject(expected, path[i]);
				var actual = ProjectManager.ReadProject(path[i]);

				// assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, 
					"Искажение данных при сериализации объекта");

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}
		//TODO: Почему два тестовых случая собраны в одном тесте? +
		[Test(Description = 
			"Позитивный тест ReadProject (чтение пустого файла)")]
		public void TestReadProject_EmptyFile()
		{
			// arrange
			FileInfo[] path = Path;
			var expected = new Project();

			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
                // act
				var actual = ProjectManager.
					ReadProject(path[i]);

				// assert
				var result = Convert.ToBoolean(expected.
					CompareTo(actual));
				Assert.IsTrue(result,
					"Искажение данных при десериализации объекта");

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}

		[Test(Description = 
			"Позитивный тест ReadProject (чтение проекта из файла)")]
		public void TestReadProject_ReadProject()
		{
			// arrange
			FileInfo[] path = Path;
			var expected = InitProject.Project;

			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
				// arrange
				ProjectManager.SaveProject(expected, path[i]);

				// act
				var actual = ProjectManager.ReadProject(path[i]);

				// assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, "Искажение данных " +
					"при десериализации объекта");

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}
	}
}
