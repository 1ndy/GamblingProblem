using System;

namespace GamblingProblem
{
    public class HumanPlayer : Player
    {
        public Hand hand;
        int money;
        public HumanPlayer()
        {
            hand = new Hand();
            money = 100;
        }
    }
}
