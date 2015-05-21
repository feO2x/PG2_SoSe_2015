using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace HelloWorld.Threadaffinität
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WennButtonGedrücktWird(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = false;
            ProgressBar.IsIndeterminate = true;

            var untereGrenze = Convert.ToInt32(VonTextBox.Text);
            var obereGrenze = Convert.ToInt32(BisTextBox.Text);

            var divisoren = Enumerable.Range(untereGrenze, obereGrenze - untereGrenze + 1)
                                      .ToList();

            for (long i = 1; i <= int.MaxValue; i++)
            {
                if (ÜberprüfeTeilbarkeit(i, divisoren))
                {
                    ErgebnisTextBlock.Text = "Die gesuchte Zahl ist " + i.ToString("N0");
                    break;
                }
            }

            Button.IsEnabled = true;
            ProgressBar.IsIndeterminate = false;
        }

        private bool ÜberprüfeTeilbarkeit(long zahl, List<int> divisoren)
        {
            foreach (var divisor in divisoren)
            {
                if (zahl % divisor != 0)
                    return false;
            }
            return true;
        }
    }
}
