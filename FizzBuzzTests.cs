using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata5
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void ThreeIsDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByThree = fb.IsDivisibleByThree(3);

			Assert.That(isDivisibleByThree, Is.True);
		}

		[Test]
		public void FiveIsDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisibleByFive = fb.IsDivisibleByFive(5);

			Assert.That(isDivisibleByFive, Is.True);
		}

		[Test]
		public void IntegerDivisibleByThreeReturnsFizzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string integerWord = fb.GenerateString(3);

			Assert.That(integerWord, Is.EqualTo("Fizz"));
		}

		[Test]
		public void IntegerDivisibleByFiveReturnsBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string integerWord = fb.GenerateString(5);

			Assert.That(integerWord, Is.EqualTo("Buzz"));
		}

		[Test]
		public void IngeterDivisibleByThreeAndFiveReturnsFizzBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string integerWord = fb.GenerateString(15);

			Assert.That(integerWord, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void IntegerNotDivisibleByThreeOrFiveReturnsItselfTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string integerWord = fb.GenerateString(11);

			Assert.That(integerWord, Is.EqualTo("11"));
		}

		[Test]
		public void CanGenerateExpectedOutputTest()
		{
			FizzBuzz fb = new FizzBuzz();

			int minimum = 1;
			int maximum = 15;

			string output = fb.GenerateOutput(minimum, maximum);

			Assert.That(output, Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
		}

	}
}
