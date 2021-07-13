using System;

namespace Szachy
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] startBoard =
             {

                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }

            };

            char[,] gameBoard = startBoard.Clone() as char[,];


            //Flags
            bool gameEnded = false;
            bool player1Move = true;


            for( int round = 0; round < startBoard.Length; round++)
            {
                Console.Clear();

                if(player1Move)
                {

                    player1Move = false;

                }
                else
                {
                    player1Move = true;
                }

                if (gameEnded)
                    break;

            }

            Console.Clear();

            Console.Write("Game ended! ");
            
        }
    }
}
