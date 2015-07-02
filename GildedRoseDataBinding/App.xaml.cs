using System.Windows;
using GildedRoseDataBinding.Model;

namespace GildedRoseDataBinding
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var clothes = new Clothes(Type.Standard)
                          {
                              Name = "Dexterity Vest",
                              Quality = 20,
                              Durability = 16
                          };
            MainWindow = new MainWindow { DataContext = clothes };
            MainWindow.Show();
        }
    }
}
