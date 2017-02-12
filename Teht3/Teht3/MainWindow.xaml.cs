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

        int parInt;
        bool isNumber = false;
        int n;
        string howManyLetters;
        char[] checkArray;

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
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
                    //txbRows.Text = "Lotto\n";
                }
                else if (vikingItem.IsSelected)
                {
                    lotTruth = new bool[49];
                    lotteryNumbers = 49;
                    rownumbers = 6;
                    //txbRows.Text = "Viking Lotto\n";
                }
                else if (euroItem.IsSelected)
                {
                    lotTruth = new bool[51];
                    lotteryNumbers = 51;
                    rownumbers = 7;
                    //txbRows.Text = "Eurojackpot\n";
                }

                //arvotaan numerot
                if (txtDraws.Text == "")
                {
                    draws = 0;
                }
                //else if() sisältää muuta kuin kokonaisluvun
                else
                {
                    //draws = Int32.Parse(txbRows.Text);
                }
                //kaatuu jos null
                draws = System.Convert.ToInt32(txtDraws.Text);
                lot = new int[draws, rownumbers];

                for (int z = 0; z < draws; z++)
                {
                    for (int i = 0; i < rownumbers; i++)
                    {
                        x = rnd.Next(1, lotteryNumbers);
                        while (lotTruth[x] == true)
                        {
                            x = rnd.Next(1, lotteryNumbers);
                        }
                        lot[z, i] = x;
                        lotTruth[x] = true;
                    }
                    for (int i = 0; i < lotteryNumbers; i++)
                    {
                        lotTruth[i] = false;
                    }
                }

                //tulostus
                rowcount = 1;
                rownumbersMinus = rownumbers - 1;
                txbRows.Text = "";
                for (int i = 0; i < draws; i++)
                {
                    for (int a = 0; a < rownumbers; a++)
                    {
                        if (a == 0)
                        {
                            txbRows.Text = txbRows.Text + "Row " + rowcount + ": ";
                        }
                        if (euroItem.IsSelected)
                        {
                            if (a == 5)
                            {
                                txbRows.Text = txbRows.Text + " + ";
                            }
                        }
                        txbRows.Text = txbRows.Text + lot[i, a].ToString();
                        if (a < rownumbersMinus)
                        {
                            if (euroItem.IsSelected && a == 4)
                            {
                            }
                            else
                            {
                                txbRows.Text = txbRows.Text + ", ";
                            }
                        }
                        else if (a == rownumbersMinus)
                        {
                            if(i != draws-1)
                            {
                                txbRows.Text = txbRows.Text + "\n";
                            }
                        }
                    }
                    rowcount++;
                }
            }
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbRows.Text = "";
            txtDraws.Text = "";
        }
    }
}
