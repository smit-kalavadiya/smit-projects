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

namespace LuckyPoker
{
    public partial class Form1 : Form
    {
        //Declaration of variables and initialization
        private Deck deck;
        private int Counter, OneLeft, OneRight;
        private int TwoLeft, TwoRight;
        private int OneCardsLeft = 10;
        private int TwoCardsLeft = 10;
        private int OnePoints, TwoPoints;
        private decimal plyrOneBal, plyrTwoBal, BetAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoadSetup(); //setup form
        }

        private void picDeck_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                if (pic.Image != null)
                {
                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                }
            }
        }

        private void picDeckTwo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                grpPlayerTwo.setEnableDisable(true); // Extension
                grpPlayerOne.setEnableDisable(false);// Extension
                PictureBox pic = (PictureBox)sender;
                if (pic.Image != null)
                {
                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                }
            }
        }

        private void grpPlayerOne_DragEnter(object sender, DragEventArgs e)
        {
            if (sender is GroupBox)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grpPlayerTwo_DragEnter(object sender, DragEventArgs e)
        {
            if (sender is GroupBox)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grpPlayerOne_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is GroupBox)
            {
                if (Counter % 2 == 0)
                {
                    picDeckTwo.setVisibility(true); //Extension
                    picDeckOne.setVisibility(false); //Extension
                }
                else
                {
                    picDeckTwo.setVisibility(true);
                    picDeckOne.setVisibility(false);
                }
                if (Counter < 20)
                {
                    DropingImage(); //sets of code for drop image on groupbox for player one
                }
            }
        }

        private void grpPlayerTwo_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is GroupBox)
            {
                if (Counter % 2 == 0)
                {
                    grpPlayerTwo.setEnableDisable(false);// Extension
                    grpPlayerOne.setEnableDisable(true);// Extension
                    picDeckTwo.setVisibility(true);
                    picDeckOne.setVisibility(false);
                }
                else
                {
                    grpPlayerTwo.setEnableDisable(false);// Extension
                    grpPlayerOne.setEnableDisable(true);// Extension
                    picDeckTwo.setVisibility(false);
                    picDeckOne.setVisibility(true);
                }
                if (Counter < 20)
                {
                    DropingImagePlayerTwo();//sets of code for drop image on groupbox for player two
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBetAmount.Text, out BetAmount) && BetAmount > 0)
            {
                if (GamePlay.verifyBetAmount(plyrOneBal, BetAmount, plyrTwoBal))
                {
                    GameStart(); // this function will start the game and check required validation.
                }
                else
                {
                    MessageBox.Show("Don't have sufficient balance!!", "Lucky Poker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid bet amount", "Lucky Poker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Restart the application
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck.Shuffle(); // shuffle the deck
        }

        //Custom methods are here...
        #region //Methods

        private void setupDragDrop(Control control)
        {
            if (control is PictureBox)
            {
                PictureBox pic = (PictureBox)control;
                pic.AllowDrop = true;
            }
            else
            {
                foreach (Control item in control.Controls)
                {
                    setupDragDrop(item);
                }
            }
        }

        private void DropingImage()
        {
            deck.Shuffle();
            checkTurn();
            OneLeft = OneLeft + 10;
            OneRight = OneRight + 15;
            Card c = deck.DrawOneRandomCard();
            PictureBox p = c.CreatpictureBox(OneLeft, OneRight);
            grpPlayerOne.Controls.Add(p);
            p.BringToFront();
            OnePoints += (int)c.FaceValue;
            OnePoints++;
            lblOnePoints.Text = OnePoints.ToString();
            ++Counter;
            OneCardsLeft--;
            txtLeftCardsOne.Text = OneCardsLeft.ToString();
        }

        private void DropingImagePlayerTwo()
        {
            deck.Shuffle();
            ++Counter;
            TwoCardsLeft--;
            TwoLeft = TwoLeft + 10;
            TwoRight = TwoRight + 15;
            Card c = deck.DrawOneRandomCard();
            PictureBox p = c.CreatpictureBox(TwoLeft, TwoRight);
            grpPlayerTwo.Controls.Add(p);
            p.BringToFront();
            TwoPoints += (int)c.FaceValue;
            TwoPoints++;
            lblTwoPoints.Text = TwoPoints.ToString();
            txtLeftCardsTwo.Text = TwoCardsLeft.ToString();
            checkTurn();
        }

        private void checkTurn()
        {
            if (TwoCardsLeft == 0)
            {
                picDeckTwo.setVisibility(false);
            }
            if (OneCardsLeft == 0)
            {
                picDeckOne.setVisibility(false);
            }
            CheckWin();
        }

        private void FormLoadSetup()
        {
            plyrOneBal = 500;
            plyrTwoBal = 500;

            picDeckOne.setVisibility(false);
            picDeckTwo.setVisibility(false);
            btnShuffle.setVisibility(false);
            btnRestart.setVisibility(false);
            grpPlayerOne.setVisibility(false);
            grpPlayerTwo.setVisibility(false);
            grpPlayerTwo.setEnableDisable(false);

            lblPlayerOneBalance.Text = 500.ToString("c");
            lblPlayerTwoBalance.Text = 500.ToString("c");
            deck = new Deck();
            deck.Shuffle();
            picDeckTwo.Image = CardImageUtil.getDeckImage();
            picDeckOne.Image = CardImageUtil.getDeckImage();
            grpPlayerOne.AllowDrop = true;
            grpPlayerTwo.AllowDrop = true;
            setupDragDrop(grpPlayerOne);
        }

        private void CheckWin()
        {
            if (Counter == 20)
            {
                txtBetAmount.ReadOnly = false;
                btnStart.setEnableDisable(true);
                grpPlayerOne.Controls.Clear();
                grpPlayerTwo.Controls.Clear();
                if (OnePoints == TwoPoints)
                {
                    MessageBox.Show("The game is tie!!","Lucky Poker",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (OnePoints > TwoPoints)
                {
                    MessageBox.Show("Hurray!! Player One Win", "Lucky Poker", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    plyrOneBal += BetAmount;

                    plyrTwoBal = plyrTwoBal - BetAmount;
                    lblPlayerTwoBalance.Text = plyrTwoBal.ToString("c");
                    lblPlayerOneBalance.Text = plyrOneBal.ToString("c");
                    return;
                }
                else
                {
                    MessageBox.Show("Hurray!! Player Two Win", "Lucky Poker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plyrTwoBal += BetAmount;
                    plyrOneBal = plyrOneBal - BetAmount;
                    lblPlayerOneBalance.Text = plyrOneBal.ToString("c");
                    lblPlayerTwoBalance.Text = plyrTwoBal.ToString("c");
                    return;
                }
            }
        }

        private void GameStart()
        {
            deck = new Deck();
            txtBetAmount.ReadOnly = true;
            btnShuffle.setVisibility(true);
            deck.Shuffle();
            Counter = 0;
            OneLeft = 0;
            OneRight = 0;
            TwoLeft = 0;
            TwoRight = 0;
            OneCardsLeft = 10;
            TwoCardsLeft = 10;
            OnePoints = 0;
            TwoPoints = 0;

            lblOnePoints.Text = string.Empty;
            lblTwoPoints.Text = string.Empty;

            txtLeftCardsOne.Text = OneCardsLeft.ToString();
            txtLeftCardsTwo.Text = TwoCardsLeft.ToString();

            grpPlayerOne.setVisibility(true);
            grpPlayerTwo.setVisibility(true);
            btnRestart.setVisibility(true);

            picDeckOne.setVisibility(true);
            picDeckTwo.setVisibility(false);

            lblPlayerOneBalance.Text = plyrOneBal.ToString("c");
            lblPlayerTwoBalance.Text = plyrTwoBal.ToString("c");
            btnStart.setEnableDisable(false);
        }

        #endregion 
    }
}
