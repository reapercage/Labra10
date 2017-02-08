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

namespace Teht1
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

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
            // myCheckBox is checked
            if ((bool)chkMilk.IsChecked)
            {
                txt.Text = txt.Text + " milk";
            }
            if ((bool)chkButter.IsChecked)
            {
                txt.Text = txt.Text + " butter";
            }
            if ((bool)chkBeer.IsChecked)
            {
                txt.Text = txt.Text + " Beer";
            }
            if ((bool)chkChicken.IsChecked)
            {
                txt.Text = txt.Text + " chicken";
            }
            if ((bool)chkLemonade.IsChecked)
            {
                txt.Text = txt.Text + " lemonade";
            }
        }
    }
}
