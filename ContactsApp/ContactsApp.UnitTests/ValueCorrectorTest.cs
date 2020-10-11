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
	/// Класс <see cref="ValueCorrectorTest"/> предназначен 
	/// для тестирования класса <see cref="ValueCorrector"/>
	/// </summary>
	class ValueCorrectorTest
	{
		[Test(Description = "Позитивный тест функции " +
			"ConvertPhoneNumberToInt")]
		public void TestConvertPhoneNumberToInt_CorrectValue()
		{
			var expected = 79521777644;

			string number = "+7 (952) 177-76-44";
			var actual = ValueCorrector.ConvertPhoneNumberToInt(number);

			Assert.AreEqual(expected, actual, "Функция возвращает " +
				"неверный формат номера телефона");
		}

		[TestCase("", "", "Должна вернуться пустая строка",
			TestName = "Передача пустой строки в качестве параметра")]
		[TestCase("петя", "Петя", "Должна вернуться та же строка, " +
			"первая буква который заглавная",
			TestName = "Передача строки в качестве параметра")]
		public void TestToUpperFirstLetter_CorrectValue(string name, 
			 string expected, string message)
		{
			var actual = ValueCorrector.ToUpperFirstLetter(name);
			Assert.AreEqual(expected, actual, message);
		}
	}
}
