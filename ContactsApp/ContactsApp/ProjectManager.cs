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
		private static void CreateFile(string folder, string fileName)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			if (!File.Exists(folder + fileName))
			{
				File.Create(folder + fileName).Close();
			}
		}
		/// <summary>
		/// Метод выполныет десериализацию объекта
		/// </summary>
		/// <returns>Десериализованный объект</returns>
		public static Project ReadProject(string folder, string fileName)
		{
			try
			{
				CreateFile(folder, fileName);
			}
			catch
			{
				throw new Exception("Ошибка создания файла");
			}

			Project project = new Project();

			using (StreamReader file = new StreamReader(
					folder + fileName, Encoding.Default))
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
			string folder, string fileName)
		{
			try
			{
				CreateFile(folder, fileName);
			}
			catch
			{
				throw new Exception("Ошибка создания файла");
			}

			using (StreamWriter file = new StreamWriter(
                folder + fileName, false, Encoding.UTF8))
			{ 
                file.Write(JsonConvert.SerializeObject(project));
            }
        }
	}
}
