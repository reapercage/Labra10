using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Lotto
    {
        private Random rnd = new Random();
        private int[,] lot;
        private bool[] lotTruth;
        private int x;
        private int draws;
        private int lotteryNumbers;
        private int rownumbers;
        private int rownumbersMinus;
        private int rowcount;
        private string printText;
        private bool europot;

        public Lotto()
        {

        }

        public Lotto(int LotteryNumbers, int Rownumbers, int Draws, bool Europot)
        {
            lotteryNumbers = LotteryNumbers;
            rownumbers = Rownumbers;
            draws = Draws;
            europot = Europot;
        }

        //int lotteryNumbers, int rownumbers, int draws, bool europot
        public string Game(int lotteryNumbers, int rownumbers, int draws, bool europot)
        {
            //rand
            lot = new int[draws, rownumbers];
            bool[] lotTruth = new bool[lotteryNumbers];
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

                //print
                rowcount = 1;
                rownumbersMinus = rownumbers - 1;
                printText = "";
                for (int i = 0; i < draws; i++)
                {
                    for (int a = 0; a < rownumbers; a++)
                    {
                        if (a == 0)
                        {
                            printText = printText + "Row " + rowcount + ": ";
                        }
                        if (europot)
                        {
                            if (a == 5)
                            {
                                printText = printText + " + ";
                            }
                        }
                        printText = printText + lot[i, a].ToString();
                        if (a < rownumbersMinus)
                        {
                            if (europot && a == 4)
                            {
                            }
                            else
                            {
                                printText = printText + ", ";
                            }
                        }
                        else if (a == rownumbersMinus)
                        {
                            if (i != draws - 1)
                            {
                                printText = printText + "\n";
                            }
                        }
                    }
                    rowcount++;
                }
            return printText;
            }
        
    }
}
