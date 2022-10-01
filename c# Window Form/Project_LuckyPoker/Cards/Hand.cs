using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Hand
    {
        private List<Card> _cards = new List<Card>();

        public int Count
        {
            get
            {
                return _cards.Count();
            }
        }

        public bool hasCards
        {
            get 
            {
                return Count > 0;

            }
        }

        public Card this[int index]
        {
            get
            {
                return _cards[index];
            }
        }

        public void Add(Card newCard)
        {
            if (Contains(newCard))
            {
                throw new Exception(newCard.Name + "Already exist in the hand");
            }
            _cards.Add(newCard);

        }

        private bool Contains(Card cardToCheck)
        {

            foreach (var currentCard in _cards)
            {
                if (isMatch(cardToCheck, currentCard))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isMatch(Card card1, Card card2)
        {
            if (card1.Suit != card2.Suit)
            {
                return false;
            }
            if (card1.FaceValue != card2.FaceValue)
            {
                return false;
            }
            return true;
        }
    }
}
