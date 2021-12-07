
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Formulář
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            University.InitUniversities();
            Universities.DataContext = University.AllUniversities;
        }

        private void Universities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            University u = ((KeyValuePair<string, University>)(sender as ListView).SelectedItem).Value;
            DataContext = u;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Universities.SelectedIndex = 0;
        }
    }
}
