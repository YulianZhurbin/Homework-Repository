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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int minMonthlyIncome = 0;
        private readonly int maxMonthlyIncome = 10000;
        private readonly int maxCreditFactor = 40;

        public MainWindow()
        {
            InitializeComponent();
            slider1.Maximum = maxCreditFactor * maxMonthlyIncome;
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int maxAllowedCredit = int.Parse(monthlyIncomeTextBox.Text) * maxCreditFactor;

            if (e.NewValue < maxAllowedCredit)
            {
                int sliderValue = (int)e.NewValue;
                allowedCreditTextBlock.Text = sliderValue.ToString();
            }
            else
            {
                allowedCreditTextBlock.Text = maxAllowedCredit.ToString();
            }
        }

        private void MonthlyIncomeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Int32.TryParse(monthlyIncomeTextBox.Text, out int monthlyIncome))
            {
                if (monthlyIncome < minMonthlyIncome)
                {
                    monthlyIncomeTextBox.Text = minMonthlyIncome.ToString();
                }
                if (monthlyIncome > maxMonthlyIncome)
                {
                    monthlyIncomeTextBox.Text = maxMonthlyIncome.ToString();
                }
            }
            else
            {
                monthlyIncomeTextBox.Text = minMonthlyIncome.ToString();
            }
        }
    }
}
