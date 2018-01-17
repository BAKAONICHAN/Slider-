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

namespace Wallet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWallet wallet = new MainWallet();
            //wallet.Bitcoin = 3;//One Bitcoin=6000tg
            //wallet.Tg = 14000;
            wallet.Bitcoin= 6000*course;
            wallet.MainSum = 30000;
            Halyk.Maximum = 14000;
            bitcoin.Maximum = wallet.Bitcoin;
          
        }
        public int course = 3;
        public double sum;
        public double Tg;
        public double Bit;
        public void Payed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Show();
        }

        public void Halyk_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Show();
        }

        public void Bitcoin_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Show();
        }
        public void Show()
        {
            MainWallet wallet = new MainWallet();
            sum = wallet.MainSum;
            Tg = Halyk.Maximum;
            Bit = wallet.Bitcoin;
            //bitcoin = wallet.Bitcoin;
            //Tg = wallet.Tg;

            if (Tg + Bit >sum)
            {

            }
            sum = Tg + Bit;


        }
    }
}
