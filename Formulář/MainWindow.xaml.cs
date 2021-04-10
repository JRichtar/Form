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
using System.ComponentModel;

namespace Formulář
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Employee em;

        public MainWindow()
        {
            InitializeComponent();

            em = new Employee { FirstName = "Missing", LastName = "Missing", YearOfBirth = "Missing", Job = "Missing", Payment = "Missing" };

            this.DataContext = em;
            labelErrorFn.DataContext = this;
            labelErrorLn.DataContext = this;
            labelErrorBd.DataContext = this;
            labelErrorJob.DataContext = this;
            labelErrorPm.DataContext = this;
        }



        private bool CheckFirstName()
        {
            if (em.FirstName.Length > 0)
            {
                FnErrorVisible = Visibility.Hidden;
                return true;
            }
            else
            {
                FnErrorVisible = Visibility.Visible;
                return false;
            }
        }

        private Visibility _FnErrorVisible;
        public Visibility FnErrorVisible
        {
            get { return _FnErrorVisible; }
            set
            {
                _FnErrorVisible = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FnErrorVisible"));
                }
            }
        }

        private string _FnError = "Needs to be filled!";
        public string FnError { get { return _FnError; } }

        private bool CheckLastName()
        {
            if (em.LastName.Length > 0)
            {
                LnErrorVisible = Visibility.Hidden;
                return true;
            }
            else
            {
                LnErrorVisible = Visibility.Visible;
                return false;
            }
        }

        private Visibility _LnErrorVisible;
        public Visibility LnErrorVisible
        {
            get { return _LnErrorVisible; }
            set
            {
                _LnErrorVisible = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LnErrorVisible"));
                }
            }
        }

        private string _LnError = "Needs to be filled!";
        public string LnError { get { return _LnError; } }

        private bool CheckYear()
        {
            if (em.YearOfBirth.Length > 0)
            {
                BdErrorVisible = Visibility.Hidden;
                return true;
            }
            else
            {
                BdErrorVisible = Visibility.Visible;
                return false;
            }
        }

        private Visibility _BdErrorVisible;
        public Visibility BdErrorVisible
        {
            get { return _BdErrorVisible; }
            set
            {
                _BdErrorVisible = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BdErrorVisible"));
                }
            }
        }

        private string _BdError = "Needs to be filled";
        public string BdError { get { return _BdError; } }

        private bool CheckJob()
        {
            if (em.Job.Length > 0)
            {
                JobErrorVisible = Visibility.Hidden;
                return true;
            }
            else
            {
                JobErrorVisible = Visibility.Visible;
                return false;
            }
        }

        private Visibility _JobErrorVisible;
        public Visibility JobErrorVisible
        {
            get { return _JobErrorVisible; }
            set
            {
                _JobErrorVisible = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("JobErrorVisible"));
                }
            }
        }

        private string _JobError = "Needs to be filled!";
        public string JobError { get { return _JobError; } }

        private bool CheckPayment()
        {
            if (em.Payment.Length > 0)
            {
                PmErrorVisible = Visibility.Hidden;
                return true;
            }
            else
            {
                PmErrorVisible = Visibility.Visible;
                return false;
            }
        }

        private Visibility _PmErrorVisible;
        public Visibility PmErrorVisible
        {
            get { return _PmErrorVisible; }
            set
            {
                _PmErrorVisible = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PmErrorVisible"));
                }
            }
        }

        private string _PmError = "Needs to be filled";
        public string PmError { get { return _PmError; } }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"First name: {em.FirstName} \nLast name: {em.LastName} \nYear of birth: {em.YearOfBirth} \nEducation: {em.HighestEducation} \nJob: {em.Job} \nPayment: {em.Payment}");
            em = new Employee { FirstName = "Missing", LastName = "Missing", YearOfBirth = "Missing", Job = "Missing", Payment = "Missing"};
            Employee.AllEmployees.Add(em);
            this.DataContext = em;
        }

        private void textboxFn_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckFirstName();
        }

        private void textboxLn_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckLastName();
        }

        private void textboxBd_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckYear();
        }

        private void textboxJob_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckJob();
        }

        private void textboxPm_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckPayment();
        }
    }
}
