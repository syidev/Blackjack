using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Entities
{
     public class CardDeck
    {
        
        public List<Card> Cards = new List<Card>
        {
            new Card { Name = "2", Value = 2, Suit = CardSuit.heart},
            new Card { Name = "3", Value = 3, Suit = CardSuit.heart},
            new Card { Name = "4", Value = 4, Suit = CardSuit.heart},
            new Card { Name = "5", Value = 5, Suit = CardSuit.heart},
            new Card { Name = "6", Value = 6, Suit = CardSuit.heart},
            new Card { Name = "7", Value = 7, Suit = CardSuit.heart},
            new Card { Name = "8", Value = 8, Suit = CardSuit.heart},
            new Card { Name = "9", Value = 9, Suit = CardSuit.heart},
            new Card { Name = "10", Value = 10, Suit = CardSuit.heart},
            new Card { Name = "J", Value = 10, Suit = CardSuit.heart},
            new Card { Name = "Q", Value = 10, Suit = CardSuit.heart},
            new Card { Name = "K", Value = 10, Suit = CardSuit.heart},
            new Card { Name = "A", Value = 10, Suit = CardSuit.heart},

            new Card { Name = "2", Value = 2, Suit = CardSuit.spade},
            new Card { Name = "3", Value = 3, Suit = CardSuit.spade},
            new Card { Name = "4", Value = 4, Suit = CardSuit.spade},
            new Card { Name = "5", Value = 5, Suit = CardSuit.spade},
            new Card { Name = "6", Value = 6, Suit = CardSuit.spade},
            new Card { Name = "7", Value = 7, Suit = CardSuit.spade},
            new Card { Name = "8", Value = 8, Suit = CardSuit.spade},
            new Card { Name = "9", Value = 9, Suit = CardSuit.spade},
            new Card { Name = "10", Value = 10, Suit = CardSuit.spade},
            new Card { Name = "J", Value = 10, Suit = CardSuit.spade},
            new Card { Name = "Q", Value = 10, Suit = CardSuit.spade},
            new Card { Name = "K", Value = 10, Suit = CardSuit.spade},
            new Card { Name = "A", Value = 10, Suit = CardSuit.spade},

            new Card { Name = "2", Value = 2, Suit = CardSuit.club},
            new Card { Name = "3", Value = 3, Suit = CardSuit.club},
            new Card { Name = "4", Value = 4, Suit = CardSuit.club},
            new Card { Name = "5", Value = 5, Suit = CardSuit.club},
            new Card { Name = "6", Value = 6, Suit = CardSuit.club},
            new Card { Name = "7", Value = 7, Suit = CardSuit.club},
            new Card { Name = "8", Value = 8, Suit = CardSuit.club},
            new Card { Name = "9", Value = 9, Suit = CardSuit.club},
            new Card { Name = "10", Value = 10, Suit = CardSuit.club},
            new Card { Name = "J", Value = 10, Suit = CardSuit.club},
            new Card { Name = "Q", Value = 10, Suit = CardSuit.club},
            new Card { Name = "K", Value = 10, Suit = CardSuit.club},
            new Card { Name = "A", Value = 10, Suit = CardSuit.club},

            new Card { Name = "2", Value = 2, Suit = CardSuit.diamond},
            new Card { Name = "3", Value = 3, Suit = CardSuit.diamond},
            new Card { Name = "4", Value = 4, Suit = CardSuit.diamond},
            new Card { Name = "5", Value = 5, Suit = CardSuit.diamond},
            new Card { Name = "6", Value = 6, Suit = CardSuit.diamond},
            new Card { Name = "7", Value = 7, Suit = CardSuit.diamond},
            new Card { Name = "8", Value = 8, Suit = CardSuit.diamond},
            new Card { Name = "9", Value = 9, Suit = CardSuit.diamond},
            new Card { Name = "10", Value = 10, Suit = CardSuit.diamond},
            new Card { Name = "J", Value = 10, Suit = CardSuit.diamond},
            new Card { Name = "Q", Value = 10, Suit = CardSuit.diamond},
            new Card { Name = "K", Value = 10, Suit = CardSuit.diamond},
            new Card { Name = "A", Value = 10, Suit = CardSuit.diamond},
        };
    }
}
