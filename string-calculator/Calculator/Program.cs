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
            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
            while (true)
            {
                
                Console.WriteLine("\nPlease enter input or hit Ctrl+c to exit program\n");
                var strInput = Console.ReadLine();

                Calculator calc = new Calculator(strInput);
                var result = calc.CalculateNumbers();
            }
		}
        protected static void myHandler(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("\nThe Calculator has Ended due to User Input.");
            System.Environment.Exit(1);
        }
    }
}
