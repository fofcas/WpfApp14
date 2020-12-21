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

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double Fac(int n)
        {
            double fac = 1;
            for (int i = 2; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = int.Parse(voda.Text);
                int n = int.Parse(vodb.Text);
                double N = 1;

                for (int i = 1; i < n; i++)
                {
                    
                    N += (Math.Pow(x, i)) / (Fac(i));
                    
                }
                Math.Round(N,2);
                vivod.Text+=N+"  ";

            
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


