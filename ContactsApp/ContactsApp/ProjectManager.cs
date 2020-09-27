using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ContactsApp
{
	public static class ProjectManager
	{
		private const string FILE_NAME = "ContactsApp.notes";
		private static readonly string _folder = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\";
		private static readonly string _path = _folder + FILE_NAME;

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

		public static void SaveProject(Project project)
		{
			using (StreamWriter file = new StreamWriter(
				_path, false, Encoding.UTF8))
			{
				file.Write(JsonConvert.SerializeObject(project));
			}
		}

		public static Project ReadProject()
		{
			if (!File.Exists(_path))
			{
				return null;
			}

			Project project = new Project();

			using (StreamReader file = new StreamReader(
					_path, Encoding.Default))
			{
				string projectContent = file.ReadLine();
				if (string.IsNullOrEmpty(projectContent))
				{
					return null;
				}
				
				project = JsonConvert.DeserializeObject<Project>(projectContent);
			}

			return project;
		}

	}
}
