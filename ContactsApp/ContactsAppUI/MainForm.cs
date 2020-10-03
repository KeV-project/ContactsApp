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
            ContactForm addContactForm = new ContactForm(0, new Contact());
            addContactForm.Text = "Add contact";
            addContactForm.ShowDialog();
            if(addContactForm.DialogResult == DialogResult.OK)
            {
                Contact newContact = addContactForm.NewContact;

                _project.AddContact(newContact);

                ContactsListBox.Items.Add(newContact.LastName
                    + " " + newContact.FirstName);

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

            string[] names = Convert.ToString(ContactsListBox.
                Items[selectedIndex]).
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int contactIndex = _project.FindContactIndex(names[0], names[1]);
            if (contactIndex == -1)
            {
                MessageBox.Show("Контакт " + names[0]
                    + " " + names[1]
                    + " не существует или был удален");
                return;
            }

            ContactForm editContactForm = new ContactForm(contactIndex,
                _project.GetContact(contactIndex));

            editContactForm.Text = "Edit contact";
            editContactForm.ShowDialog();

            if (editContactForm.DialogResult == DialogResult.OK)
            {
                Contact newContact = editContactForm.NewContact;
                _project.ChangeContact(contactIndex, newContact);

                ContactsListBox.Items.RemoveAt(selectedIndex);
                ContactsListBox.Items.Insert(selectedIndex,
                    Convert.ToString(newContact.LastName)
                    + " " + Convert.ToString(newContact.FirstName));

                ProjectManager.SaveProject(_project);
            }
        }
    }
}
