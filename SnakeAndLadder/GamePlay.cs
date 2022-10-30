using System;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        
        Random random = new Random();
        public void DieRoll()
        {
          int die = random.Next(1,7);
            Console.WriteLine(die);
        }
    }
}