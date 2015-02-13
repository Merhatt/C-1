using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int restart = 1;
            while (restart == 1)
            {
                int p1 = 0;
                int p2 = 0;
                int i = 0;
                while (true)
                {




                    string[,] tictactoe = 
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}

            };


                    bool player1 = false;
                    bool player2 = false;
                    bool draw = false;
                    while (true)
                    {




                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                               Player 1 have {0} wins", p1);
                        Console.WriteLine("                               Player 2 have {0} wins", p2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[0, 0], tictactoe[0, 1], tictactoe[0, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[1, 0], tictactoe[1, 1], tictactoe[1, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[2, 0], tictactoe[2, 1], tictactoe[2, 2]);
                        Console.WriteLine();
                        if (
                            tictactoe[0, 0] != "1" && tictactoe[0, 1] != "2" && tictactoe[0, 2] != "3" &&
                            tictactoe[1, 0] != "4" && tictactoe[1, 1] != "5" && tictactoe[1, 2] != "6" &&
                            tictactoe[2, 0] != "7" && tictactoe[2, 1] != "8" && tictactoe[2, 2] != "9"
                           )
                        {
                            draw = true;
                            break;
                        }




                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Its player 1 turn where you want to put X?");
                            Console.ForegroundColor = ConsoleColor.White;
                            int place = int.Parse(Console.ReadLine());
                            switch (place)
                            {
                                case 1:
                                    tictactoe[0, 0] = "X";
                                    break;
                                case 2:
                                    tictactoe[0, 1] = "X";
                                    break;
                                case 3:
                                    tictactoe[0, 2] = "X";
                                    break;
                                case 4:
                                    tictactoe[1, 0] = "X";
                                    break;
                                case 5:
                                    tictactoe[1, 1] = "X";
                                    break;
                                case 6:
                                    tictactoe[1, 2] = "X";
                                    break;
                                case 7:
                                    tictactoe[2, 0] = "X";
                                    break;
                                case 8:
                                    tictactoe[2, 1] = "X";
                                    break;
                                case 9:
                                    tictactoe[2, 2] = "X";
                                    break;
                            }
                            if ((tictactoe[0, 0] == "X" && tictactoe[0, 1] == "X" && tictactoe[0, 2] == "X") ||
                                (tictactoe[1, 0] == "X" && tictactoe[1, 1] == "X" && tictactoe[1, 2] == "X") ||
                                (tictactoe[2, 0] == "X" && tictactoe[2, 1] == "X" && tictactoe[2, 2] == "X") ||
                                  (tictactoe[0, 0] == "X" && tictactoe[1, 0] == "X" && tictactoe[2, 0] == "X") ||
                                  (tictactoe[0, 1] == "X" && tictactoe[1, 1] == "X" && tictactoe[2, 1] == "X") ||
                                  (tictactoe[0, 2] == "X" && tictactoe[1, 2] == "X" && tictactoe[2, 2] == "X") ||
                                     (tictactoe[0, 0] == "X" && tictactoe[1, 1] == "X" && tictactoe[2, 2] == "X") ||
                                     (tictactoe[0, 2] == "X" && tictactoe[1, 1] == "X" && tictactoe[2, 0] == "X")
                              )
                            {
                                player1 = true;

                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Its player 2 turn where you want to put O?");
                            Console.ForegroundColor = ConsoleColor.White;
                            int place = int.Parse(Console.ReadLine());
                            switch (place)
                            {
                                case 1:
                                    tictactoe[0, 0] = "O";
                                    break;
                                case 2:
                                    tictactoe[0, 1] = "O";
                                    break;
                                case 3:
                                    tictactoe[0, 2] = "O";
                                    break;
                                case 4:
                                    tictactoe[1, 0] = "O";
                                    break;
                                case 5:
                                    tictactoe[1, 1] = "O";
                                    break;
                                case 6:
                                    tictactoe[1, 2] = "O";
                                    break;
                                case 7:
                                    tictactoe[2, 0] = "O";
                                    break;
                                case 8:
                                    tictactoe[2, 1] = "O";
                                    break;
                                case 9:
                                    tictactoe[2, 2] = "O";
                                    break;
                            }
                            if ((tictactoe[0, 0] == "O" && tictactoe[0, 1] == "O" && tictactoe[0, 2] == "O") ||
                               (tictactoe[1, 0] == "O" && tictactoe[1, 1] == "O" && tictactoe[1, 2] == "O") ||
                               (tictactoe[2, 0] == "O" && tictactoe[2, 1] == "O" && tictactoe[2, 2] == "O") ||
                                 (tictactoe[0, 0] == "O" && tictactoe[1, 0] == "O" && tictactoe[2, 0] == "O") ||
                                 (tictactoe[0, 1] == "O" && tictactoe[1, 1] == "O" && tictactoe[2, 1] == "O") ||
                                 (tictactoe[0, 2] == "O" && tictactoe[1, 2] == "O" && tictactoe[2, 2] == "O") ||
                                    (tictactoe[0, 0] == "O" && tictactoe[1, 1] == "O" && tictactoe[2, 2] == "O") ||
                                    (tictactoe[0, 2] == "O" && tictactoe[1, 1] == "O" && tictactoe[2, 0] == "O")
                             )
                            {
                                player2 = true;
                            }


                        }





                        i++;
                        Console.Clear();
                        if (player1 == true)
                        {
                            break;
                        }
                        if (player2 == true)
                        {
                            break;
                        }


                    }
                    Console.WriteLine();
                    if (player1 == true)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[0, 0], tictactoe[0, 1], tictactoe[0, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[1, 0], tictactoe[1, 1], tictactoe[1, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[2, 0], tictactoe[2, 1], tictactoe[2, 2]);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                  Player 1 win ");
                        Console.WriteLine("                                  ------------");
                        p1++;
                        i = 1;

                        Console.WriteLine();
                    }
                    else if (player2 == true)
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[0, 0], tictactoe[0, 1], tictactoe[0, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[1, 0], tictactoe[1, 1], tictactoe[1, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[2, 0], tictactoe[2, 1], tictactoe[2, 2]);
                        Console.WriteLine("Player 2 win ");
                        Console.WriteLine("------------");
                        p2++;
                        i = 0;

                        Console.WriteLine();

                    }
                    else if (draw == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[0, 0], tictactoe[0, 1], tictactoe[0, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[1, 0], tictactoe[1, 1], tictactoe[1, 2]);
                        Console.WriteLine("                                      {0} {1} {2}", tictactoe[2, 0], tictactoe[2, 1], tictactoe[2, 2]);
                        Console.WriteLine("   DRAW ");
                        Console.WriteLine("------------");

                        i = 0;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (p1 == 3 || p2 == 3) { break; }
                }
                if (p1 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                              Player 1 WON The Game");
                    Console.WriteLine("                              ---------------------");
                }
                if (p2 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                              Player 2 WON The Game");
                    Console.WriteLine("                              ---------------------");
                }
                Console.WriteLine("If you want to play again type 1 or if you want to Exit type 0");
                restart = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            
            for (int i = 0; i < 10000; i++)
            {
                 Console.WriteLine("Thank you for playing :D");
            }
        }
    }
}