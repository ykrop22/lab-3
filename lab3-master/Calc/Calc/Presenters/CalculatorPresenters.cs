using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Calc.Models;
using Calc.Views;


namespace Calc.Presenters
{
    class CalculatorPresenters
    {
        Calculator _calculator = new Calculator();

        private ICalculator calculatorView;

        public CalculatorPresenters(ICalculator view)
        {
            calculatorView = view;
        }

        public void ConnectBetweenModelAndView()
        {
            _calculator.NumberOne = Convert.ToDouble(calculatorView.TxtNumberOne);
            _calculator.NumberTwo = Convert.ToDouble(calculatorView.TxtNumberTwo);
        }

        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalcSumation().ToString();
        }
        public void CalcSub()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalcSubstraction().ToString();
        }
        public void CalcMul()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = _calculator.CalcMultiplication().ToString();
        }
        public void CalcDiv()
        {
            ConnectBetweenModelAndView();
            if (Convert.ToDouble(calculatorView.TxtNumberTwo) == 0)
            {
                MessageBox.Show("Can't divide into zero");
            }
            else
            {
                calculatorView.TxtResult = _calculator.CalcDivision().ToString();
            }
        }

    }
}
