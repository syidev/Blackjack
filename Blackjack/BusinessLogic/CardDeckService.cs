using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Entities;

namespace Blackjack.BusinessLogic
{
    class CardDeckService
    {
        public List<Card> CardsRound = new List<Card>();

        Random rand = new Random();

        public void GenerateCardDeck()
        {
            Console.Write("");
            foreach (Card theCard in CardDeck.Cards)
            {   
                Console.Write(" " + theCard.Name + theCard.Suit);
            }  
        }

        public void SuffleCardDeck()
        {
            Random rnd = new Random();

            for (int i = 0; i < CardDeck.Cards.Count; i++)
            {
                var tmp = CardDeck.Cards[i];
                CardDeck.Cards.RemoveAt(i);
                CardDeck.Cards.Insert(rnd.Next(CardDeck.Cards.Count), tmp);
            }
            foreach (Card theCard in CardDeck.Cards)
                Console.Write(" " + theCard.Name + theCard.Suit);
        }

        public void Card()
        {
            Player.playerScore += CardDeck.Cards[0].Value;
            CardsRound.Add (
                new Card() {
                    Name = CardDeck.Cards[0].Name,
                    Suit = CardDeck.Cards[0].Suit,
                    Value = CardDeck.Cards[0].Value
                }
            );
            CardDeck.Cards.RemoveAt(0);
        }

        public void GetCard(int x)
        {
            if (x == 1)
            {
                Card();
            } else
            {
                Card();
                Card();
            }
        }

        public void ComputerCard()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.Write(" " + CardDeck.Cards[0].Name + CardDeck.Cards[0].Suit);
                Computer.computerScore += CardDeck.Cards[0].Value;
                CardDeck.Cards.RemoveAt(0);
            }
        }
    }
}
