using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Winner
    {
        public static string WhoWins(string[] arr, string move1, string move2)
        {
            if (move1 == move2) return "Draw";
            LinkedList<string> moves = new LinkedList<string>(arr);
            var current = moves.Find(move1);
            for (int i = 0; i < (arr.Length - 1) / 2; i++)
            {
                current = (current == moves.Last) ? moves.First : current.Next;
                if (current.Value == move2) return "Lose";
            }
            return "Win";
        }
    }
}
