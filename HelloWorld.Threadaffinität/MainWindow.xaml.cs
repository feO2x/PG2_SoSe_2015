using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWorld.Threadaffinität
{
    public partial class MainWindow : Window
    {
        private List<int> _divisoren;

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

            _divisoren = Enumerable.Range(untereGrenze, obereGrenze - untereGrenze + 1)
                                      .ToList();

            var task = new Task(BerechneAufHintergrundthread);
            task.Start();
        }

        private void BerechneAufHintergrundthread()
        {
            for (long i = 1; i <= int.MaxValue; i++)
            {
                if (ÜberprüfeTeilbarkeit(i, _divisoren))
                {
                    Dispatcher.BeginInvoke(new Action<long>(ZeigeErgebnis), i);
                    break;
                }
            }
        }

        private void ZeigeErgebnis(long ergebnis)
        {
            ErgebnisTextBlock.Text = "Die gesuchte Zahl ist " + ergebnis.ToString("N0");
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
