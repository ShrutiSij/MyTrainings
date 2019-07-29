namespace CalculatorWPFApp
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber;
        double secondNumber;
        double calculatedResult;
        Operators selectedOperator;
        bool isCalculate;
        string reset = "0";
        public MainWindow()
        {
            InitializeComponent();
            deleteBtn.Click += DeleteBtn_Click;
            SetFontSize();
        }

        #region private methods
        private void Num_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32((sender as Button).Content);
              
            MathematicalEquation.Content = MathematicalEquation.Content.ToString().Equals(reset) ? $"{number}" : $"{MathematicalEquation.Content}{number}";

            if (selectedOperator == Operators.None)
            {
                firstNumber = GetLastNumber();
                isCalculate = false;
            }
            else
            {
                secondNumber = GetLastNumber();
                isCalculate = true;
            }
            SetFontSize();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            if (isCalculate)
            {
                Result.Content = Calculate();
                selectedOperator = Operators.None;                
                firstNumber = calculatedResult;
                secondNumber = 0;
                isCalculate = false;
            }
          
            MathematicalEquation.Content = $"{MathematicalEquation.Content}{(sender as Button).Content.ToString()}";
            if (sender == multiplicationBtn)
                selectedOperator = Operators.Multiplication;
            if (sender == divisionBtn)
                selectedOperator = Operators.Division;
            if (sender == plusBtn)
                selectedOperator = Operators.Addition;
            if (sender == minusBtn)
                selectedOperator = Operators.Sustraction;
            SetFontSize();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            MathematicalEquation.FontSize = 50;
            MathematicalEquation.Content = Calculate();
            Result.Content = string.Empty;          
            firstNumber = 0;
            secondNumber = 0;
            calculatedResult = 0;
            selectedOperator = Operators.None;
            isCalculate = false;
        }
        private string Calculate()
        {
            switch (selectedOperator)
            {
                case Operators.Addition:
                    calculatedResult = firstNumber + secondNumber;
                    break;
                case Operators.Sustraction:
                    calculatedResult = firstNumber - secondNumber;
                    break;
                case Operators.Multiplication:
                    calculatedResult = firstNumber * secondNumber;
                    break;
                case Operators.Division:
                    if (secondNumber == 0)
                    {
                        MathematicalEquation.FontSize = 25;
                        return "Cannot divide by zero.";
                    }
                    else
                    {
                        calculatedResult = firstNumber / secondNumber;
                    }
                    break;
            }
            return calculatedResult.ToString();
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = Regex.Split(MathematicalEquation.Content.ToString(), @"\D+");         
            int number = int.Parse(numbers[numbers.Length - 1]);
            if (!number.ToString().Contains("."))
            {
                MathematicalEquation.Content = $"{MathematicalEquation.Content}.";
            }
        }

        private void Ac_Click(object sender, RoutedEventArgs e)
        {
            ResetCalculator();
        }

        private double GetLastNumber()
        {
            string[] numbers = Regex.Split(MathematicalEquation.Content.ToString(), @"[^0-9\.]+");
            //Regex.Split(MathematicalEquation.Content.ToString(), @"\D+");           
            return Convert.ToDouble(numbers[numbers.Length - 1]);
        }
        private void ResetCalculator()
        {
            firstNumber = 0;
            secondNumber = 0;
            calculatedResult = 0;
            selectedOperator = Operators.None;
            isCalculate = false;
            MathematicalEquation.Content = reset;
            Result.Content = string.Empty;
            MathematicalEquation.FontSize = 50;
        }
        private void SetFontSize()
        {
            if (MathematicalEquation.Content.ToString().Length > 21)
            {
                MathematicalEquation.FontSize = 18;
            }
            else if (MathematicalEquation.Content.ToString().Length > 14)
            {
                MathematicalEquation.FontSize = 25;
            }
            else
            {
                MathematicalEquation.FontSize = 38;
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            string content = MathematicalEquation.Content.ToString();
            MathematicalEquation.Content = content.Remove(content.Length-1);
        }

        
        #endregion 
    }
}