using System;

namespace GamblingProblem
{
    public class Card
    {
        private string suit;
        private string number;

        public string Suit
        {
            get
            {
                if (suit == "club") return "C";
                else if (suit == "diamond") return "D";
                else if (suit == "heart") return "H";
                else if (suit == "spade") return "S";
                else return suit.ToString();
            }
        }

        public string Number
        {
            get
            {
                if (number == "A") return "A";
                else if (number == "J") return "J";
                else if (number == "Q") return "Q";
                else if (number == "K") return "K";
                else if (number == "T") return "10";
                else return number.ToString();
            }
        }


        public Card(string s, string n)
        {
            suit = s;
            number = n;
        }

        public string getCardPath()
        {
            return "..\\...\\cards\\" + Number + Suit + ".png";
        }
    }
}