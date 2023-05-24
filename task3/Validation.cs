using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Validation
    {
        private static string HasDuplicate(string[] a)
        {
            var duplicates = a.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();
            return String.Join(", ", duplicates);
        }

        public static void ValidateArguments(string[] args, int N)
        {
            string duplicates = HasDuplicate(args);
            if (N % 2 == 0 || N < 3 || duplicates != "")
            {
                Console.WriteLine("Sorry, you can't play because:");
                Console.ForegroundColor = ConsoleColor.Red;
                if (N % 2 == 0) Console.WriteLine(" ! The number of parameters is even");
                if (N < 3) Console.WriteLine(" ! The number of parameters is < 3");
                if (duplicates != "") Console.WriteLine(" ! There are repeating parameters: " + duplicates);
                Console.ResetColor();
                Console.WriteLine("\nPlease, enter odd number of unique parameters >= 3.\nFor example:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" √ Rock Scissors Paper\n" +
                    " √ Rock Scissors Paper Lizard Spok\n" +
                    " √ 1 2 3 4 5 6 7 8 9\n");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }
    }
}
