using System;

namespace GamblingProblem
{
    public class HumanPlayer : Player
    {
        private string name;
        public HumanPlayer()
        {
            hand = new Hand();
            money = 100;
            name = "shark";
        }

        public HumanPlayer(string n)
        {
            hand = new Hand();
            money = 100;
            name = n;
        }

        public String Name => name;
    }
}
