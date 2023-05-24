using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace task3
{
    internal class Help
    {
        public static void PrintTable(string[] arr)
        {
            var table = new ConsoleTable((arr.Prepend("Move ↓").ToList()).ToArray());
            for (int i = 0; i < arr.Length; i++)
            {
                string rowName = arr[i];
                var row = new List<string> { rowName };
                foreach (string a in arr)
                {
                    row.Add(Winner.WhoWins(arr, rowName, a));
                }
                table.AddRow(row.ToArray());
            }
            table.Write();
        }
    }
}
