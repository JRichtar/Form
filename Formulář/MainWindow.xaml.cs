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

namespace Hesla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textboxFn.Text.Length > 0)
            {
                labelErrorFn.Content = "";
                if (textboxLn.Text.Length > 0)
                {
                    labelErrorLn.Content = "";
                    if (comboboxEd.Text.Length > 0)
                    {
                        labelErrorJob.Content = "";
                        if (textboxJob.Text.Length > 0)
                        {
                            labelErrorPm.Content = "";
                            if (textboxPm.Text.Length > 0)
                            {
                                Employee employee = new Employee(textboxJob.Text, Int16.Parse(textboxPm.Text), comboboxEd.Text, textboxFn.Text, textboxLn.Text, Int16.Parse(textboxBd.Text));
                                labelLogin.Content = employee;
                                button2.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                labelErrorPm.Content = "*Blank textbox!";
                            }
                        }
                        else
                        {
                            labelErrorJob.Content = "*Blank textbox!";
                        }
                    }
                    else
                    {
                        labelErrorEd.Content = "*Choose one option!";
                    }
                }
                else
                {
                   labelErrorLn.Content = "*Your last name is too short!";
                }
            }
            else
            {
                labelErrorFn.Content = "*Your first name is too short!";
            }             
        }  

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public partial class Human : Window
    {
        public string firstName;
        public string lastName;
        public int birthDate;

        public Human(string fn, string ln, int bd)
        {
            firstName = fn;
            lastName = ln;
            birthDate = bd;
        }
    }

    public partial class Employee : Human
    {
        public string workPosition;
        public int payment;
        public string highestEducation;

        public Employee(string wp, int pm, string he, string fn, string ln, int bd) : base(fn, ln, bd)
        {
            workPosition = wp;
            payment = pm;
            highestEducation = he;
        }

        
    }

}
