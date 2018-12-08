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
        public Form1()
        {
            InitializeComponent();
            Deck d = new Deck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deck d = new Deck();
            HumanPlayer h = new HumanPlayer();
            Card c;
            int i;

            PictureBox[] cardPictures = new PictureBox[5];
            cardPictures[0] = handCard1;
            cardPictures[1] = handCard2;
            cardPictures[2] = handCard3;
            cardPictures[3] = handCard4;
            cardPictures[4] = handCard5;

            for (i = 0; i < 5; i++)
            {
                c = d.getCard();
                h.hand.addCard(c);
                cardPictures[i].ImageLocation = c.getCardPath();
            }
        }
    }
}
