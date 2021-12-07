using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;

namespace Formulář
{
    class University : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;



        private string state;
        public string State
        {
            get => state;
            set { state = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("State")); }
        }



        private int established;
        public int Established
        {
            get => established;
            set { established = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Established")); }
        }



        private string address;
        public string Address
        {
            get => address;
            set { address = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Address")); }
        }



        private double successRate;
        public double SuccessRate
        {
            get => successRate;
            set { successRate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SuccessRate")); }
        }
        private decimal tuition;
        public decimal Tuition
        {
            get => tuition;
            set { tuition = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tuition")); }
        }



        public static Dictionary<string, University> AllUniversities = new Dictionary<string, University>();



        public static void InitUniversities()
        {
            AllUniversities["MIT"] = new University
            {
                State = "Massachusets",
                Established = 1861,
                Address = "Cambridge, USA",
                SuccessRate = 93.0,
                Tuition = 19700.0m
            };



            AllUniversities["Yale"] = new University
            {
                State = "New Haven",
                Established = 1701,
                Address = "New Haven, USA",
                SuccessRate = 94.0,
                Tuition = 18700.0m
            };



            AllUniversities["Cornell"] = new University
            {
                State = "New York",
                Established = 1865,
                Address = "Ithaca, NY, USA",
                SuccessRate = 94.0,
                Tuition = 69700.0m
            };
        }
    }
}
