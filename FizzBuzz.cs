using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata2
{
	public class FizzBuzz
	{

		public bool IsDivisibleByThree(int input)
		{
			return (input % 3) == 0;
		}

		public bool IsDivisibleByFive(int input)
		{
			return (input % 5) == 0;
		}

		public string GenerateString(int input)
		{
			if (IsDivisibleByFive(input) && IsDivisibleByThree(input))
			{
				return "FizzBuzz";
			}
			else if(IsDivisibleByThree(input))
			{
				return "Fizz";
			}
			else if (IsDivisibleByFive(input))
			{
				return "Buzz";
			}
			else
			{
				return input.ToString();
			}
		}

		public string GenerateOutput(int minimum, int maximum)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = minimum; i <= maximum; i++)
			{
				sb.AppendFormat("{0} ", GenerateString(i));
			}

			return sb.ToString();
		}
	}
}
