using System;
using System.Windows;

namespace MVC1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            actionComboBox.ItemsSource = Model.calculateManipulation;
            Model.firstNumber = firstNumber;
            Model.secondNumber = secondNumber;
            Model.answer = resultTextBox;
            Model.calculateSymbol = operationSymbol;
            actionComboBox.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Model.GetAnswer = actionComboBox.SelectedIndex;
        }

        private void actionComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Model.GetSymbolCalculating = actionComboBox.SelectedIndex;
        }

        private void firstNumber_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != ",")
            {
                e.Handled = true;
            }
        }
    }
}
