using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.BusinessLogic
{
    public class Round
    {
        int z = 1;

        public void Rounds()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Round " + z + "\n");
            //Console.ResetColor();
            Console.ReadLine();            
        }
    }
}
