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
		private static FileInfo[] Path
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

		//TODO: Обратите внимание - что я тут сделал, потом могу ответить на вопросы
		[TestCaseSource(nameof(ProjectManagerTestData))]
		public void TestSaveProject_CorrectValue(
            Func<(FileInfo[], Project)> initFunc,
			Action<Project, FileInfo> arrangeAction, 
            string assertMessage)
		{
			// arrange
			(FileInfo[] path, Project expected) = initFunc.Invoke();

			for (int i = 0; i < POSITIVE_TESTS_COUNT; i++)
			{
                // act
				arrangeAction.Invoke(expected, path[i]);

				var actual = ProjectManager.ReadProject(path[i]);

                // assert
				var result = Convert.ToBoolean(expected.CompareTo(actual));
				Assert.IsTrue(result, assertMessage);

				path[i].Delete();
				path[i].Directory.Delete();
			}
		}

        private static IEnumerable<TestCaseData> ProjectManagerTestData
        {
            get
            {	
                var initFunc1 = new Func<(FileInfo[], Project)> (
                    () => (Path, InitProject.Project));
                var initFunc2 = new Func<(FileInfo[], Project)>(
                    () => (Path, new Project()));
				var arrangeAction = new Action<Project, FileInfo>(
                        ProjectManager.SaveProject);
                var arrangeEmpty = new Action<Project, FileInfo>(
                    (project, info) => { });
                var serializationMessage = 
                    "Искажение данных при сериализации объекта";
                var deserializationMessage =
                    "Искажение данных при десериализации объекта";

				yield return new TestCaseData(initFunc1, arrangeAction, serializationMessage)
                    .SetName("Позитивнынй тест SaveProject");
                yield return new TestCaseData(initFunc2, arrangeEmpty, deserializationMessage)
                    .SetName("Позитивный тест ReadProject (чтение пустого файла)");
                yield return new TestCaseData(initFunc1, arrangeAction, deserializationMessage)
                    .SetName("Позитивный тест ReadProject (чтение проекта из файла)");
            }
        }
	}
}
