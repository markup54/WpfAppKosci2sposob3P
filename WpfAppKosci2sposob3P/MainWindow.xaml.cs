using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppKosci2sposob3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Kosc> rezultaty { get; set; }
        public int LiczbaKosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            rezultaty = new ObservableCollection<Kosc>();
            DataContext = this; // żeby działało bindowanie do XAML


        }

        private void rzuc_btn_Click(object sender, RoutedEventArgs e)
        {
           if(rezultaty.Count ==0) {
                for (int i = 0; i < 10; i++)
                {
                    rezultaty.Add(new Kosc());
                }

            }
            Random random = new Random();
            foreach (Kosc k in rezultaty)
            {
                if (k.CzyZaznaczona == false)

                    k.Wartosc = random.Next(1, 7);
            }
        }

        private void wyczysc_btn_Click(object sender, RoutedEventArgs e)
        {
            rezultaty.Clear();
            for(int i =0;i<10;i++)
            {
                rezultaty.Add(new Kosc());
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
