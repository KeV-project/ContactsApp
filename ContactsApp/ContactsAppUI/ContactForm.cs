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
    /// Класс "ContactForm" создает форму для окна 
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

            //TODO: Куча дублей
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
