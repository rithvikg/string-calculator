using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            List<int> negativeNumbers = new List<int>();

            string[] delimiterChars =
            {
                ",",
                "\\n",
                ""    //Placeholder for custome delimiter
            };

            var delimiter = Regex.Match(calcInput, @"//(.)\\n\d").Groups[1].Value;
            if (delimiter.Length > 0)
            {
                delimiterChars[2] = delimiter;
            }
           
            var numList = calcInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < numList.Length; i++)
			{
				int.TryParse(numList[i], out int n);

                if (n < 0)
                {
                    negativeNumbers.Add(n);
                }
                else if (n > 1000)
                {
                    continue;
                }
                else
                {
                    result += n;
                }
			}
            if (negativeNumbers.Count > 0)
            {
                string negNum = string.Join(",", negativeNumbers.ToArray()); //Converting list to string to print in exception
                throw new Exception("Negative Numbers Not Allowed. Negative Numbers Inputted: " + negNum);
            }
			Console.WriteLine("\n" + result);
            
        }
    }
}
