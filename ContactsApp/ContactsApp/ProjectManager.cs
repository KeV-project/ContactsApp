using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ContactsApp
{
	/// <summary>
	/// Класс <see cref="ProjectManager"/> предназначен
	/// для организации сериализации и десериализации
	/// объектов класса "Проект"
	/// </summary>
	public static class ProjectManager
	{
		/// <summary>
		/// Хранит имя файла по умолчанию
		/// </summary>
		private const string DEFAULT_FILE_NAME = "ContactsApp.notes";

		/// <summary>
		/// Хранит путь к папке по умолчанию
		/// </summary>
		private static readonly string _defaultFolder = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\";

		/// <summary>
		/// Хранит текущий путь к папке для сериализации данных приложения
		/// </summary>
		private static string _folder = _defaultFolder;

		/// <summary>
		/// Возвращает и создает путь к папке для сериализации
		/// данных приложения
		/// </summary>
		private static string Folder
		{
			get
			{
				return _folder;
			}
			set
			{
				if (!Directory.Exists(value))
				{
					Directory.CreateDirectory(value);
				}
				_folder = value;
			}
		}

		/// <summary>
		/// Хранит текущее имя файла для сериализации данных приложения
		/// </summary>
		private static string _fileName = DEFAULT_FILE_NAME;

		/// <summary>
		/// Возвращает и создает файл для сериализации данных приложения
		/// </summary>
		private static string FileName
		{
			get
			{
				return _fileName;
			}
			set 
			{
				if (!File.Exists(_folder + value))
				{
					File.Create(_folder + value).Close();
				}
				_fileName = value;
			}
		}

		/// <summary>
		/// Возвращает и задает путь к файлу 
		/// для сериализации данных приложения
		/// </summary>
		private static string Path { get; set; } = _defaultFolder + DEFAULT_FILE_NAME;

		/// <summary>
		/// Устанавливает путь к файлу 
		/// </summary>
		/// <param name="folder">Путь к каталогу с файлом</param>
		/// <param name="fileName">Имя файла</param>
		public static void SetFile(string folder, string fileName)
		{
			try
			{
				Folder = folder;
				FileName = fileName;
				Path = folder + fileName;
			}
			catch
			{
				Folder = _defaultFolder;
				FileName = DEFAULT_FILE_NAME;
				Path = _defaultFolder + DEFAULT_FILE_NAME;
			}
		}

		/// <summary>
		/// Метод выполныет десериализацию объекта
		/// </summary>
		/// <returns>Десериализованный объект</returns>
		public static Project ReadProject()
		{
			if (!Directory.Exists(Folder))
			{
				Directory.CreateDirectory(Folder);
			}
			if (!File.Exists(Path))
			{
				File.Create(Path).Close();
			}

			Project project = new Project();

			using (StreamReader file = new StreamReader(
					Path, Encoding.Default))
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

		/// <summary>
		/// Метод выполняет сериализацию объекта
		/// </summary>
		/// <param name="project">Сериализуемый объект</param>
		public static void SaveProject(Project project)
		{
			if (!Directory.Exists(Folder))
			{
				Directory.CreateDirectory(Folder);
			}
			if (!File.Exists(Path))
			{
				File.Create(Path).Close();
			}

			using (StreamWriter file = new StreamWriter(
                Path, false, Encoding.UTF8))
			{ 
                file.Write(JsonConvert.SerializeObject(project));
            }
        }
	}
}
