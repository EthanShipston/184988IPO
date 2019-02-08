/* Ethan Shipston
 * 2/8/2019
 * A program which calculates the area for you
 */
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

namespace _184988IPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal width;
        decimal length;
        decimal area;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(txtWidth.Text, out width);
            decimal.TryParse(txtLength.Text, out length);

            area = width * length;
            
            lblOutput.Content = "The area is: " + area.ToString("#.00");
        }
    }
}