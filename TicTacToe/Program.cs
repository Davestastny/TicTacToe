using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string turn = "Player1";
            string vyhra = "false";
            string hratZnovu = "false";
            string player1, player2, selection;

            Console.WriteLine("Vítejte ve hře");
            Console.WriteLine("Zmáčkněte enter pro pokračování");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Jméno prvního hráče: ");
            player1 = Console.ReadLine();
            Console.WriteLine("Jméno druhého hráče: ");
            player2 = Console.ReadLine();
            Start:
            Console.Clear();

            if (turn == "Player1")
            {
                turn = "Player2";
                Console.Clear();
                Console.WriteLine("Player1: " + player1 + " je na tahu");
                Console.WriteLine("");
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("****");
                Console.WriteLine("Rozhodněte se");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "3";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "X";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (A == B & B == C)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }

                }
                if (D == E & E == F)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (G == H & H == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (A == D & D == G)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (B == E & E == H)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (C == F & F == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (G == E & E == C)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (A == E & E == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
            }

            if (turn == "Player2")
            {
                turn = "Player1";
                Console.Clear();
                Console.WriteLine("Player2: " + player2 + " je na tahu");
                Console.WriteLine("");
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("****");
                Console.WriteLine("Rozhodněte se");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                    }
                    else
                    {
                        Console.WriteLine("Políčko je používané");
                    }
                }

                if (A == B & B == C)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }

                }
                if (D == E & E == F)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (G == H & H == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (A == D & D == G)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player1);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (B == E & E == H)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (C == F & F == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (G == E & E == C)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {
                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
                if (A == E & E == I)
                {
                    vyhra = "true";
                    Console.WriteLine("Vyhrál " + player2);
                    Console.WriteLine("");
                    Console.WriteLine("Chcete hrát znovu? Y / N");
                    selection = Console.ReadLine();
                    if (selection == "Y")
                    {

                        hratZnovu = "true";
                    }
                    else
                    {
                        hratZnovu = "false";
                    }
                }
            }
            if (vyhra == "false")
            {
                goto Start;
            }
            if (hratZnovu == "true")
            {
                A = "1";
                B = "2";
                C = "3";
                D = "4";
                E = "5";
                F = "6";
                G = "7";
                H = "8";
                I = "9";
                goto Start;
            }
            else
            {
                Console.WriteLine("Děkuji za hru!");
            }

        }
    }
}