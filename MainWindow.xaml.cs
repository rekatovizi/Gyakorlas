using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szam1 = 0;
        int counter = 0;
        bool plusz = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click_1(object sender, RoutedEventArgs e)
        {
            szam1 = 1;
            
            counter += 1;
            
            txb_eredmeny.Text = counter.ToString();
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            szam1 = 2;
            
            counter += 2;
            
            txb_eredmeny.Text = counter.ToString();


        }

        private void btn_plusz_Click(object sender, RoutedEventArgs e)
        {
            bool plusz = true;
            txb_eredmeny.Text = plusz.ToString();
        }

        private void btn_eredmeny_Click(object sender, RoutedEventArgs e)
        {
            txb_eredmeny.Text = counter.ToString();
        }
    }
}