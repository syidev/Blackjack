using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.BusinessLogic
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n I want to play with you at Blackjack.\n");
            Console.Write(" Ready? ");
            Console.ReadLine();
            Round thisRound = new Round();
            thisRound.BeforeRound();
            thisRound.Rounds(2, 1);
        }
    }
}
