﻿using System;
using System.Collections.Generic.Queue;
using System.Collections.Generic.List;

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
            char[] number = { 'A', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    deck.enqueue(new Card(suits[j], number[i]));
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
                r[i] = deck.dequeue();
            }
            for (int i = 0; i < 50; i++)
            {
                int j = rng.Next(i, 52);
                Card tmp = r[i];
                r[i] = r[j];
                r[j] = tmp;
            }
            /*System.Write("New order: ");
            for (int i = 0; i < 52; i++)
            {
                System.Write(r[i]);
            }
            for (int i = 0; i < 52; i++)
            {
                deck.enqueue(r[i]);
            }*/
        }

        public Card getCard()
        {
            Card c = deck.Dequeue();
            deck.Enqueue(c);
            unshuffledCards--;
            return c;
        }
    }
}