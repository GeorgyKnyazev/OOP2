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
        public Player(int positionX, int positionY, char playerSimbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            PlayerSimbol = playerSimbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char PlayerSimbol { get; private set; }
    }

    class Renderer
    {
        public Player Player;

        public void DrawPlayer(Player Player)
        {
            Console.SetCursorPosition(Player.PositionX, Player.PositionY);
            Console.Write(Player.PlayerSimbol);
        }
    }
}
