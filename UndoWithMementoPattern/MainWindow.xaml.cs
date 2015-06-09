using System.Windows;
using System.Windows.Input;

namespace UndoWithMementoPattern
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Caretaker _caretaker;

        public MainWindow()
        {
            InitializeComponent();

            _caretaker = new Caretaker(InkCanvasOriginator);
        }

        private void InkCanvasOriginator_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _caretaker.RequestMemento();
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _caretaker.Undo();
        }
    }
}