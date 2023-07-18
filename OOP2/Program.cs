using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();
            Player player = new Player(25, 5, '#');

            render.DrawPlayer(player);
            Console.ReadKey();
        }
    }

    class Player
    {
        public Player(int positionX, int positionY, char simbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Simbol = simbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Simbol { get; private set; }
    }

    class Renderer
    {             
        public void DrawPlayer(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write(player.Simbol);
        }
    }
}
