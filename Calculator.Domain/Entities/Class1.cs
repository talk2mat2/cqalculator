using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Entities
{
    public class CalculationRequest
    {
        public string Input { get; set; }
        public bool ShowFormula { get; set; }
    }
}
