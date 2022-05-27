using System;

namespace Game_menu
{
    class Program
    {

        delegate void Operation();        
        static void NewGame() => Console.WriteLine("New game is starting");
        static void LoadGame() => Console.WriteLine("Game is loading");
        static void Rules() => Console.WriteLine("Game rules");
        static void AboutAuthor() => Console.WriteLine("Some info abt author of this game");
        static void Exit()
        {
            Console.WriteLine("Game over!");
            Environment.Exit(0);
        }
                
        static void Main()
        {
            Console.WriteLine("Game \"GAME\"");
            Console.WriteLine("Main menu:");
            Console.WriteLine();
            Console.WriteLine("Choose button:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Rules");
            Console.WriteLine("4 - About Author");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();
            Console.Write("Your choice - ");

            Operation operation;
            while (true)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        operation = NewGame;
                        operation();
                        break;
                    case 2:
                        operation = LoadGame;
                        operation();
                        break;
                    case 3:
                        operation = Rules;
                        operation();
                        break;
                    case 4:
                        operation = AboutAuthor;
                        operation();
                        break;
                    case 0:
                        operation = Exit;
                        operation();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
