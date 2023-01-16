using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MVC1
{
    internal class Model
    {
        public static List<string> calculateManipulation = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> operationSymbols = new List<string> { "+", "-", "*", "/" };


        public static TextBox firstNumber;
        public static TextBox secondNumber;
        public static TextBox answer;
        public static TextBlock calculateSymbol;

        public static double GetAnswer
        {
            get
            {
                return GetAnswer;
            }
            set
            {
                try
                {
                    switch (value)
                    {
                        case 0:
                            answer.Text = Convert.ToString(Convert.ToDouble(firstNumber.Text) + Convert.ToDouble(secondNumber.Text));
                            break;
                        case 1:
                            answer.Text = Convert.ToString(Convert.ToDouble(firstNumber.Text) - Convert.ToDouble(secondNumber.Text));
                            break;
                        case 2:
                            answer.Text = Convert.ToString(Convert.ToDouble(firstNumber.Text) * Convert.ToDouble(secondNumber.Text));
                            break;
                        case 3:
                            answer.Text = Convert.ToString(Convert.ToDouble(firstNumber.Text) / Convert.ToDouble(secondNumber.Text));
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        public static int GetSymbolCalculating
        {
            set
            {
                calculateSymbol.Text = operationSymbols[value];
            }
        }

    }
}
