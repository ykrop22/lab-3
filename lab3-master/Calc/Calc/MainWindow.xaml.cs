using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calc.Models;
using Calc.Views;
using Calc.Presenters;





namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICalculator
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string TxtNumberOne { get => txtNumberOne.Text; set => txtNumberOne.Text = value; }
        public string TxtNumberTwo { get => txtNumberTwo.Text; set => txtNumberTwo.Text = value; }
        public string TxtResult { get => txtResult.Text; set => txtResult.Text = value; }

        private CalculatorPresenters presenter;

      

        private void BtnSum(object sender, RoutedEventArgs e)
        {
            presenter = new CalculatorPresenters(this);
            presenter.CalcSum();
        }

        private void BtnSub(object sender, RoutedEventArgs e)
        {
            presenter = new CalculatorPresenters(this);
            presenter.CalcSub();
        }

        private void BtnMul(object sender, RoutedEventArgs e)
        {
            presenter = new CalculatorPresenters(this);
            presenter.CalcMul();
        }

        private void BtnDiv(object sender, RoutedEventArgs e)
        {
            presenter = new CalculatorPresenters(this);
            presenter.CalcDiv();
        }
    }
}
