using System;

namespace ComputerPlayer
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            money = 100;
        }

        //preserve matching cards in hand
        //very basic game strategy
        public void playTurn(Deck d)
        {
            int[] cardMatch = {0,0,0,0,0};
            int c = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (i != j && hand.getCard(i + 1) == hand.getCard(j + 1))
                    {
                        c++;
                        cardMatch[i] = 1;
                        cardMatch[j] = 1;
                    }
            for (int i = 0; i < 5; i++)
                if (cardMatch[i] > 0)
                    hand.newCard(i+1,d.getCard());
        }
    }
}