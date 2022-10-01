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

        public string CheckCard(Card cardToCheck) // Custom method
        {
            string msg = "";
            string msg_suit = "";
            int flag = 0;
            for (int i = 0; i < _cards.Count; i++)
            {
                if (cardToCheck.Suit == _cards[i].Suit && cardToCheck.FaceValue == _cards[i].FaceValue)
                {
                    return msg = "Good Guess";
                }
                else
                {
                    if (cardToCheck.Suit == _cards[i].Suit)
                    {
                        msg_suit = $"Matching found {_cards[i].Suit}";
                        flag = 1;

                    }
                    if (cardToCheck.FaceValue == _cards[i].FaceValue)
                    {
                        msg = $"Matching found {_cards[i].FaceValue}";
                    }
                }
            }
            if (flag == 1)
            {
                return msg_suit;
            }
            return msg;
        }

        public bool Contains(Card cardToCheck)
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
