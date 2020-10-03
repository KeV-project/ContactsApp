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
    public partial class ContactForm : Form
    {
        public Contact NewContact { get; set; }
        
        public ContactForm(Contact newContact)
        { 
            InitializeComponent();

            NewContact = newContact;

            if(NewContact.LastName == "Не определено")
            {
                MakeContactSurnameTextBox.Text = "";
            }
            else
            {
                MakeContactSurnameTextBox.Text = NewContact.LastName;
            }
            if (NewContact.FirstName == "Не определено")
            {
                MakeContactNameTextBox.Text = "";
            }
            else
            {
                MakeContactNameTextBox.Text = NewContact.FirstName;
            }
            MakeContactBirthDateTimePicker.Value = NewContact.BirthDate;
            if(NewContact.Number.Number == 70000000000)
            {
                MakeContactPhoneMaskedTextBox.Text = "";
            }
            else
            {
                MakeContactPhoneMaskedTextBox.Text =
                Convert.ToString(NewContact.Number.Number);
            }
            if(NewContact.Email == "Не определен")
            {
                MakeContactEmailTextBox.Text = "";
            }
            else
            {
                MakeContactEmailTextBox.Text = NewContact.Email;
            }
        }

        private void MakeContactOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewContact.FirstName = MakeContactNameTextBox.Text.Trim();
                NewContact.LastName = MakeContactSurnameTextBox.Text.Trim();
                NewContact.BirthDate = MakeContactBirthDateTimePicker.Value;
                NewContact.Number = new PhoneNumber(ValueCorrector.
                    ConvertPhoneNumberToInt(
                    MakeContactPhoneMaskedTextBox.Text));
                NewContact.Email = MakeContactEmailTextBox.Text.Trim();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MakeContactCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
