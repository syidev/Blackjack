using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Entities;

namespace Blackjack.BusinessLogic
{
    public class CardDeckService {

        private CardDeck _deck { get; set; }

        public CardDeckService() {
            _deck = new CardDeck();
            GenerateCardDeck();
        }

        public Card GetLastCardInDeck() {
            return _deck.Cards.Last();
        }

        private void GenerateCardDeck() {

            CardDeck thisCardDeck = new CardDeck();
            foreach ( Card theCard in thisCardDeck.Cards)
                Console.WriteLine(" " + theCard.Name + theCard.Suit);
        }

        public void SuffleCardDeck() {
            //SomeLogic
        }
    }
}
