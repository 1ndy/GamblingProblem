using System;

namespace GamblingProblem
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            hand = new Hand();
            money = 100;
        }
    }
}
