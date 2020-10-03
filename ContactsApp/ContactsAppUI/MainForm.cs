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
        public MainForm()
        {
            _project = ProjectManager.ReadProject();

            InitializeComponent();

            if (_project.GetContactsCount() != 0)
            {
                CopyContactsNameInListBox(_project);
            }

        }

        public void AddContactNameInListBox(string contactName)
        {
            ContactsListBox.Items.Add(contactName);
        }

        private void CopyContactsNameInListBox(Project project)
        {
            for(int i = 0; i < _project.GetContactsCount(); i++)
            {
                Contact currentContact = _project.GetContact(i);
                if(currentContact == null)
                {
                    MessageBox.Show("Ошибка загрузки контактов");
                    this.Close();
                }

                AddContactNameInListBox(currentContact.LastName
                    + " " + currentContact.FirstName);
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();

            ContactForm addContactForm = new ContactForm(0, newContact);
            addContactForm.Text = "Add contact";
            addContactForm.ShowDialog();
            if(addContactForm.DialogResult == DialogResult.OK)
            {
                _project.AddContact(newContact);

                ContactsListBox.Items.Clear();
                CopyContactsNameInListBox(_project);

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

            Contact editContact = _project.GetContact(selectedIndex);
            if (editContact == null)
            {
                MessageBox.Show("Контакт не существует или был удален");
                return;
            }

            ContactForm editContactForm = new ContactForm(selectedIndex,
                editContact);

            editContactForm.Text = "Edit contact";
            editContactForm.ShowDialog();

            if (editContactForm.DialogResult == DialogResult.OK)
            {
                _project.RemoveContact(editContact);
                _project.AddContact(editContact);

                ContactsListBox.Items.Clear();
                CopyContactsNameInListBox(_project);

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

            Contact removableContact = _project.GetContact(selectedIndex);
            if (removableContact == null)
            {
                MessageBox.Show("Контакт не существует или был удален");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить контакт \""
                + removableContact.LastName + " " 
                + removableContact.FirstName + "\"?",
                "Delete contact",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.RemoveContact(removableContact);

                ContactsListBox.Items.Clear();
                CopyContactsNameInListBox(_project);

                ProjectManager.SaveProject(_project);
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;

            Contact selectedContact = _project.GetContact(selectedIndex);
            ContactSurnameTextBox.Text = selectedContact.LastName;
            ContactNameTextBox.Text = selectedContact.FirstName;
            ContactBirthDateTimePicker.Value = selectedContact.BirthDate;
            ContactPhoneMaskedTextBox.Text = 
                Convert.ToString(selectedContact.Number.Number);
            ContactEmailTextBox.Text = selectedContact.Email;
        }
    }
}
