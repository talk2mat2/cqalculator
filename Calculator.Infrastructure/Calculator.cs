﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Calculator.Domain.Interfaces;
using System.Text.RegularExpressions;

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
            
            string pattern = @"[, \\n # // *** rr r9r]+";

            var resultNumbers = Regex.Split(input, pattern);
            return ProcessNumbers(resultNumbers, out formula);
        }

        private int ProcessNumbers(string[] numbers, out string formula)
        {
            //if (numbers.Length > 2)
            //    throw new Exception("Number cant be graeter than two.");

            var negativeNumbers = new List<int>();

            int result = 0;
            formula = "";

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int value))
                {
                    if (value < 0)
                    {
                        negativeNumbers.Add(value);
                    }
                  
                    if(negativeNumbers.Count > 0)
                    {
                        throw new Exception("Negative number not allowed.");
                    }
                    else if (value <= 1000)
                    {
                        result += value;
                    }

                    //result += value;

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
