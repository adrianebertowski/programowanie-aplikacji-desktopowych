using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace zadanie3
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string imieNazwisko;
        private string dataUrodzin;
        private string pierwszeImie;
        private string nazwisko;
        private int wiek;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string ImieNazwisko
        {
            get => imieNazwisko;
            set
            {
                imieNazwisko = value;

                if (!string.IsNullOrWhiteSpace(value))
                {
                    string[] dane = value.Split(
                        new[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                    if (dane.Length > 0)
                    {
                        PierwszeImie = dane[0];
                        Nazwisko = dane[dane.Length - 1];
                    }
                }

                OnPropertyChanged();
            }
        }

        public string DataUrodzin
        {
            get => dataUrodzin;
            set
            {
                dataUrodzin = value;

                if (DateTime.TryParse(value, out DateTime data))
                {
                    Wiek = ObliczWiek(data);
                }

                OnPropertyChanged();
            }
        }

        public string PierwszeImie
        {
            get => pierwszeImie;
            set
            {
                pierwszeImie = value;
                OnPropertyChanged();
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                nazwisko = value;
                OnPropertyChanged();
            }
        }

        public int Wiek
        {
            get => wiek;
            set
            {
                wiek = value;
                OnPropertyChanged();
            }
        }

        private int ObliczWiek(DateTime dataUrodzenia)
        {
            int lata = DateTime.Today.Year - dataUrodzenia.Year;

            if (dataUrodzenia.Date > DateTime.Today.AddYears(-lata))
            {
                lata--;
            }

            return lata;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string nazwa = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(nazwa));
        }
    }
}