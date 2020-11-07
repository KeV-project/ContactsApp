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
	/// Класс <see cref="ValueValidator"/> предназначен 
	/// для тестирования класса <see cref="ValueValidator"/>
	/// </summary>
	class ValueValidatorTest
	{
		[Test(Description = "Позитивный тест метода AssertValueInRange")]
		public void TestAssertValueInRange_СorrectValue()
		{
			// arrange
			var value = 5.5;
			var minLimit = 0;
			var maxLimit = 10;
			var context = "экспериментальное значение";

			// act
			ValueValidator.AssertValueInRange(value, minLimit,
			  maxLimit, context);
		}

		[Test(Description = "Негативный тест метода AssertValueInRange")]
		public void TestAssertValueInRange_IncorrectValue()
		{
			// arrange
			var wrongValue = 10.5;
			var minLimit = 0;
			var maxLimit = 10;
			var context = "экспериментальное значение";

			// assert
            //TODO: Скобочки на разных строках +
			Assert.Throws<ArgumentException>(() =>
			{ 
				ValueValidator.AssertValueInRange(wrongValue, minLimit,
					maxLimit, context); 
			}, "Должно возникать искючение, " +
			"если проверяемое число не входит в допустимый диапазон");
		}

		[Test(Description = "Негативный тест метода AssertLengthInRange")]
		public void TestAssertLengthInRange_IncorrectValue()
		{
			// arrange
			var wrongValue = "Николай";
			var minLimit = 0;
			var maxLimit = 5;
			var context = "экспериментальное значение";

			// arrest
            //TODO: Скобочки на разных строках +
			Assert.Throws<ArgumentException>(() => 
			{ 
				ValueValidator.AssertLengthInRange(wrongValue, 
					minLimit, maxLimit, context); 
			}, "Должно возникать искючение, если количество символов " +
			"в проверяемой строке не входит в допустимый диапазон");
		}

		[TestCase(799945514556, "Должно возникать исключение, " +
			"если номер телефона содежит больше или меньше 11 символов",
			TestName = "Проверяемое значение сожержит больше " +
			"или меньше 11 символов")]
		[TestCase(89994551455, "Должно возникать исключение, " +
			"если номер телефона начинается не с цифры 7",
			TestName = "Первая цифра проверяемого числа не равна 7")]
		public void TestAssertRussianPhoneNumber_IncorrectValue(
			long wrongNumber, string message)
		{
			// arrange
			var context = "номер телефона";

			// assert
			//TODO: Скобочки на разных строках +
			Assert.Throws<ArgumentException>(()=> 
			{
				ValueValidator.AssertRussianPhoneNumber(wrongNumber, 
					context);
			}, message);
		}

		[TestCase("СергейСергейСергейСергейСергейСергейСергей" +
			"СергейСергейСергейСергейСергейСергейСергей", 0, 50,
			"Должно возникать исключение, " +
			"если количество символов в строке не входит в " +
			"допустимый диапазон",
			TestName = " строки длиннее 50 символов")]
		[TestCase("+Андрей", 0, 50, "Должно возникать исключение, " +
			"если строка состоит не только из букв английского и " +
			"русского алфавитов",
			 TestName = "Присвоение стоки состоящей не только из букв " +
			"английского и русского алфавитов")]
		public void TestAssertCorrectName_IncorrectValue(string wrongString,
			int minLength, int maxLength, string message)
		{
			// arrange
			var context = "имя или фамилию";

			// assert
            //TODO: Скобочки на разных строках +
			Assert.Throws<ArgumentException>(() => 
			{ 
				ValueValidator.AssertCorrectName(wrongString, 
					 minLength, maxLength, context); 
			}, message);
		}

		[Test(Description = "Негативный тест метода AssertCorrectDate")]
		public void TestAssertCorrectDate_IncorrectValue()
		{
			// arrange
			var wrongDate = new DateTime(1800, 12, 12);
			var minDate = new DateTime(1900, 12, 31);
			var maxDate = DateTime.Today;
			var context = "дату";

			// assert
            //TODO: Скобочки на разных строках +
			Assert.Throws<ArgumentException>(() => 
			{
				ValueValidator.AssertCorrectDate(wrongDate,
						minDate, maxDate, context);
			}, "Должно возникать искючение, если проверяемая дата " +
			"не входит в допустимый диапазон");
		}
	}
}
