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
    }
}