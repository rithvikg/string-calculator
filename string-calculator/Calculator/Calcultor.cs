using System;
using System.Collections.Generic;
using System.Text;

namespace string_calculator
{
	
	class Calcultor
	{
		private string input;

		public Calcultor(string input)
		{
			SetInput(input);

		}

		public void SetInput(string input)
		{
			this.input = input;
		}

		public string getInput()
		{
			return input;
		}

		public void CalculateTwoNumbers()
		{
			int result = 0;
			string CalcInput = getInput();
			string[] NumList = CalcInput.Split(",");

			if (NumList.Length <= 2)
			{
				for (int i = 0; i < NumList.Length; i++)
				{
					int.TryParse(NumList[i], out int n);
					result += n;
				}
			}
			else
			{
				throw new Exception("More than two arguments given");
			}
			Console.WriteLine(result);

		}
	}
}
