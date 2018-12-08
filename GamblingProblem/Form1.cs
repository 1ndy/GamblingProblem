using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingProblem
{
    public partial class Form1 : Form
    {
        Deck d;
        HumanPlayer hp;
        ComputerPlayer cp;
        bool hasExchanged;
        PictureBox[] humanCardPictures = new PictureBox[5];
        PictureBox[] computerCardPictures = new PictureBox[5];
        int pool;
        Random rng;
        public Form1()
        {
            InitializeComponent();
            d = new Deck();
            hp = new HumanPlayer();
            cp = new ComputerPlayer();
            rng = new Random();
            pool = 0;
            hasExchanged = false;
            humanCardPictures[0] = handCard1;
            humanCardPictures[1] = handCard2;
            humanCardPictures[2] = handCard3;
            humanCardPictures[3] = handCard4;
            humanCardPictures[4] = handCard5;

            computerCardPictures[0] = computerCard1;
            computerCardPictures[1] = computerCard2;
            computerCardPictures[2] = computerCard3;
            computerCardPictures[3] = computerCard4;
            computerCardPictures[4] = computerCard5;
            playerName.Text = hp.Name;
            updatePlayerMoney();
            updateComputerMoney();
        }

        private void updatePlayerMoney()
        {
            moneyLabel.Text = "Money: " + hp.getMoney();
        }

        private void updateComputerMoney()
        {
            computerMoneyLabel.Text = "Computer Money: " + cp.getMoney();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playHand();
        }

        public void playHand()
        {
            Card c, b;
            pool = 2;
            hp.removeMoney(1);
            cp.removeMoney(1);
            updatePlayerMoney();
            updateComputerMoney();
            hasExchanged = false;
            playAgainButton.Visible = false;
            exchangeButton.Visible = true;
            newComputerPlayerButton.Visible = false;
            int i;

            for (i = 0; i < 5; i++)
            {
                c = d.getCard();
                b = d.getCard();
                hp.hand.addCard(c);
                cp.hand.addCard(b);
                humanCardPictures[i].ImageLocation = c.getCardPath();
                computerCardPictures[i].ImageLocation = "..\\..\\cards\\gray_back.png";
            }
            statusLabel.Text = "Click on cards to exchange";
        }

        private void showComputerCards()
        {
            for (int i = 0; i < 5; i++)
            {
                computerCardPictures[i].ImageLocation = cp.hand.getCard(i+1).getCardPath();
            }
        }

        private void handCard1_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                if (handCard1.ImageLocation == "..\\..\\cards\\gray_back.png")
                {
                    handCard1.ImageLocation = hp.hand.getCard(1).getCardPath();
                }
                else
                {
                    handCard1.ImageLocation = "..\\..\\cards\\gray_back.png";
                }
            }
        }

        private void handCard2_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                if (handCard2.ImageLocation == "..\\..\\cards\\gray_back.png")
                {
                    handCard2.ImageLocation = hp.hand.getCard(2).getCardPath();
                }
                else
                {
                    handCard2.ImageLocation = "..\\..\\cards\\gray_back.png";
                }
            }
        }

        private void handCard3_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                if (handCard3.ImageLocation == "..\\..\\cards\\gray_back.png")
                {
                    handCard3.ImageLocation = hp.hand.getCard(3).getCardPath();
                }
                else
                {
                    handCard3.ImageLocation = "..\\..\\cards\\gray_back.png";
                }
            }
        }

        private void handCard4_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                if (handCard4.ImageLocation == "..\\..\\cards\\gray_back.png")
                {
                    handCard4.ImageLocation = hp.hand.getCard(4).getCardPath();
                }
                else
                {
                    handCard4.ImageLocation = "..\\..\\cards\\gray_back.png";
                }
            }
        }

        private void handCard5_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                if (handCard5.ImageLocation == "..\\..\\cards\\gray_back.png")
                {
                    handCard5.ImageLocation = hp.hand.getCard(5).getCardPath();
                }
                else
                {
                    handCard5.ImageLocation = "..\\..\\cards\\gray_back.png";
                }
            }
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            if (!hasExchanged)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (humanCardPictures[i].ImageLocation == "..\\..\\cards\\gray_back.png")
                    {
                        Card c = d.getCard();
                        hp.hand.newCard(i + 1, c);
                        humanCardPictures[i].ImageLocation = c.getCardPath();
                    }
                }
                hasExchanged = true;
                exchangeButton.Visible = false;
                betButton.Visible = true;
                betTextbox.Visible = true;

                //computer stuff
                cp.exchangeHand();
                statusLabel.Text = "Enter an amout to bet (0 to fold)";
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(betTextbox.Text);
            if (amount == 0)
            {
                statusLabel.Text = "You folded";
                cp.addMoney(pool);
                updateComputerMoney();
                playAgainButton.Visible = true;
                betButton.Visible = false;
                betTextbox.Visible = false;
            }
            else if(amount > hp.getMoney() || amount > cp.getMoney())
            {
                statusLabel.Text = "One player can not bet that much.";
            }
            else
            {  
                pool += hp.removeMoney(amount);
                updatePlayerMoney();
                betButton.Visible = false;
                betTextbox.Visible = false;

                //computer stuff
                int r;
                if(pool * 2 > pool + cp.getMoney())
                    r = rng.Next(1, 20);
                else if (pool == pool + cp.getMoney())
                    r = rng.Next(1, 30);
                else
                    r = rng.Next(1,10);
                int p = rng.Next(1, 10);
                if(p <= 4)
                {
                    r /= 3;
                }
                if (r < 8)
                {
                    pool += cp.removeMoney(amount);
                    statusLabel.Text = "Computer has matched";
                    callButton.Visible = true;
                    updateComputerMoney();
                }
                else
                {
                    statusLabel.Text = "Computer has folded";
                    cp.fold();
                    hp.addMoney(pool);
                    pool = 0;
                    updatePlayerMoney();
                    updateComputerMoney();
                    playAgainButton.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void callButton_Click(object sender, EventArgs e)
        {
            showComputerCards();
            callButton.Visible = false;
            humanWonButton.Visible = true;
            computerWonButton.Visible = true;
        }

        private void humanWonButton_Click(object sender, EventArgs e)
        {
            hp.addMoney(pool);
            pool = 0;
            updatePlayerMoney();
            humanWonButton.Visible = false;
            computerWonButton.Visible = false;
            playAgainButton.Visible = true;
        }

        private void computerWonButton_Click(object sender, EventArgs e)
        {
            cp.addMoney(pool);
            pool = 0;
            updateComputerMoney();
            humanWonButton.Visible = false;
            computerWonButton.Visible = false;
            playAgainButton.Visible = true;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            cp.hand.clearHand();
            hp.hand.clearHand();
            if (cp.getMoney() > 0 && hp.getMoney() > 0)
            {
                playHand();
            }
            else
            {
                statusLabel.Text = "A player has lost. Game over";
                playAgainButton.Visible = false;
                newComputerPlayerButton.Visible = true;
            }
        }

        private void newComputerPlayerButton_Click(object sender, EventArgs e)
        {
            cp = new ComputerPlayer();
            playHand();
        }
    }
}
