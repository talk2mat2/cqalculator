using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Domain.Interfaces;
namespace CalculatorApp.Application.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly ICalculator _calculator;

        public CalculatorService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Add(string input)
        {
            return _calculator.Add(input);
        }

        public int Add(string input, out string formula)
        {
            return _calculator.Add(input, out formula);
        }
    }
}
