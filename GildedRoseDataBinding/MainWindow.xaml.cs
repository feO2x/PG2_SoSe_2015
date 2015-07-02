using GildedRoseDataBinding.Model;
using System.Windows;

namespace GildedRoseDataBinding
{
    public partial class MainWindow : Window
    {
        public Article Article
        {
            get { return (Article) DataContext; }
            set { DataContext = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WhenButtonIsClicked(object sender, RoutedEventArgs e)
        {
            var article = Article;
            if (article == null)
                return;

            article.Update();
        }
    }
}
