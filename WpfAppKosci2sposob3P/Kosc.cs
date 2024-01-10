using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKosci2sposob3P
{
    public class Kosc : INotifyPropertyChanged
    {
        private int _wartosc;
        public int Wartosc {
            get =>_wartosc;
            set
            {
                _wartosc = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Wartosc)));
                }
            } 
        }
        public bool CzyZaznaczona { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
