using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Calculator.Domain.Interfaces;

namespace Calculator.Infrastructure
{
    public class Calculator : ICalculator
    {
        public int Add(string input)
        {
            return Add(input, out _);
        }

        public int Add(string input, out string formula)
        {
            formula = input;
            var resultNumbers = input.Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries);
            return ProcessNumbers(resultNumbers, out formula);
        }

        private int ProcessNumbers(string[] numbers, out string formula)
        {
            //if (numbers.Length > 2)
            //    throw new Exception("Number cant be graeter than two.");

            int result = 0;
            formula = "";

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int value))
                {
                    result += value;

                    if (formula != "")
                    {
                        formula += "+";
                    }
                    formula += value.ToString();
                }
            }
            return result;
        }
    }
}
