using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void IntegerThreeIsDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isModThree = fb.IsDivisibleByThree(3);

			Assert.That(isModThree, Is.True);
		}

		[Test]
		public void IntegerDivisibleByThreeReturnsFizzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string word = fb.ReplaceNumberWithString(3);

			Assert.That(word, Is.EqualTo("Fizz"));
		}

		[Test]
		public void IntegerFiveIsDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isModFive = fb.IsDivisibleByFive(5);

			Assert.That(isModFive, Is.True);
		}

		[Test]
		public void IntegerDivisibleByFiveReturnsBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string word = fb.ReplaceNumberWithString(5);

			Assert.That(word, Is.EqualTo("Buzz"));
		}

		[Test]
		public void IntegerNotDivisibleByThreeOrFiveReturnsIntegerTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string integer = fb.ReplaceNumberWithString(2);

			Assert.That(integer, Is.EqualTo("2"));
		}

		[Test]
		public void IntegerDivisibleByThreeAndFiveReturnsFizzBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string fifteen = fb.ReplaceNumberWithString(15);

			Assert.That(fifteen, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void CanGenerateExpectedOutputTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string output = fb.GenerateOutput(1, 15);

			Assert.That(output, Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
		}
	}
}
