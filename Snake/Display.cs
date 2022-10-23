using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Display
    {
        public const int X_POS = 50;
        public const int Y_POS = 25;
        public static char[,] grid = new char[Y_POS, X_POS];

        public static void createGrid()
        {
            for (int i = 0; i < Y_POS; i++)
            {
                for (int j = 0; j < X_POS; j++)
                {
                    if (i%2 == 0)
                    {
                        grid[i, j] = '-';
                    }
                    else if (j%2 == 0)
                    {
                        grid[i, j] = ' ';
                    }
                    else
                    {
                        grid[i, j] = '|';
                    }
                }
            }
        }
        public static void displayGrid()
        {
            Console.Clear();

            for (int i = 0; i < Y_POS; i++)
            {
                for (int j = 0; j < X_POS; j++)
                {
                    if(j%50==0 )
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(grid[i, j]);
                    }
                }
            }

            Console.WriteLine("\n");
            Console.Write("Wynik: ");
        }
            

        public static void generateFruit()
        {
            Random Fruit = new Random();

            int FruitY = Fruit.Next(0, Y_POS);
            int FruitX = Fruit.Next(0, X_POS);

            while (grid[FruitY, FruitX] != ' ')
            {
                FruitY = Fruit.Next(0, Y_POS);
                FruitX = Fruit.Next(0, X_POS);
            }

            grid[FruitY, FruitX] = '$';

        }
    }
}
