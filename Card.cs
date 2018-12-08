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
                if (suit == "club") return "Clubs";
                else if (suit == "diamond") return "Diamonds";
                else if (suit == "heart") return "Hearts";
                else if (suit == "spade") return "Spades";
            }
        }

        public string Number
        {
            get
            {
                if (number == 'A') return "A";
                else if (number == 'J') return "J";
                else if (number == 'Q') return "Q";
                else if (number == 'K') return "K";
                else if (number == 'T') return "10";
                else return number.ToString();
            }
        }


        public Card(string s, char n)
        {
            suit = s;
            number = n;
        }

        public string getCardPath()
        {
            return "C:\\Users\\DSU\\source\\repos\\GamblingProblem\\GamblingProblem\\cards" + number.ToString() + suit;
        }
    }
}