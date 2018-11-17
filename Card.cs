using System;

public class Card
{
    private string suit;
    private char number;

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
            if (number == 'A') return "Ace";
            else if (number == 'J') return "Jack";
            else if (number == 'Q') return "Queen";
            else if (number == 'K') return "King";
            else return number.ToString();
        }
    }


    public Card(string s, char n)
    {
        suit = s;
        number = n;
    }
}
