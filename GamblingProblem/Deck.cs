using System;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace GamblingProblem
{
    internal class Deck
    {
        private Queue<Card> deck;
        int unshuffledCards;
        public Deck()
        {
            deck = new Queue<Card>();
            string[] suits = { "club", "diamond", "heart", "spade" };
            string[] number = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck.Enqueue(new Card(suits[i], number[j]));
                }
            }
            shuffle();
            shuffle();
            shuffle();
           
            unshuffledCards = 52;
        }

        public void shuffle()
        {
            Card[] r = new Card[52];
            Random rng = new Random();
            for (int i = 0; i < 52; i++)
            {
                r[i] = deck.Dequeue();
            }
            for (int i = 0; i < 50; i++)
            {
                int j = rng.Next(i, 52);
                Card tmp = r[i];
                r[i] = r[j];
                r[j] = tmp;
            }
            for (int i = 0; i < 52; i++)
            {
                deck.Enqueue(r[i]);
            }
        }

        public Card getCard()
        {
            Card c = deck.Dequeue();
            deck.Enqueue(c);
            unshuffledCards--;
            if(unshuffledCards == 0)
            {
                shuffle();
                shuffle();
                shuffle();
                unshuffledCards = 52;
            }
            return c;
        }
    }
}