using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        public static int HeadX = 24;
        public static int HeadY = 13;
        public static char dir = 'u';
        public static char prev_dir = ' ';
        public static int tailLength = 5;

        public static void snakeHead()
        {
            Display.grid[HeadY, HeadX] = 'O';
        }
        public static void moveHead()
        {
            checkIfKeyPressed();

            if (dir == 'u') //u - up
            {
                Display.grid[HeadY, HeadX] = '*';
                Display.grid[HeadY -= 2, HeadX] = 'O';
                tailFollowHead();
                Display.displayGrid();
            }
            else if (dir == 'd') //d - down
            {
                Display.grid[HeadY, HeadX] = '*';
                Display.grid[HeadY += 2, HeadX] = 'O';
                tailFollowHead();
                Display.displayGrid();
            }
            else if (dir == 'l') //l - left
            {
                Display.grid[HeadY, HeadX] = '*';
                Display.grid[HeadY, HeadX -= 2] = 'O';
                tailFollowHead();
                Display.displayGrid();
            }
            else if (dir == 'r') //r - right
            {
                Display.grid[HeadY, HeadX] = '*';
                Display.grid[HeadY, HeadX += 2] = 'O';
                tailFollowHead();
                Display.displayGrid();
            }   
        }
        public static void checkIfKeyPressed()
        {
            if(Console.KeyAvailable)
            {
                char key = Console.ReadKey().KeyChar;

                if (key == 'w')
                    dir = 'u';
                else if (key == 's')
                    dir = 'd';
                else if (key == 'a')
                    dir = 'l';
                else if (key == 'd')
                    dir = 'r';

            }
        }
        //tailLenght = 2
        public static void tailFollowHead()
        {
            if(dir == 'u')
            {
                Display.grid[HeadY + 2 * tailLength, HeadX ] = ' ';

                prev_dir = dir;
            }
            else if(dir == 'd')
            {
                Display.grid[HeadY - 2 * tailLength, HeadX] = ' ';
                prev_dir = dir;
            }
            else if( dir == 'l')
            {
                Display.grid[HeadY, HeadX + 2 * tailLength] = ' ';
                prev_dir = dir;
            }
            else if(dir == 'r')
            {
                Display.grid[HeadY, HeadX - 2 * tailLength] = ' ';
                prev_dir = dir;
            }
        }
    }
}
