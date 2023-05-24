using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Game
    {
        public static bool HandleMove(string[] args, int N, string? userMove, string computerMove, byte[] key)
        {
            if (!Int32.TryParse(userMove, out int userMoveInt))
            {
                Console.WriteLine("Please, eneter a number");
                return true;
            }
            switch (userMoveInt)
            {
                case -1:
                    Help.PrintTable(args);
                    return true;
                case 0:
                    Console.WriteLine("Exit");
                    return false;
                case int x when x > 0 && x <= N:
                    Console.WriteLine("Your move: " + args[userMoveInt - 1]);
                    Console.WriteLine("Computer move: " + computerMove);
                    Console.WriteLine("You " + Winner.WhoWins(args, args[userMoveInt - 1], computerMove) + "!");
                    Console.WriteLine("HMAC key: " + BitConverter.ToString(key));
                    Console.ReadLine();
                    return true;
                default:
                    Console.WriteLine($"Please, enter a number 1-{N}");
                    Console.ReadLine();
                    return true;
            }
        }
    }
}
