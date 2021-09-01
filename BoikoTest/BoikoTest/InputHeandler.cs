using System;

namespace TestBoiko
{
    class InputHeandler
    {
        public static ActionType Handle()
        {
            Console.WriteLine("\nPlease, enter a command, if you want open press O, or press Q for Exit :");

            var command = Console.ReadKey();
            Console.Clear();

            if (command.Key == ConsoleKey.Q)
            {
                Console.WriteLine("We are exing!");
                return ActionType.Exit;
            }
            else if (command.Key == ConsoleKey.O)
            {
                Console.WriteLine("Trying to open!");
                return ActionType.Open;
            }

            Console.WriteLine("Wrang command!!!");
            return ActionType.None;
        }
    }
}
