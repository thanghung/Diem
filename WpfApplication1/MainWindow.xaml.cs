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

namespace WpfApplication1
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

            double DiemTB = (Double.Parse(litelary.Text) + Double.Parse(math.Text)) / 2;
            string thuong;

            if (DiemTB >= 8 && (bool)good.IsChecked)
                thuong = "SV Good";
            else
                if((DiemTB >= 8 && (bool)enough.IsChecked))
                    thuong = "SV Enough";
            else
                if (DiemTB >= 7 && (bool)enough.IsChecked)
                    thuong = "SV Enough";
            else
                thuong = "No Reward Commended";

            MessageBox.Show("Name SV: " + name.Text
                            + "\nCode SV: " + code.Text
                            + "\nmedium score: " + DiemTB.ToString()
                            + "\nReward Commended: " + thuong);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
