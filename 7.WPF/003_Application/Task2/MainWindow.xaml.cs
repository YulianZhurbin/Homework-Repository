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
using System.IO;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int operand1;
        private int operand2;
        private Operation operation;

        bool isOperand1Set = false;
        bool isOperationSet = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowFileText(string path)
        {
            string fileContent = File.ReadAllText(path);
            Content = fileContent;
        }

        #region Number Event Handlers
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "0";
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "1";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "3";
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "4";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "5";
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "6";
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "7";
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "8";
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text += "9";
        }
        #endregion

        #region Operation Event Handlers
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = Operation.Add;
            SetOperand1();
            isOperationSet = true;
        }

        private void ButtonSubstract_Click(object sender, RoutedEventArgs e)
        {
            operation = Operation.Substract;
            SetOperand1();
            isOperationSet = true;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = Operation.Multiply;
            SetOperand1();
            isOperationSet = true;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = Operation.Divide;
            SetOperand1();
            isOperationSet = true;
        }
        #endregion

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if(isOperationSet)
            {
                SetOperand2();
                MakeOperation();
            }
        }

        private void SetOperand1()
        {
            if (textBoxName.Text != string.Empty)
            {
                operand1 = Int32.Parse(textBoxName.Text);
                textBoxName.Clear();
                isOperand1Set = true;
            }
            else
            {
                MessageBox.Show("You didn't enter the first operand!");
                ClearData();
            }
        }

        private void SetOperand2()
        {
            if (textBoxName.Text != string.Empty && isOperand1Set)
            {
                operand2 = Int32.Parse(textBoxName.Text);
                textBoxName.Clear();
            }

        }

        private void MakeOperation()
        {
            if (operation == Operation.Add)
            {
                operand1 += operand2;
            }
            else if (operation == Operation.Substract)
            {
                operand1 -= operand2;
            }
            else if (operation == Operation.Multiply)
            {
                operand1 *= operand2;
            }
            else if (operation == Operation.Divide)
            {
                try
                {
                    operand1 /= operand2;
                }
                catch (Exception e)
                {
                    ClearData();
                    MessageBox.Show("Number cannot be divided on 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Unknown operation");

                ClearData();
            }

            textBoxName.Text = operand1.ToString();
            isOperationSet = false;
        }

        private void ClearData()
        {
            isOperand1Set = false;
            isOperationSet = false;
            textBoxName.Clear();
        }
    }
}