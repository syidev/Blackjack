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
            Console.WriteLine("\n I want to play with you at Blackjack.\n");
            Console.Write(" Ready? ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n Cards in play:\n");
            CardDeckService thisCardDeckService = new CardDeckService();
            //CardDeckService.CardDeckService();
            Console.ReadLine();
            //Round rou = new Round();
            //rou.Rounds();
        }
    }
}
