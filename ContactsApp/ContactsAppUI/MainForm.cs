using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    /// <summary>
    /// Класс "MainForm" создает стартовое окно приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Содержит объект класса Project
        /// </summary>
        Project _project;
        /// <summary>
        /// Содержит выбранный пользователем контакт
        /// </summary>
        Contact _currentContact;
        /// <summary>
        /// Содержит список контактов,
        /// отображаемых в ListBox
        /// </summary>
        LinkedList<Contact> _listBoxContacts;
        /// <summary>
        /// Создает стартовое окно приложения,
        /// выполняет десереализацию объекта Project
        /// </summary>
        public MainForm()
        {
            _project = ProjectManager.ReadProject();
            _currentContact = null;
            _listBoxContacts = new LinkedList<Contact>();

            InitializeComponent();

            if (_project.GetContactsCount() != 0)
            {
                CopyContactsNameInListBox(_project);
            }

            LinkedList<Contact> birthCotacts = _project.GetAllBirthContacts();
            if(birthCotacts.Count != 0)
			{
                BirthTextBox.Text = " ";
                int contactCount = 0;
                foreach(Contact currentContact in birthCotacts)
				{
                    BirthTextBox.Text += currentContact.LastName + " "
                        + currentContact.FirstName;
                    if(contactCount != birthCotacts.Count - 1)
					{
                        BirthTextBox.Text = BirthTextBox.Text + ", ";
                    }
                    contactCount++;
                }
                BirthTableLayoutPanel.Visible = true;
			}

        }

        /// <summary>
        /// Очищает текстовые поля,
        /// демонстрирующие инвормацию о текущем контакте
        /// </summary>
        public void ContactsTextBoxClear()
        {
            ContactSurnameTextBox.Text = "";
            ContactNameTextBox.Text = "";
            ContactBirthDateTimePicker.Value = DateTime.Today;
            ContactPhoneMaskedTextBox.Text = "";
            ContactEmailTextBox.Text = "";
        }

        /// <summary>
        /// Помещает текущий контакт в поле currentContact
        /// </summary>
        /// <param name="selectedIndex"></param>
        public void SetCurrentContact(int selectedIndex)
        {
            if(selectedIndex >= _listBoxContacts.Count)
            {
                return;
            }

            LinkedListNode<Contact> currentContact = _listBoxContacts.First;
            for(int i = 0; i <= selectedIndex; i++)
            {
                if(i == selectedIndex)
                {
                    _currentContact =  currentContact.Value;
                }
                currentContact = currentContact.Next;
            }
        }

        /// <summary>
        /// Добавляет имя и фамилию контакт в ListBox
        /// </summary>
        /// <param name="contactName">Добавляемая строка 
        /// с именем и фамилией контакта</param>
        public void AddContactNameInListBox(string contactName)
        {
            ContactsListBox.Items.Add(contactName);
        }

        /// <summary>
        /// Заполняет ListBox контактами из списка объекта Project
        /// </summary>
        /// <param name="project">Содержит 
        /// список контактов пользователя</param>
        private void CopyContactsNameInListBox(Project project)
        {
            ContactsListBox.Items.Clear();
            _listBoxContacts.Clear();

            for (int i = 0; i < _project.GetContactsCount(); i++)
            {
                Contact currentContact = _project.GetContact(i);
                if(currentContact == null)
                {
                    MessageBox.Show("Ошибка загрузки контактов");
                    this.Close();
                }

                AddContactNameInListBox(currentContact.LastName
                    + " " + currentContact.FirstName);
                _listBoxContacts.AddLast(currentContact);
            }
        }

        /// <summary>
        /// Заполняет ListBox текущими контактами
        /// </summary>
        /// <param name="contacts">Список текущих контактов</param>
        private void FillListBoxItems(LinkedList<Contact> contacts)
        {
            ContactsListBox.Items.Clear();

            foreach (Contact currentContact in contacts)
            {
                AddContactNameInListBox(currentContact.LastName
                   + " " + currentContact.FirstName);
            }
        }

        /// <summary>
        /// Создает форму для добавления контакта и
        /// добавляет контакт в список всех контактов
        /// </summary>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            FindTextBox.Clear();

            Contact newContact = new Contact();

            ContactForm addContactForm = new ContactForm(newContact);
            addContactForm.Text = "Add contact";
            addContactForm.ShowDialog();
            if(addContactForm.DialogResult == DialogResult.OK)
            {
                _project.AddContact(newContact);

                CopyContactsNameInListBox(_project);

                FindTextBox.Text = "";
                ContactsTextBoxClear();

                ProjectManager.SaveProject(_project);
            }
        }

        /// <summary>
        /// Создает форму для редактирования контакта
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для редактирования");
                return;
            }

            ContactForm editContactForm = new ContactForm(_currentContact);

            editContactForm.Text = "Edit contact";
            editContactForm.ShowDialog();

            if (editContactForm.DialogResult == DialogResult.OK)
            {
                _project.RemoveContact(_currentContact);
                _project.AddContact(_currentContact);

                CopyContactsNameInListBox(_project);

                FindTextBox.Text = "";
                ContactsTextBoxClear();

                ProjectManager.SaveProject(_project);
            }
        }

        /// <summary>
        /// Метод удаляет выбранный контакт
        /// </summary>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для редактирования");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить контакт \""
                + _currentContact.LastName + " " 
                + _currentContact.FirstName + "\"?",
                "Delete contact",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.RemoveContact(_currentContact);

                CopyContactsNameInListBox(_project);

                FindTextBox.Text = "";
                ContactsTextBoxClear();

                ProjectManager.SaveProject(_project);
            }

        }

        /// <summary>
        /// Выводит информацию о выбранном контакте
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, 
            EventArgs e)
        { 
            var selectedIndex = ContactsListBox.SelectedIndex;
            if(selectedIndex == -1)
            {
                ContactsTextBoxClear();
            }
            else
            {
                SetCurrentContact(selectedIndex);
                if (_currentContact == null)
                {
                    MessageBox.Show("Контакт не существует или был удален");
                    return;
                }

                ContactSurnameTextBox.Text = _currentContact.LastName;
                ContactNameTextBox.Text = _currentContact.FirstName;
                ContactBirthDateTimePicker.Value = _currentContact.BirthDate;
                ContactPhoneMaskedTextBox.Text =
                    Convert.ToString(_currentContact.Number.Number);
                ContactEmailTextBox.Text = _currentContact.Email;
            }
        }

        /// <summary>
        /// Исменяет список текущих контактов при вводе подстроки
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactsTextBoxClear();

            string text = FindTextBox.Text;

            if(text != "")
            {
                _listBoxContacts = _project.GetContactsWithText(text);
                FillListBoxItems(_listBoxContacts);
            }
            else
            {
                CopyContactsNameInListBox(_project);
            }
        }

        /// <summary>
        /// Закрывает главное окно приложения
        /// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        /// <summary>
        /// Вызывает метод добавления контакта
        /// </summary>
		private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AddContactButton_Click(null, null);
		}

        /// <summary>
        /// Вызывает метод редактирования контакта
        /// </summary>
		private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            EditContactButton_Click(null, null);
        }

        /// <summary>
        /// Вызывает метод удаления контакта
        /// </summary>
		private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            RemoveContactButton_Click(null, null);
		}

        /// <summary>
        /// Создает и запускает окно с информацией о приложении
        /// </summary>
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
		}
	}
}
