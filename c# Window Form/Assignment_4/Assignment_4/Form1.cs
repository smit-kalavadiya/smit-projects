using Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    /*
    smit kalavadiya
    5047957
    IT-PA:2021
     */
    public partial class Form1 : Form
    {
        Deck deck;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            deck.Shuffle();
            cmbSuit.DataSource = CardGenerator.GetSuits();
            cmbValue.DataSource = CardGenerator.GetValues();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            int countCard;

            var face = (FaceValue)cmbValue.getSelectedValue(); // Entension method call
            var suit = (Suit)cmbSuit.getSelectedSuit(); // Entension method call

            if (int.TryParse(txtCount.Text, out countCard) == false)
            {
                MessageBox.Show("Please enter valid number of cards");
                return;
            }

            Hand hand = SmitUtils.getHand(countCard);
            Card card = new Card(suit, face);
            string message = SmitUtils.CheckContains(hand, card); // static method call
            DisplayHand(hand);
            MessageBox.Show(message);
        }

        public void DisplayHand(Hand hand)
        {
            grpHand.Controls.Clear();
            for (int i = 0; i < hand.Count; i++)
            {
                int leftofset = i * 10;
                int topofSet = i * 15;
                Card card = hand[i];
                var pic = card.CreatpictureBox(leftofset, topofSet);
                grpHand.Controls.Add(pic);
                pic.BringToFront();

            }
        }
    }
}
