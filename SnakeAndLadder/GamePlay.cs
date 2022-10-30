using System;
namespace SnakeAndLadder
{
    internal class GamePlay
    {
        int Position = 0;
        Random random = new Random();
        public void DieRoll()
        {
            while (Position < 100)
            {
                int num = random.Next(1, 7);
                int num1 = random.Next(0, 3);
                switch (num1)

                {
                    case 0:
                        Console.WriteLine("Player is in the same position");
                        break;
                    case 1:
                        if (Position >93)
                        {
                            int hundred = 100 - Position;
                            Console.WriteLine("Game is in End Phase and position is :" + Position);
                            if (hundred >= num)
                                {
                                    Position += num;
                                    Console.WriteLine("Player position is : " + Position);
                                }
                            else 
                            {
                                Console.WriteLine("Wait For the Next Round Until get exact 100");
                            }
                            }
                            else
                            {
                                Position += num;
                                Console.WriteLine("Player position is : " + Position);
                            }
                            break;
                    case 2:
                        if (Position < 93)
                        {
                            break;
                        }
                        Position -= num;
                        Console.WriteLine("Player position is : " + Position);
                        if (Position < 0)
                        {
                            Position = 0;
                            Console.WriteLine("Player position change to 0 . So the player again Restart From O");
                        }
                        break;
                }
            }

        }
    }
}
                        