using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmimsnoe_varenie
{
    public class Program
    {
        enum Players
        {
            playerX,
            player0
        }


        static void Main(string[] args)
        {


            Console.CursorVisible = false;

            string[,] map =
            {
                {"*","|","*","|","*",},
                {"-","-","-","-","-",},
                {"*","|","*","|","*",},
                {"-","-","-","-","-",},
                {"*","|","*","|","*",},
            };

            Players currentPlayer = Players.playerX;

            bool playerXWins = false;
            bool playerOWins = false;

            void Map2()
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("0.0 | 0.2 | 0.4");
                Console.WriteLine("----------------");
                Console.WriteLine("2.0 | 2.2 | 2.4");
                Console.WriteLine("----------------");
                Console.WriteLine("4.0 | 4.2 | 4.4");
            }

            while (true)
            {

                Map2();
                CheckWin();
                Console.SetCursorPosition(0, 20);
                // Console.WriteLine("Введите координаты");

                if (currentPlayer == Players.playerX)
                {
                    Console.SetCursorPosition(0, 21);
                    Console.WriteLine("Cейчас ставит игрок X");
                }
                else
                {
                    Console.SetCursorPosition(0, 21);
                    Console.WriteLine("Cейчас ставит игрок o");
                }

                Console.SetCursorPosition(0, 0);

                
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }


                if (playerXWins || playerOWins)
                {
                    break;
                }

                Console.WriteLine("Введите первую координату");
                int row = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите вторую координату");
                int column = int.Parse(Console.ReadLine());

                // Заменяем символ в массиве
                if (currentPlayer == Players.playerX && map[row, column] != "|" && map[row, column] != "-" && map[row, column] != "X" && map[row, column] != "o")
                {
                    map[row, column] = "X";
                    currentPlayer = Players.player0;
                }


                if (currentPlayer == Players.player0 && map[row, column] != "|" && map[row, column] != "-" && map[row, column] != "X" && map[row, column] != "o")
                {
                    map[row, column] = "o";
                    currentPlayer = Players.playerX;
                }

                


                Console.Clear();
            }

            bool CheckWin()
            {
                if (map[0, 0] == "X" && map[0, 2] == "X" && map[0, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                    
                }
                if (map[2, 0] == "X" && map[2, 2] == "X" && map[2, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }
                if (map[4, 0] == "X" && map[4, 2] == "X" && map[4, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }
                
                // три вертикальных проверки
                if (map[0, 0] == "X" && map[2, 0] == "X" && map[4, 0] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }
                if (map[0, 2] == "X" && map[2, 2] == "X" && map[4, 2] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }
                if (map[0, 4] == "X" && map[2, 4] == "X" && map[4, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }

                // типо кривые проверки
                if (map[0, 0] == "X" && map[2, 2] == "X" && map[4, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }
                if (map[4, 0] == "X" && map[2, 2] == "X" && map[0, 4] == "X")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок X");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerXWins = true;
                }

                // проверка для игрока o


                if (map[0, 0] == "o" && map[0, 2] == "o" && map[0, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                if (map[2, 0] == "o" && map[2, 2] == "o" && map[2, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                if (map[4, 0] == "o" && map[4, 2] == "o" && map[4, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }

                // Три вертикальные проверки
                if (map[0, 0] == "o" && map[2, 0] == "o" && map[4, 0] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                if (map[0, 2] == "o" && map[2, 2] == "o" && map[4, 2] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                if (map[0, 4] == "o" && map[2, 4] == "o" && map[4, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }

                // Кривые проверки
                if (map[0, 0] == "o" && map[2, 2] == "o" && map[4, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                if (map[4, 0] == "o" && map[2, 2] == "o" && map[0, 4] == "o")
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("Победил игрок o");
                    Console.WriteLine("Для продолжения нажми что-нибудь");
                    Console.ReadLine();
                    playerOWins = true;
                }
                return false;

            }
        }

    }
}

