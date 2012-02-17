using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzzKata3
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void InputThreeIsDivisibleByThreeTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisible = fb.IsDivisibleByThree(3);

			Assert.That(isDivisible, Is.True);
		}

		[Test]
		public void InputFiveIsDivisibleByFiveTest()
		{
			FizzBuzz fb = new FizzBuzz();

			bool isDivisible = fb.IsDivisibleByFive(5);

			Assert.That(isDivisible, Is.True);
		}

		[Test]
		public void InputThreeReturnsFizzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string inputWord = fb.GenerateString(3);

			Assert.That(inputWord, Is.EqualTo("Fizz"));
		}

		[Test]
		public void InputFiveReturnsBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string inputWord = fb.GenerateString(5);

			Assert.That(inputWord, Is.EqualTo("Buzz"));
		}

		[Test]
		public void IntegerInputNotFiveOrThreeReturnsItselfTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string inputWord = fb.GenerateString(1);

			Assert.That(inputWord, Is.EqualTo("1"));
		}

		[Test]
		public void InputFifteenReturnsFizzBuzzTest()
		{
			FizzBuzz fb = new FizzBuzz();

			string inputWord = fb.GenerateString(15);

			Assert.That(inputWord, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void RangeOneToFifteenGeneratesExpectedOutputTest()
		{
			FizzBuzz fb = new FizzBuzz();

			int minimum = 1;
			int maximum = 15;

			string outputString = fb.GenerateOutput(minimum, maximum);

			Assert.That(outputString, Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
		}


	}
}
