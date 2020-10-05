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
    public partial class MainForm : Form
    {
        Project _project;
        Contact _currentContact;
        LinkedList<Contact> _listBoxContacts;
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

        public void ContactsTextBoxClear()
        {
            ContactSurnameTextBox.Text = "";
            ContactNameTextBox.Text = "";
            ContactBirthDateTimePicker.Value = DateTime.Today;
            ContactPhoneMaskedTextBox.Text = "";
            ContactEmailTextBox.Text = "";
        }

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

        public void AddContactNameInListBox(string contactName)
        {
            ContactsListBox.Items.Add(contactName);
        }

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

        private void FillListBoxItems(LinkedList<Contact> contacts)
        {
            ContactsListBox.Items.Clear();

            foreach (Contact currentContact in contacts)
            {
                AddContactNameInListBox(currentContact.LastName
                   + " " + currentContact.FirstName);
            }
        }

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

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AddContactButton_Click(null, null);
		}

		private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            EditContactButton_Click(null, null);
        }

		private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
            RemoveContactButton_Click(null, null);
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
		}
	}
}
