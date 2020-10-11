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
    /// Класс <see cref="ContactTest"/> предназначен
    /// для тестирования класса <see cref="Contact"/>
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
            "если строка состоит не только из букв английского и " +
            "русского алфавитов",
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
        
        [Test(Description = "Позитивный тест геттера BirthDate")]
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
            var expected = new Contact("Неизвестно", "Неизвестно",
                new PhoneNumber(), "Неизвестно", DateTime.Today);
            
            Assert.AreEqual(expected.FirstName, actual.FirstName,
                "Конструктор без параметров инициализирует " +
                "имя контакта неверным значением");
            Assert.AreEqual(expected.LastName, actual.LastName,
                "Конструктор без параметров инициализирует " +
                "фамилию контакта неверным значением");
            Assert.AreEqual(expected.Number.Number, actual.Number.Number,
                "Конструктор без параметров инициализирует " +
                "номер телефона неверным значением");
            Assert.AreEqual(expected.Email, actual.Email,
                "Конструктор без параметров инициализирует " +
                "e-mail контакта неверным значением");
            Assert.AreEqual(expected.BirthDate, actual.BirthDate,
                "Конструктор без параметров инициализирует " +
                "дату рождения контака некорректными значениями");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void TestConstructorWithParameters_CorrectValues()
        {
            var expected = Contact;
            var actual = new Contact("Сергей", "Пресняков",
                new PhoneNumber(79521777644), "sergey@gmail.com",
                new DateTime(1999, 12, 12));
            actual.Id = 111;

            Assert.AreEqual(expected.FirstName, actual.FirstName,
                "Конструктор с параметрами инициализирует " +
                "имя контакта неверным значением");
            Assert.AreEqual(expected.LastName, actual.LastName,
                "Конструктор с параметрами инициализирует " +
                "фамилию контакта неверным значением");
            Assert.AreEqual(expected.Number.Number, actual.Number.Number,
                "Конструктор с параметрами инициализирует " +
                "номер телефона неверным значением");
            Assert.AreEqual(expected.Email, actual.Email,
                "Конструктор с параметрами инициализирует " +
                "e-mail контакта неверным значением");
            Assert.AreEqual(expected.BirthDate, actual.BirthDate,
                "Конструктор с параметрами инициализирует " +
                "дату рождения контака некорректными значениями");
        }

        [Test(Description = "Незативный тест конструктора с параметрами")]
        public void TestConstructorWithParameters_InorrectValues()
		{
            string firstName = Contact.FirstName;
            string lastName = Contact.LastName;
            PhoneNumber number = Contact.Number;
            string email = Contact.Email;
            DateTime birthDate = Contact.BirthDate;

            string incorrectFirstName = "";
            string incorrectLastName = "ВладимирВладимирВладимирВладимир" +
                "ВладимирВладимирВладимирВладимирВладимирВладимирВладимир";
            long incorrectNumber = 89521777455;
            string inclorrectEmail = "vladimir51656546546987986565468879" +
                "56546545465465654655555555555555555555555555555555555555";
            DateTime incorrectBirthDate = new DateTime(1899, 12, 31);

            Assert.Throws<ArgumentException>(() => 
            {
                Contact contact = new Contact(incorrectFirstName, lastName,
                  number, email, birthDate);
            }, "Должно шенерироваться исключении при попытке " +
            "создать контакт с некорректным значением имени");
            Assert.Throws<ArgumentException>(() =>
            {
                Contact contact = new Contact(firstName, incorrectLastName,
                  number, email, birthDate);
            }, "Должно шенерироваться исключении при попытке " +
            "создать контакт с некорректным значением фамилии");
            Assert.Throws<ArgumentException>(() =>
            {
                Contact contact = new Contact(firstName, lastName,
                  new PhoneNumber(incorrectNumber), email, birthDate);
            }, "Должно шенерироваться исключении при попытке " +
            "создать контакт с некорректным значением номера телефона");
            Assert.Throws<ArgumentException>(() =>
            {
                Contact contact = new Contact(firstName, lastName,
                  number, inclorrectEmail, birthDate);
            }, "Должно шенерироваться исключении при попытке " +
            "создать контакт с некорректным значением адреса " +
            "элетронной почты");
            Assert.Throws<ArgumentException>(() =>
            {
                Contact contact = new Contact(firstName, lastName,
                  number, email, incorrectBirthDate);
            }, "Должно шенерироваться исключении при попытке " +
            "создать контакт с некорректным значением даты рождения");

        }

        [Test(Description = "Позитивный тест Clone")]
        public void TestClone()
		{
            var expected = Contact;
            var actual = (Contact)Contact.Clone();

            Assert.IsFalse(expected == actual, 
                "Объект копия не ссылаться на " +
                "копируемый объект");
            Assert.AreEqual(expected.FirstName, actual.FirstName,
               "Имя копируемого объекта не совпадает с " +
               "именем обекта копии");
            Assert.AreEqual(expected.LastName, actual.LastName,
                "Фамилия копируемого объекта не совпадает с " +
                "фамилией объекта копии");
            Assert.IsFalse(expected.Number == actual.Number,
                "Объект копия не должен содержать ссылку на " +
                "PhoneNumber копируемого объекта ");
            Assert.AreEqual(expected.Number.Number, actual.Number.Number,
               "Номер телефона копируемого объекта не совпадает с " +
               "номером телефона объекта копии");
            Assert.AreEqual(expected.Email, actual.Email,
                "E-mail копируемого объекта не совпадает с " +
                "e-mail объекта копии");
            Assert.AreEqual(expected.BirthDate, actual.BirthDate,
                "Дата рождения копируемого объекта не совпадает с " +
                "датой рождения объекта копии");
        }

        [Test(Description = "Позитивный тест метода CompareTo")]
        public void TestCompareTo_CorrectValue()
		{
            Contact[] contacts = new Contact[]
            {
                new Contact("Алина", "Анаферова",
                new PhoneNumber(79521777655), "alina@gmail.com",
                new DateTime(1998, 12, 12)),

                Contact,

                new Contact("Тарас", "Рыжков",
                new PhoneNumber(79521777644), "taras@gmail.com",
                new DateTime(1997, 12, 12))
            };

            for (int i = 2; i < 0; i++)
            {
                int actualResult = contacts[1].CompareTo(contacts[i - 1]);
                Assert.AreEqual(i, actualResult, "Метод возвращает неверный " +
                    "результат сравнения объектов");
            }
        }
    }
}
