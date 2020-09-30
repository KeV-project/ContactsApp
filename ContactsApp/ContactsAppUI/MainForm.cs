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

            if (_project.Contacts.Count != 0)
            {
                CopyContactsNameInListBox(_project);
            }
           
            AddContactButton.FlatAppearance.BorderSize = 0;
            AddContactButton.FlatStyle = FlatStyle.Flat;

            EditContactButton.FlatAppearance.BorderSize = 0;
            EditContactButton.FlatStyle = FlatStyle.Flat;

            RemoveContactButton.FlatAppearance.BorderSize = 0;
            RemoveContactButton.FlatStyle = FlatStyle.Flat;
        }

        public void AddContactNameInListBox(string contactName)
        {
            ContactsListBox.Items.Add(contactName);
        }

        private void CopyContactsNameInListBox(Project project)
        {
            foreach(Contact currentContact in project.Contacts)
            {
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
            string[] names = Convert.ToString(ContactsListBox.
                Items[selectedIndex]).
                Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            int contactIndex = 0;
            try
            {
                contactIndex = _project.FindContactIndex(names[0], names[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Контакт " + names[0]
                    + " " + names[1]
                    + " не существует или был удален");
                return;
            }
            ContactForm editContactForm = 
                new ContactForm( contactIndex, 
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

        private void SurnameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
