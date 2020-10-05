using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ContactsApp
{
	/// <summary>
	/// Класс "Управление проектом" предназначен
	/// для организации сериализации и десериализации
	/// объектов класса "Проект"
	/// </summary>
	public static class ProjectManager
	{
		/// <summary>
		/// Поле "Имя файла" хранит имя файла,
		/// в который будет выполняться сохранение объектов
		/// </summary>
		private const string FILE_NAME = "ContactsApp.notes";
		/// <summary>
		/// Поле "Папка" хранит путь к каталогу,
		/// выполняющего функции общего репозитория
		/// для данных приложения текущего перемещающегося пользователя,
		/// в котором будет создан каталог ContactsApp
		/// </summary>
		private static readonly string _folder = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\";
		/// <summary>
		/// Поле "Путь" хранит абсолютный путь к файлу,
		/// в который будет выполняться сохранение объектов
		/// </summary>
		private static readonly string _path = _folder + FILE_NAME;

		/// <summary>
		/// Создает объект класса ProjectManager
		/// и файл для сериализации
		/// </summary>
		static ProjectManager()
		{
			if (!Directory.Exists(_folder))
			{
				Directory.CreateDirectory(_folder);
			}
			if (!File.Exists(_path))
			{
				File.Create(_path).Close();
			}
		}

		/// <summary>
		/// Метод выполняет сериализацию объекта
		/// </summary>
		/// <param name="project">Сериализуемый объект</param>
		public static void SaveProject(Project project)
		{
            using (StreamWriter file = new StreamWriter(
                _path, false, Encoding.UTF8))
			{ 
                file.Write(JsonConvert.SerializeObject(project));
            }
        }

		/// <summary>
		/// Метод выполныет десериализацию объекта
		/// </summary>
		/// <returns>Десериализованный объект</returns>
		public static Project ReadProject()
		{
			Project project = new Project();

			if (!File.Exists(_path))
			{
				return project;
			}

			using (StreamReader file = new StreamReader(
					_path, Encoding.Default))
			{
				string projectContent = file.ReadLine();
				if (string.IsNullOrEmpty(projectContent))
				{
					return project;
				}

				project = JsonConvert.DeserializeObject<Project>(projectContent);
			}

			return project;
		}

	}
}
