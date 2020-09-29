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
        public Contact NewContact { get; private set; }
        public ContactForm()
        {
            InitializeComponent();
        }

        private void MakeContactOkButton_Click(object sender, EventArgs e)
        {
            NewContact = new Contact();
            try
            {
                NewContact.FirstName = MakeContactNameTextBox.Text;
                NewContact.LastName = MakeContactSurnameTextBox.Text;
                NewContact.BirthDate = MakeContactBirthDateTimePicker.Value;
                NewContact.Number = new PhoneNumber(ValueCorrector.
                    ConvertPhoneNumberToInt(
                    MakeContactPhoneMaskedTextBox.Text));
                NewContact.Email = MakeContactEmailTtextBox.Text;
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
