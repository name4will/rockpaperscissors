using System;

namespace rockpaperscissors
{
    class Program
    {
        // main game loop
        static void Main(string[] args)
        {
            Random Chooser = new Random();
            GameMove PlayerMove = new GameMove();
            GameMove ComputerMove = new GameMove();
            bool IsOver = false;
            Console.WriteLine("Rock Paper Scissors\n-------------------");

            while(!IsOver) 
            {
                Console.Write("Enter Rock, Paper, or Scissors: ");
                string InputMove = Console.ReadLine().ToLower();

                if (InputMove.Equals("rock") || InputMove.Equals("paper") || InputMove.Equals("scissors")) {
                    PlayerMove.SetMove(InputMove);
                    IsOver = true;
                } else {
                    Console.WriteLine("You inputted " + InputMove + " which is not a valid move. Please try again.");
                }
            }

            int RandomMove = Chooser.Next(1, 4); // including one, not including 4

            switch(RandomMove) 
            {
                case 1:
                    ComputerMove.SetMove("rock");
                    break;
                case 2:
                    ComputerMove.SetMove("paper");
                    break;
                case 3:
                    ComputerMove.SetMove("scissors");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("You inputted " + PlayerMove.GetMove());
            Console.WriteLine("The computer inputted " + ComputerMove.GetMove());
            Console.WriteLine("You " + PlayerMove.WinningMove(ComputerMove) + "!");
        }
    }
}
