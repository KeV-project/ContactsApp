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
	/// объектов класса <see cref="Project">
	/// </summary>
	public static class ProjectManager
	{
		/// <summary>
		/// Метод предназначен для создания файла в указанном каталоге
		/// для сериализации и десериализации данных приложения
		/// </summary>
		/// <param name="folder">Каталог с файлом для сериализации и
		/// десериализации данных приложения</param>
		/// <param name="fileName">Файл для сериализации и
		/// десериализации данных приложения</param>
		private static void CreateFile(FileInfo path)
		{
			if (!path.Directory.Exists)
			{
				path.Directory.Create();
			}
			if (!path.Exists)
			{
				path.Create().Close();
			}
		}
		/// <summary>
		/// Метод выполныет десериализацию объекта
		/// </summary>
		/// <returns>Десериализованный объект</returns>
		public static Project ReadProject(FileInfo path)
		{
			try
			{
				CreateFile(path);
			}
			catch
			{
				throw new Exception("Ошибка создания файла");
			}

			Project project = new Project();

			using (StreamReader file = new StreamReader(
					Convert.ToString(path), Encoding.Default))
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
		public static void SaveProject(Project project,
			FileInfo path)
		{
			try
			{
				CreateFile(path);
			}
			catch
			{
				throw new Exception("Ошибка создания файла");
			}

			using (StreamWriter file = new StreamWriter(
                Convert.ToString(path), false, Encoding.UTF8))
			{ 
                file.Write(JsonConvert.SerializeObject(project));
            }
        }
	}
}
