using System;

namespace GamblingProblem
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            money = 100;
            hand = new Hand();
        }

        public void exchangeHand()
        {
            return;
        }

        //very basic game strategy
        public void playTurn(Deck d)
        {
            int[] cardMatch = { 0, 0, 0, 0, 0 };
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != i && hand.getCard(i + 1) == hand.getCard(j + 1))
                    {
                        c++;
                        cardMatch[i] = c;
                        cardMatch[j] = c;
                    }
                }
            }

            if (c == 0)
            {
                Card max = hand.getCard(1);
                int maxIndex = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (hand.getCard(i + 1) > max)
                    {
                        max = hand.getCard(i + 1);
                        maxIndex = i;
                    }
                }
                cardMatch[maxIndex] = 1;
            }

            for (int i = 0; i < 5; i++)
            {
                if (cardMatch[i] == 0)
                {
                    hand.newCard(i + 1, d.getCard());
                }
            }
        }
    }
}