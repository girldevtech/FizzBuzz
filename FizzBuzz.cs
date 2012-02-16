using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata
{
	public class FizzBuzz
	{

		public string GenerateOutput(int minimum, int maximum)
		{
			StringBuilder sb = new StringBuilder();
			
			for (int i = minimum; i <= maximum; i++)
			{
				sb.AppendFormat("{0} ",ReplaceNumberWithString(i));
			}

			return sb.ToString();
		}

		public bool IsDivisibleByThree(int input)
		{
			return (input % 3) == 0;
		}

		public string ReplaceNumberWithString(int input)
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

		public bool IsDivisibleByFive(int input)
		{
			return (input % 5) == 0;
		}
	}
}
