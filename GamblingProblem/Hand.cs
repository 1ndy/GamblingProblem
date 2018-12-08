using System;

namespace GamblingProblem
{
    public class Hand
    {
        private Card[] cards;
        private int size;

        public Hand()
        {
            cards = new Card[5];
            int size = 0;
        }

        public void clearHand()
        {
            cards = new Card[5];
            size = 0;
        }

        public void addCard(Card c)
        {
            cards[size] = c;
            size++;
        }

        public int numCardsInHand()
        {
            return size + 1;
        }

        public int rank()
        {
            return 1;
        }

        public Card getCard(int i)
        {
            return cards[i - 1];
        }

        public void newCard(int i, Card c)
        {
            cards[i - 1] = c;
        }
    }
}