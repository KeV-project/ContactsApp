using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
		{
            var expected = 79521777644;
            PhoneNumber phoneNumber = new PhoneNumber();
            phoneNumber.Number = expected;
            var actual = phoneNumber.Number;

            Assert.AreEqual(expected, actual, 
                "Геттер PhoneNumber возвращает неправильный номер телефона");
        }

        [TestCase(756489758641, "Должно возникать исключение, " +
            "если номер телефона длиннее 11 символов",
            TestName = "Присвоение числа длиннее 11 символов")]
        [TestCase(89521777644, "Должно возникать исключение, " +
            "если номер телефона не начинается с цифры 7",
             TestName = "Присвоение числа, первая цифра которого не 7")]
        public void TestNumberSet_ArgumentException(long wrongNumber, string message)
        {
            PhoneNumber phoneNumber = new PhoneNumber();

            Assert.Throws<ArgumentException>(
                () => { phoneNumber.Number = wrongNumber; },
                message);
        }

        [Test(Description = "Позитивный тест конструктора без параметров")]
        public void TestParameterlessConstructor_CorrectValues()
		{
            var expected = 70000000000;
            PhoneNumber phoneNumber = new PhoneNumber();
            var actual = phoneNumber.Number;
            Assert.AreEqual(expected, actual,
                "Конструктор без параметров инициализирует поля класса " +
                "некорректрыми значениями");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void TestConstructorWithParameters_CorrectValues()
		{
            var expected = 79521777644;
            PhoneNumber phoneNumber = new PhoneNumber(expected);
            var actual = phoneNumber.Number;
            Assert.AreEqual(expected, actual,
                "Конструктор c параметрами инициализирует поля класса " +
                "некорректрыми значениями");
        }

        [TestCase(756489758641, "Должно возникать исключение, " +
            "если номер телефона длиннее 11 символов",
            TestName = "Присвоение числа длиннее 11 символов")]
        [TestCase(89521777644, "Должно возникать исключение, " +
            "если номер телефона не начинается с цифры 7",
             TestName = "Присвоение числа, первая цифра которого не 7")]
        public void TestConstructorWithParameters_ArgumentException(
            long wrongNumber, string message)
		{
            Assert.Throws<ArgumentException>(
                () => {PhoneNumber phoneNumber = 
                    new PhoneNumber(wrongNumber); 
                }, message);
        }
    }
}
