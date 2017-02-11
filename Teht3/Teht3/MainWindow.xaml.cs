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

        Random rnd = new Random();
        int[,] lot;
        bool[] lotTruth = new bool[40];
        int[] vikingLotto = new int[6];
        bool[] vikingTruth = new bool[49];
        int[] europot = new int[7];
        bool[] euroTruth = new bool[51];
        int x;
        bool newText = false;
        int rowcount;
        int draws;

        List<int[]> lottoRows = new List<int[]>();
        //tilalle 2. ulotteinen taulukko

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            draws = System.Convert.ToInt32(txtDraws.Text);
            lot = new int[draws,7];
            //for rivit
            //if lotto, numerot 7, 40:stä
            if (lottoItem.IsSelected == true)
            {
                //for draws
                for(int z = 0; z < draws; z++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        x = rnd.Next(1, 40);
                        while (lotTruth[x] == true)
                        {
                            x = rnd.Next(1, 40);
                        }
                        lot[z,i] = x;
                        lotTruth[x] = true;
                    }
                    for (int i = 0; i < 40; i++)
                    {
                        lotTruth[i] = false;
                    }
                    //lottoRows.Add(lot);
                }
            }
            if (vikingItem.IsSelected == true)
            {
                for (int i = 0; i < 6; i++)
                {
                    x = rnd.Next(1, 49);
                    while (vikingTruth[x] == true)
                    {
                        x = rnd.Next(1, 49);
                    }
                    vikingLotto[i] = x;
                    vikingTruth[x] = true;
                }
                for (int i = 0; i < 49; i++)
                {
                    vikingTruth[i] = false;
                }
            }
            if (euroItem.IsSelected == true)
            {
                for (int i = 0; i < 7; i++)
                {
                    x = rnd.Next(1, 51);
                    while (euroTruth[x] == true)
                    {
                        x = rnd.Next(1, 51);
                    }
                    europot[i] = x;
                    euroTruth[x] = true;
                }
                for (int i = 0; i < 51; i++)
                {
                    euroTruth[i] = false;
                }
            }

            newText = true;
            rowcount = 1;
            foreach(int[] row in lottoRows)
            {
                if(newText == true)
                {
                    //txbRows.Text = "Row " + rowcount + ": ";
                }
                else
                {
                    //txbRows.Text = txbRows.Text + "\nRow " + rowcount + ": ";
                }
                foreach (int number in row)
                {
                    //txbRows.Text = txbRows.Text + number + ", ";
                }
                newText = false;
                rowcount++;
            }

            rowcount = 1;
            //vaihtoehtoinen tulostus
            for(int i = 0; i < draws; i++)
            {
                if (i == 0)
                {
                    txbRows.Text = "";
                }
                for (int a = 0; a < 7; a++)
                {
                    if(a == 0)
                    {
                        txbRows.Text = txbRows.Text + "Row " + rowcount + ": ";
                    }
                    txbRows.Text = txbRows.Text + lot[i,a].ToString();
                    if(a < 6)
                    {
                        txbRows.Text = txbRows.Text + ", ";
                    }
                    else if(a == 6)
                    {
                        txbRows.Text = txbRows.Text + "\n";
                    }
                }
                rowcount++;
            }
            
            
            //vanha tulostus
            for(int i = 0; i < 7; i++)
            {
                if(i == 0)
                {
                    //txbRows.Text = lot[i].ToString();
                }
                else
                {
                    //txbRows.Text = txbRows.Text + ", " + lot[i].ToString();
                }
            }

        }
    }
}
