using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;
using System.IO;

namespace ContactsApp.UnitTests
{
	/// <summary>
	/// Класс <see cref="ProjectManagerTest"/> предназначен
	/// дла тестирования класса <see cref="ProjectManager"/>
	/// </summary>
	class ProjectManagerTest
	{
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
		}

		[Test(Description = "Позитивный тест SetFile")]
		public void TestSetFile_CorrectValue()
		{
			string folder = Environment.GetLogicalDrives()[0];
			string fileName = "ContactsApp.notes";
			string path = folder + fileName;
			ProjectManager.SetFile(folder, fileName);
			if(!File.Exists(path))
			{
				throw new Exception("Файл не был создан");
			}
			File.Delete(path);
		}

		[Test(Description = "Негативный тест SetFile")]
		public void TestSetFile_IncorrectValue()
		{
			string wrongFolder = "";
			string wrongFileName = "";
			string path = wrongFolder + wrongFileName;
			ProjectManager.SetFile(wrongFolder, wrongFileName);
			string defaultPath = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\" + "ContactsApp.notes";
			if (!File.Exists(defaultPath))
			{
				throw new Exception("Файл не былл создан");
			}
			File.Delete(defaultPath);
		}

		[Test(Description = "Позитивный тест метода SaveProject")]
		public void TestSaveProject_CorrectValue()
		{
			string fileName = "ContactsApp.notes";
			string folder = Environment.GetLogicalDrives()[0];
			string path = folder + fileName;
			ProjectManager.SetFile(folder, fileName);

			if (!Directory.Exists(folder))
			{
				throw new Exception("Указанный каталог не существует");
			}

			if (!File.Exists(path))
			{
				throw new Exception("Файл не был создан");
			}

			var expected = Project;

			ProjectManager.SaveProject(expected);

			var actual = ProjectManager.ReadProject();

			var result = Convert.ToBoolean(expected.CompareTo(actual));
			Assert.IsTrue(result, "Потеря данных при сериализации объекта");
			File.Delete(path);
		}

		[Test(Description = "Позитивный тест ReadProject")]
		public void TestReadProject_CorrectValue()
		{
			string fileName = "ContactsApp.notes";
			string folder = Environment.GetLogicalDrives()[0];
			string path = folder + fileName;
			ProjectManager.SetFile(folder, fileName);

			if (!Directory.Exists(folder))
			{
				throw new Exception("Указанный каталог не существует");
			}

			if (!File.Exists(path))
			{
				throw new Exception("Файл не был создан");
			}

			Project expected = new Project();
			ProjectManager.SaveProject(expected);
			Project actual = ProjectManager.ReadProject();
			var result = Convert.ToBoolean(expected.CompareTo(actual));
			Assert.IsTrue(result, "Десериализация выполнена некорректно");

			expected = Project;
			ProjectManager.SaveProject(expected);
			actual = ProjectManager.ReadProject();
			var result2 = Convert.ToBoolean(expected.CompareTo(actual));
			Assert.IsTrue(result, "Потеря данных при десериализации объекта");

			File.Delete(path);
		}
	}
}
