using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNr6
{
    public struct Class1
    {

        public int x;
        public int y;
        public static char symbol = 'X';

        public enum Direction: int
        {

            right=1,
            left = -1,
            up = 1,
            down =-1,

        }

        public static void Move(int x, int y)
        {

            int width = (Console.WindowWidth)-1;
            int height = Console.WindowHeight;

            Console.SetCursorPosition(x, y);

            while (true)
            {
                var control = Console.ReadKey();

                switch (control.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        y--;
                        if ((x < 0) || (x > width) || (y > height) || (y < 0))
                            y += 2;
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        y++;
                        if ((x < 0) || (x > width) || (y > height) || (y < 0))
                            y -= 2;
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        x--;
                        if ((x < 0) || (x > width) || (y > height) || (y < 0))
                            x += 2;
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        x++;
                        if ((x < 0) || (x > width) || (y > height) || (y < 0))
                            x-=2;
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }

            }

        }

    }
}
