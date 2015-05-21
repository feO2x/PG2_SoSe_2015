using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace HelloWorld.WpfClient
{
    public partial class MainWindow : Window
    {
        public IList<Kontakt> Kontakte
        {
            get { return MasterListBox.ItemsSource as IList<Kontakt>; }
            set { MasterListBox.ItemsSource = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            LeereTextblöcke();

            Kontakte = new ObservableCollection<Kontakt>
            {
                new Kontakt{Vorname = "Walter", Nachname = "White", Geburtsdatum = new DateTime(1958, 5, 20), Email = "walter@white.com"},
                new Kontakt{Vorname = "Jesse", Nachname = "Pinkman", Geburtsdatum = new DateTime(1987, 4, 25), Telefon = "312124 12332"}
            };
        }

        private void LeereTextblöcke()
        {
            NameTextBlock.Text = GeburtsdatumTextBlock.Text = TelefonTextBlock.Text = MailTextBlock.Text = string.Empty;
        }

        private void WennKontaktAusgewähltWird(object sender, SelectionChangedEventArgs e)
        {
            var selektierterKontakt = MasterListBox.SelectedItem as Kontakt;

            NameTextBlock.Text = selektierterKontakt.VollerName;
            GeburtsdatumTextBlock.Text = "Geburtsdatum: ";
            if (selektierterKontakt.Geburtsdatum.HasValue)
                GeburtsdatumTextBlock.Text += selektierterKontakt.Geburtsdatum.Value.ToShortDateString();
            MailTextBlock.Text = "Mail: " + selektierterKontakt.Email;
            TelefonTextBlock.Text = "Telefon: " + selektierterKontakt.Telefon;
        }

        private void WennHinzufügenGedrücktWird(object sender, RoutedEventArgs e)
        {
            var dialog = new EditiereKontaktFenster
                         {
                             EditierterKontakt = new Kontakt()
                         };
            if (dialog.ShowDialog() == true)
            {
                Kontakte.Add(dialog.EditierterKontakt);
            }
        }
    }
}
