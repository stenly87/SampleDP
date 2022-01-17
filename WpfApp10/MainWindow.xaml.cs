using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Human selectedHuman;

        public ObservableCollection<Human> Humans { get; set; } = new ObservableCollection<Human>();
        public Human SelectedHuman
        {
            get => selectedHuman;
            set
            {
                selectedHuman = value;
                Signal();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Humans.Add(new Human());
            Humans.Add(new Human());
            Humans.Add(new Human());

            SelectedHuman = new Human {Name = "выдели меня" };
            Humans.Add(SelectedHuman);
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddHuman(object sender, RoutedEventArgs e)
        {
            Humans.Add(new Human());
        }

        private void DeleteHuman(object sender, RoutedEventArgs e)
        {
            if (SelectedHuman != null)
                Humans.Remove(SelectedHuman);
        }

        private void EditSpecials(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }

    public class Human
    {
        public string Name { get; set; } = "Сергей";
        public Passport Document { get; set; } = new Passport();
    }

    public class Passport
    {
        public string Seria { get; set; } = "144";
        public string Nomer { get; set; } = "888";
    }
}
