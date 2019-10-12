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

		public void CalculateNumbers()
		{
			int result = 0;
			string calcInput = getInput();
			string[] numList = calcInput.Split(",");

			
			
			for (int i = 0; i < numList.Length; i++)
			{
				int.TryParse(numList[i], out int n);
				result += n;
			}
			Console.WriteLine("\n" + result);
		}
	}
}
