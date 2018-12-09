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

        public Deck Deck
        {
            get => default(Deck);
            set
            {
            }
        }

        public Hand Hand
        {
            get => default(Hand);
            set
            {
            }
        }

        public Card(string s, string n)
        {
            suit = s;
            number = n;
        }

        public string getCardPath()
        {
            return "..\\..\\cards\\" + Number + Suit + ".png";
        }

        public static bool operator ==(Card a, Card b)
        {
            return a.Number == b.Number;
        }
        public static bool operator !=(Card a, Card b)
        {
            return !(a == b);
        }

        public static bool operator >(Card a, Card b)
        {
            string[] order = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int aRank=0, bRank=0;
            for (int i = 0; i < 13; i++)
            {
                if (order[i] == a.Number)
                    aRank = i;
                if (order[i] == b.Number)
                    bRank = i;
            }
            return aRank > bRank;
        }

        public static bool operator <(Card a, Card b)
        {
            return !(a > b || a == b);
        }

        public int getRawNumber()
        {
            if (Number == "2") return 0;
            if (Number == "3") return 1;
            if (Number == "4") return 2;
            if (Number == "5") return 3;
            if (Number == "6") return 4;
            if (Number == "7") return 5;
            if (Number == "8") return 6;
            if (Number == "9") return 7;
            if (Number == "10") return 8;
            if (Number == "J") return 9;
            if (Number == "Q") return 10;
            if (Number == "K") return 11;
            if (Number == "A") return 12;
            return -1;

        }

        public int getRawSuit()
        {
            if (Suit == "C") return 0;
            if (Suit == "D") return 1;
            if (Suit == "H") return 2;
            if (Suit == "S") return 3;
            return -1;
        }
    }
}