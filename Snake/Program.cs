using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //game settings
            const string VER = "0.0.1";
            Console.Title = $"Snake by Adix {VER}";
            //console size
            Console.SetWindowSize(120, 32);
            Console.SetBufferSize(120, 32);
            Console.SetWindowSize(56, 32);

            Display.createGrid();
            Display.generateFruit();
            Snake.snakeHead();
            Display.displayGrid();

            while (true)
            {
                Display.displayGrid();
                Snake.moveHead();
                Thread.Sleep(500);
            }
            
            

            Console.ReadLine();
        }
    }
}
