using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Render render = new Render();
            Player player = new Player(25, 5);

            render.DrawPlayer(player.PositionX, player.PositionY , '#');
            Console.ReadKey();
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }

    class Render
    {
        public void DrawPlayer(int x, int y, char playerChar = '@')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerChar);
        }
    }
}
