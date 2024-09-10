using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface ICalculatorService
    {
        int Add(string input);
        int Add(string input, out string formula);
    }
}
