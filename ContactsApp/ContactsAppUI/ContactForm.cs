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
    /// Класс <see cref="ContactForm"/> создает форму для окна 
    /// добавления и редактирования контакта
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Новые или изменяемый контакт
        /// </summary>
        public Contact NewContact { get; set; }
        
        /// <summary>
        /// Инициализирует элементы формы
        /// и устанавливает значение нового или изменяемого контакта
        /// </summary>
        /// <param name="newContact">Новый или изменяемый контакт</param>
        public ContactForm(Contact newContact)
        { 
            InitializeComponent();

            NewContact = newContact;

            if(NewContact.LastName == "Неизвестно" &&
               NewContact.FirstName == "Неизвестно" &&
               NewContact.Number.Number == 70000000000 &&
               NewContact.BirthDate == DateTime.Today &&
               NewContact.Email == "Неизвестно")
			{
                MakeContactSurnameTextBox.Text = "";
                MakeContactNameTextBox.Text = "";
                MakeContactPhoneMaskedTextBox.Text = "";
                MakeContactBirthDateTimePicker.Value = DateTime.Today;
                MakeContactEmailTextBox.Text = "";
            }
			else
			{
                MakeContactSurnameTextBox.Text = NewContact.LastName;
                MakeContactNameTextBox.Text = NewContact.FirstName;
                MakeContactPhoneMaskedTextBox.Text = Convert.ToString(NewContact.
                    Number.Number).Remove(0, 1);
                MakeContactBirthDateTimePicker.Value = NewContact.BirthDate;
                MakeContactEmailTextBox.Text = NewContact.Email;
            }
        }

        /// <summary>
        /// Метод устанавливает введенные данные в поля нового 
        /// или изменяемого контакта
        /// </summary>
        private void MakeContactOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewContact.FirstName = MakeContactNameTextBox.Text;
                NewContact.LastName = MakeContactSurnameTextBox.Text;
                NewContact.BirthDate = MakeContactBirthDateTimePicker.Value;
                NewContact.Number = new PhoneNumber(ValueCorrector.
                    ConvertPhoneNumberToInt(
                    MakeContactPhoneMaskedTextBox.Text));
                NewContact.Email = MakeContactEmailTextBox.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Метод закрывает форму при нажатии на кновку Cancel
        /// </summary>
        private void MakeContactCancelButton_Click(object sender, 
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
	}
}
