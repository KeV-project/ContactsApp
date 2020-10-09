using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс "Тестирование контакта" предназначен
    /// для тестирования класса "Контакт"
    /// </summary>
    [TestFixture]
	class ContactTest
	{
        public Contact Contact { get; set; }

        [SetUp]
        public void InitContact()
        {
            Contact = new Contact("Сергей", "Пресняков",
                new PhoneNumber(79521777644), "sergey@gmail.com",
                new DateTime(1999, 12, 12));
            Contact.Id = 111;
        }

        [Test(Description = "Позитивный тест геттера Id")]
        public void TestIdGet_CorrectValue()
        {
            var expected = 111;
            var actual = Contact.Id;

            Assert.AreEqual(expected, actual,
                "Геттер Id возвращает неправильное " +
                "значение идентификатора контакта");
        }

        [Test(Description = "Негативный тест сеттера Id")]
        public void TestIdSet_IncorrectValue()
		{
            var wrongId = 12345678910111213;
         
            Assert.Throws<ArgumentException>(
                () => { Contact.Id = wrongId; },
                "Должно возникать исключение, " +
                "если идентификатор контакта состоит более чем" +
                "из 15 символов");
        }

        [Test(Description = "Позитивный тест геттера FirstName")]
        public void TestFirstNameGet_CorrectValue()
		{
            var expected = "Сергей";
            var actual = Contact.FirstName;

            Assert.AreEqual(expected, actual,
                "Геттер FirstName возвращает неправильное " +
                "значение имени контакта");
		}

        [TestCase("СергейСергейСергейСергейСергейСергейСергей" +
            "СергейСергейСергейСергейСергейСергейСергей", 
            "Должно возникать исключение, " +
            "если имя контакта состоит более чем из 50 символов",
            TestName = "Присвоение строки длиннее 50 символов")]
        [TestCase("+Андрей", "Должно возникать исключение, " +
            "если имя контакта содержит символы " +
            "кроме букв, цифр и пустых строк",
             TestName = "Присвоение стоки, содержащей символы кроме" +
            "букв, цифр и пустых строк")]
        public void TestFirstNameSet_IncorrectValue(string wrongName,
            string message)
		{
            Assert.Throws<ArgumentException>(
                 () => { Contact.FirstName = wrongName; },
                 message);
        }

        [Test(Description = "Позитивный тест геттера LastName")]
        public void TestLastNameGet_CorrectValue()
        {
            var expected = "Пресняков";
            var actual = Contact.LastName;

            Assert.AreEqual(expected, actual,
                "Геттер LastName возвращает неправильное " +
                "значение имени контакта");
        }

        [TestCase("СтрельниковСтрельниковСтрельниковСтрельниковСтрельников" +
            "СтрельниковСтрельниковСтрельниковСтрельников",
            "Должно возникать исключение, " +
            "если фамилия контакта состоит более чем из 50 символов",
            TestName = "Присвоение строки длиннее 50 символов")]
        [TestCase("+Стрельников", "Должно возникать исключение, " +
            "если фамилия контакта содержит символы " +
            "кроме букв, цифр и пустых строк",
             TestName = "Присвоение стоки, содержащей символы кроме" +
            "букв, цифр и пустых строк")]
        public void TestLastNameSet_IncorrectValue(string wrongName,
            string message)
        {
            Assert.Throws<ArgumentException>(
                 () => { Contact.LastName = wrongName; },
                 message);
        }

        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
		{
            var expected = 79521777644;
            var actual = Contact.Number.Number;

            Assert.AreEqual(expected, actual, 
                "Геттер Number возвращает неправильное значение");
		}

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
		{
            var expected = "sergey@gmail.com";
            var actual = Contact.Email;

            Assert.AreEqual(expected, actual,
                "Геттер Email возвращает неправильное значение");
        }

        [Test(Description = "Негативный тест сеттера Email")]
        public void TestEmailSet_IncorrectValue()
		{
            var wrongEmail = "obstacle1132325654646856" +
                "54879898566546516546561326848984" +
                "6+5+65+5+5+6+9+9+9+9+dfdfvsdfvsdfv";
            
            Assert.Throws<ArgumentException>(
                () => { Contact.Email = wrongEmail; },
                "Должно возникнуть исключение, " +
                "если длина адреса электронной " +
                "почты контакта превышает 50 символов");
        }
        
        [Test(Description = "Положительный тест геттера BirthDate")]
        public void TestBirthDateGet_CorrectValue()
		{
            var expected = Contact.BirthDate;
            var actual = new DateTime(1999, 12, 12);

            Assert.AreEqual(expected, actual, 
                "Геттер BirthDate возвращает неверное значение");
		}

        [Test(Description = "Негативный тест сеттера BirthDate")]
        public void TestBirthDateSet_IncorrectValue()
		{
            var wrongBirthDate = new DateTime(1899, 12, 5);

            Assert.Throws<ArgumentException>(
                () => { Contact.BirthDate = wrongBirthDate; },
                "Должно возникнуть исключение, " +
                "если дата рождения контакта раньше 31.12.1900 " +
                "или позже текужей даты");
        }

        [Test(Description = "Позитивный тест конструктора без параметров")]
        public void TestParameterlessConstructor_CorrectValues()
		{
            var actual = new Contact();
            var expected = new Contact("Не определено", "Не определено",
                new PhoneNumber(), "Не определен", DateTime.Today);
            
            Assert.AreEqual(expected, actual,
                "Конструктор без параметров инициализирует поля класса " +
                "некорректными значениями");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void TestConstructorWithParameters_CorrectValues()
        {
            var expected = Contact;
            Contact contact = new Contact("Сергей", "Пресняков",
                new PhoneNumber(79521777644), "sergey@gmail.com", 
                new DateTime(1999, 12, 12));
            contact.Id = 111;
            var actual = contact;
            Assert.AreEqual(expected, actual,
                "Конструктор c параметрами инициализирует поля класса " +
                "некорректрыми значениями");
        }

        [Test(Description = "Позитивный тест Clone")]
        public void TestClone()
		{
            Contact contact = new Contact("Алина", "Карамутдинова",
                new PhoneNumber(79521455695), "alina@gmail.com", 
                new DateTime(1999, 7, 5));
            Contact newContact = (Contact)contact.Clone();
            Assert.Throws<ArgumentException>(
                () => { 
                    if(contact.Id != newContact.Id)
					{
                        throw new AccessViolationException("Id " +
                            "копируемого объекта не соответствует " +
                            "Id объекта копии");
                    }
                    if(contact.FirstName != newContact.FirstName)
					{
                        throw new AccessViolationException("Имя " +
                            "копируемого объекта не соответствует " +
                            "имени объекта копии");
					}
                    if(contact.LastName != newContact.LastName)
					{
                        throw new AccessViolationException("Фамилия " +
                            "копируемого объекта не соответствует " +
                            "фамилии объекта копии");
                    }
                    if(!object.ReferenceEquals(contact.Number, 
                        newContact.Number))
					{
                        throw new AccessViolationException("Оба " +
                            "объекта ссылаются на один и тот же " +
                            "объект PhoneNumber");
                    }
                    if(contact.Number != newContact.Number)
					{
                        throw new ArgumentException("Номер телефона " +
                            "копируемого объекта не соответствует " +
                            "номеру телефона объекта копии");
					}
                    if(contact.Email != newContact.Email)
					{
                        throw new ArgumentException("Адрес электронной " +
                            " почты копируемого объекта не соответствует " +
                            "адрусу электронной почты объекта копии");
                    }
                    if (!object.ReferenceEquals(contact.BirthDate,
                        newContact.BirthDate))
                    {
                        throw new AccessViolationException("Оба " +
                            "объекта ссылаются на один и тот же " +
                            "объект BirthDate");
                    }
                    if(contact.BirthDate != newContact.BirthDate)
					{
                        throw new AccessViolationException("День рождения " +
                            "копируемого объекта не соответствует " +
                            "дню рождения объекта копии");
                    }
                },
                "Должно возникнуть исключение, " +
                "если информация о копируемом объекте отличается " +
                "от информации об объекте копии или " +
                "объекты содержат одинаковые ссылки на объекты " +
                "других классов");

        }
    }
}
