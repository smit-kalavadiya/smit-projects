using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public static class SmitUtils
    {
        public static Hand getHand(int cardCount)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Hand hand = deck.DrawHand(cardCount);
            return hand;
        }

        public static string CheckContains(Hand hand, Card card)
        {
            string message = hand.CheckCard(card);
            if (message == "")
            {
                return "Try again";
            }
            return message;

        }

        public static object getSelectedValue(this ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select first");
            }
            return comboBox.SelectedItem;

        }

        public static object getSelectedSuit(this ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select first");
            }
            return comboBox.SelectedItem;
        }
    }
}
