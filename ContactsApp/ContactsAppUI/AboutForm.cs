using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
	/// <summary>
	/// Класс "AboutForm" создает форму с информацией о приложении
	/// </summary>
	public partial class AboutForm : Form
	{
		/// <summary>
		/// Инициализирует компоненты формы
		/// </summary>
		public AboutForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Запускает интернет страницу с приложение 
		/// ContactsApp на сайте GitHub
		/// </summary>
		private void GitHubLinkLabel_LinkClicked(object sender, 
			LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(
				"https://github.com/KeV-project/ContactsApp");
		}
	}
}
