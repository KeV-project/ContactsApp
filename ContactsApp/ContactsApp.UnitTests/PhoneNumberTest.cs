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
    /// Класс <see cref="PhoneNumberTest"/> предназначен
    /// для тестирования класса <see cref="PhoneNumber"/>
    /// </summary>
    [TestFixture]
    public class PhoneNumberTest
    {
        /// <summary>
        /// Тестируемый объект
        /// </summary>
        public PhoneNumber Number { get; set; }

        //TODO: SetUp не очень прозрачная конструкция, т.к. всегда надо помнить, что она выполняется перед основным тестом
        //TODO: Корректнее будет сделать ПРИВАТНЫЕ свойства только на гет. Там где данные не должны меняться - их можно прописать
        //TODO: в приватные поля
        /// <summary>
        /// Инициализация тестируемого объекта
        /// </summary>
        [SetUp]
        public void InitPhoneNumber()
		{
            Number = new PhoneNumber(79521777644);
		}

        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
		{
            var expected = 79521777644;
            var actual = Number.Number;

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
            Assert.Throws<ArgumentException>(
                () => { Number.Number = wrongNumber; },
                message);
        }

        [Test(Description = "Позитивный тест конструктора без параметров")]
        public void TestParameterlessConstructor_CorrectValues()
		{
            var expected = new PhoneNumber(70000000000);
            var actual = new PhoneNumber();

            bool result = Convert.ToBoolean(actual.CompareTo(expected));

            Assert.IsTrue(result,
                "Конструктор без параметров инициализирует поля класса " +
                "некорректрыми значениями");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void TestConstructorWithParameters_CorrectValues()
		{
            var expected = Number;
            var actual = new PhoneNumber(79521777644);

            bool result = Convert.ToBoolean(actual.CompareTo(expected));

            Assert.IsTrue(result,
                "Конструктор c параметрами инициализирует поля класса " +
                "некорректрыми значениями");
        }

        [TestCase(756489758641, "Должно возникать исключение, " +
            "если номер телефона длиннее 11 символов",
            TestName = "Присвоение числа длиннее 11 символов")]
        [TestCase(89521777644, "Должно возникать исключение, " +
            "если номер телефона не начинается с цифры 7",
             TestName = "Присвоение числа, первая цифра которого не 7")]
        public void TestConstructorWithParameters_IncorrectValues(
            long wrongNumber, string message)
		{
            Assert.Throws<ArgumentException>(
                () => {PhoneNumber phoneNumber = 
                    new PhoneNumber(wrongNumber); 
                }, message);
        }

        [TestCase(79994455661, 79994455661, 1, "Метод неверно стравнивает " +
            "равные объекты", TestName = "Сравнение одинаковых объектов")]
        [TestCase(79994455661, 79604466771, 0, "Метод неверно сравнивает " +
            "разные объекты", TestName = "Сравнение разных объектов")]
        public void TestCompareTo_CorrectValue(long firstNimber, 
            long secondNumber, int expectedResult, string message)
		{
            PhoneNumber firstPhoneNumber = new PhoneNumber(firstNimber);
            PhoneNumber secondPhoneNumber = new PhoneNumber(secondNumber);

            int actualResult = firstPhoneNumber.CompareTo(secondPhoneNumber);

            Assert.AreEqual(expectedResult, actualResult, message);
		}

    }
}
