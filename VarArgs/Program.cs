using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarArgs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Сумма значений: " + Sum( 3, 5, 8, 13, 21 ));
			
		}
		static int Sum(params int[] values)
		{
			int sum = 0;
			for(int i=0; i < values.Length; i++)
			{
				sum += values[i];
			}
			return sum;
		}
	}
}
