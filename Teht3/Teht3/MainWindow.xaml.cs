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

namespace Teht3
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

        //muuttujat
        Random rnd = new Random();
        int[,] lot;
        bool[] lotTruth;
        int x;
        int draws;
        int lotteryNumbers;
        int rownumbers;
        int rownumbersMinus;
        int rowcount;
        bool europot;
        string asdf;

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            europot = false;
            if (emptyItem.IsSelected)
            {

            }
            else
            {
                //arvot pelin mukaan
                if (lottoItem.IsSelected)
                {
                    lotTruth = new bool[40];
                    lotteryNumbers = 40;
                    rownumbers = 7;
                }
                else if (vikingItem.IsSelected)
                {
                    lotTruth = new bool[49];
                    lotteryNumbers = 49;
                    rownumbers = 6;
                }
                else if (euroItem.IsSelected)
                {
                    lotTruth = new bool[51];
                    lotteryNumbers = 51;
                    rownumbers = 7;
                    europot = true;
                }
                //arvotaan numerot
                if (txtDraws.Text != "")
                {
                    draws = System.Convert.ToInt32(txtDraws.Text);
                    //kaatuu jos null tai jtn
                    Lotto lottery = new Lotto();
                    txbRows.Text = lottery.Game(lotteryNumbers, rownumbers, draws, europot);
                }
                //else if() sisältää muuta kuin kokonaisluvun

            }
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbRows.Text = "";
            txtDraws.Text = "";
            emptyItem.IsSelected = true;
        }
    }
}
