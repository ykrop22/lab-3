using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Models
{
    class Calculator
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }

        public double CalcSumation()
        {
            return NumberOne + NumberTwo;
        }
        public double CalcSubstraction()
        {
            return NumberOne - NumberTwo;
        }
        public double CalcMultiplication()
        {
            return NumberOne * NumberTwo;
        }
        public double CalcDivision()
        {
            return NumberOne / NumberTwo;
        }
    }
}
