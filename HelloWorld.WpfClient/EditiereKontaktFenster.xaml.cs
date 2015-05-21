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
using System.Windows.Shapes;

namespace HelloWorld.WpfClient
{
    public partial class EditiereKontaktFenster : Window
    {
        private Kontakt _editierterKontakt;
        public Kontakt EditierterKontakt
        {
            get { return _editierterKontakt; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                _editierterKontakt = value;
                UpdateControlsMitKontaktInfos();
            }
        }

        private void UpdateControlsMitKontaktInfos()
        {
            VornameTextBox.Text = _editierterKontakt.Vorname;
            NachnameTextBox.Text = _editierterKontakt.Nachname;
            GeburtsdatumDatePicker.SelectedDate = _editierterKontakt.Geburtsdatum;
            TelefonTextBox.Text = _editierterKontakt.Telefon;
            EmailTextBox.Text = _editierterKontakt.Email;
        }

        public EditiereKontaktFenster()
        {
            InitializeComponent();
        }

        private void WennOkGedrücktWird(object sender, RoutedEventArgs e)
        {
            UpdateKontaktMitControlInfos();
            DialogResult = true;
            Close();
        }

        private void UpdateKontaktMitControlInfos()
        {
            _editierterKontakt.Vorname = VornameTextBox.Text;
            _editierterKontakt.Nachname = NachnameTextBox.Text;
            _editierterKontakt.Geburtsdatum = GeburtsdatumDatePicker.SelectedDate;
            _editierterKontakt.Telefon = TelefonTextBox.Text;
            _editierterKontakt.Email = EmailTextBox.Text;
        }

        private void WennAbbrechenGedrücktWird(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
