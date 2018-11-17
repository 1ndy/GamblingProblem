using System;
using System.Collections.Generic.Queue;
using System.Collections.Generic.List;

public class Deck
{
    private Queue<Card> deck;
    int unshuffledCards;
	public Deck()
	{
        deck = new Queue<Card>();
        string[] suits = { "club", "diamond", "heart", "spade" };
        string[] number = { 'A', '1', '2', '3', '4', '5', '6', '7', '8', '9', "10", 'J', 'Q', 'K' };
        unshuffledCards = 52;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 52; j++)
            {
                deck.enqueue(new Card(suits[j], number[i]));
            }
        }
        shuffle();
        shuffle();
        shuffle();


	}

    public void shuffle()
    {
        Card[] r = new Card[52];
        Random rng = new Random();
        for(int i = 0; i < 52; i++)
        {
            r[i] = deck.dequeue();
        }
        for (int i = 0; i < 50; i++)
        {
            int j = rng.Next(i,52);
            Card tmp = r[i];
            r[i] = r[j];
            r[j] = tmp;
        }
        for(int i = 0; i < 52; i++)
        {
            deck.enqueue(r[i]);
        }
    }
}
