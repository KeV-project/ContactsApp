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
        Project project;
        public MainForm()
        {
            project = ProjectManager.ReadProject();
            if(project != null)
            {
                CopyContactsNameInListBox(project);
            }
           
            InitializeComponent();

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
            foreach(Contact currentContact in project._contacts)
            {
                AddContactNameInListBox(currentContact.LastName 
                    + currentContact.FirstName);
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            ContactForm addContactForm = new ContactForm();
            addContactForm.Text = "Add contact";
            addContactForm.ShowDialog();
            Contact newContact = addContactForm.NewContact;
            project.AddContact(newContact);
            ContactsListBox.Items.Add(newContact.LastName + newContact.FirstName);
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactForm editContactForm = new ContactForm();
            editContactForm.Text = "Edit contact";
            editContactForm.Show();
        }

        private void SurnameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
