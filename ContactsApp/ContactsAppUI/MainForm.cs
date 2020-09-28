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
        public MainForm()
        {
            InitializeComponent();

            AddContactButton.FlatAppearance.BorderSize = 0;
            AddContactButton.FlatStyle = FlatStyle.Flat;

            EditContactButton.FlatAppearance.BorderSize = 0;
            EditContactButton.FlatStyle = FlatStyle.Flat;

            RemoveContactButton.FlatAppearance.BorderSize = 0;
            RemoveContactButton.FlatStyle = FlatStyle.Flat;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            ContactForm addContactForm = new ContactForm();
            addContactForm.Text = "Add contact";
            addContactForm.Show();
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
