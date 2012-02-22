using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata5
{
	class FizzBuzz
	{
		public bool IsDivisibleByThree(int p)
		{
			return (p % 3) == 0;
		}

		public bool IsDivisibleByFive(int p)
		{
			return (p % 5) == 0;
		}

		public string GenerateString(int p)
		{
			if (IsDivisibleByFive(p) && IsDivisibleByThree(p))
			{
				return "FizzBuzz";
			}
			else if (IsDivisibleByThree(p))
			{
				return "Fizz";
			}
			else if (IsDivisibleByFive(p))
			{
				return "Buzz";
			}
			else
			{
				return p.ToString();
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
