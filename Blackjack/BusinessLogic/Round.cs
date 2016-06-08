using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Entities;

namespace Blackjack.BusinessLogic
{
    class Round
    {
        int round;
        string answer;
        string exit;

        CardDeckService thisCardDeckService = new CardDeckService(); 
        
        public void Rounds(int cards, int round)

        {
            Console.Clear();
            Console.WriteLine("\n Round " + round + "\n");
            Console.WriteLine("\n You " + Player.playerRound + " : " + Computer.computerRound + " Computer \n");
            thisCardDeckService.GetCard(cards);
            foreach (Card card in thisCardDeckService.CardsRound)
            {
                Console.Write(" " + card.Name + card.Suit);
            }
            Console.WriteLine("\n Your score: " + Player.playerScore);
            if (Player.playerScore > 21)
            {
                Console.Write("\n You LOOSE!");
                Computer.computerRound++;
                NewRound();
            } else if (Player.playerScore == 21)
            {
                Console.WriteLine("\n You WIN! ");
                Player.playerRound++;
                NewRound();
            }
            Console.Write("\n Another card? (y\\n): ");
            answer = Console.ReadLine();
            
            if (answer == "y")
            {
                Rounds(1, round);
            } else
            {
                Console.WriteLine();
                thisCardDeckService.ComputerCard();
                Console.WriteLine("\n Computer score: " + Computer.computerScore);
            }
            if (Player.playerScore >= Computer.computerScore)
            {
                Console.Write("\n You WIN!");
                Player.playerRound++;
                NewRound();
            } else
            {     
                Console.Write("\n You LOOSE!");
                Computer.computerRound++;
                NewRound();
            }         
        }

        void NewRound()
        {
            Console.Write("\n New round? (y\\n): ");
            exit = Console.ReadLine();
            if (exit == "y")
            {
                thisCardDeckService.CardsRound.Clear();
                Player.playerScore = 0;
                Computer.computerScore = 0;
                BeforeRound();
                if (round == 0)
                    round = 2;
                Rounds(2, round++);
            }
        }

        public void BeforeRound()
        {
            Console.Clear();
            Console.WriteLine("\n Cards in play:\n");
            CardDeckService thisCardDeckService = new CardDeckService();
            thisCardDeckService.GenerateCardDeck();
            Console.SetCursorPosition(1,6);
            Console.WriteLine("Shuffle cards:");
            Console.WriteLine();
            thisCardDeckService.SuffleCardDeck();
            Console.SetCursorPosition(1, 11);
            Console.Write("Go! ");
            Console.ReadLine();
        }
    }
}
