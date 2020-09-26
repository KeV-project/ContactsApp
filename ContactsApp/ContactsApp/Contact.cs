using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    public class Contact
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 15;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "id контакта");
                _id = value;
            }
        }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                const int minLength = 1;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value, 
                    Convert.ToString(minLength), 
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange, 
                    "имя контакта");
                _firstName = Convert.ToString(value[0]).ToUpper() 
                    + value.Substring(1);
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "фамилию контакта");
                if(value.Length > 0)
                {
                    _lastName = Convert.ToString(value[0]).ToUpper() 
                        + value.Substring(1);
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        private PhoneNumber Number { get; set; }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                const int minLength = 0;
                const int maxLength = 50;
                ValueValidator.AssertCorrectValue(value,
                    Convert.ToString(minLength),
                    Convert.ToString(maxLength),
                    CheckType.IsLenghtInRange,
                    "e-mail контакта");
                _email = value;
            }
        }

       
        public Contact(string id, string firstName, string lastName, 
            PhoneNumber number, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Email = email;
        }
    }
}
