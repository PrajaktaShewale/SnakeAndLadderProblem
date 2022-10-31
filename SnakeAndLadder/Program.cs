using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay sn = new GamePlay();
            int player1 = sn.DieRoll();
            GamePlay sn1 = new GamePlay();
            int player2 = sn1.DieRoll();
            Console.WriteLine("Player 1  total number dice roll is  " + player1);
            Console.WriteLine("Player 2  total number dice roll is  " + player2);
            int num1 = player1.CompareTo(player2);
            if (num1 == 0)
            {
                Console.WriteLine("Game is Tie");
            }
            if (num1 == 1)
            {
                Console.WriteLine("Player 1 Wins the match");
            }
            else
            {
                Console.WriteLine("Player 2 Wins the match");
            }
        }
    }
}