using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("String Calculator\n");
			Console.WriteLine("Please enter input\n");
			var strInput = Console.ReadLine();

			Calcultor calc = new Calcultor(strInput);
            calc.CalculateNumbers();
		}
	}
}
