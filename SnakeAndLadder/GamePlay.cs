using System;
using System.Runtime.CompilerServices;

namespace SnakeAndLadder
{
    internal class GamePlay
    {
        int Position = 0;
        Random random = new Random();
        public void DieRoll()
        {
            int num = random.Next(1, 7);
            int num1 = random.Next(0, 3);
           switch (num1)
        
           {
                case 0:
                    Console.WriteLine("Player is in the same position");
                    break;
                case 1:
                    Position += num;
                    Console.WriteLine("Player position is : " + Position);
            break;
                case 2:
                    Position -= num;
                    Console.WriteLine("Player position is : " + Position);
                    break;
            }
        }
        
    }
}