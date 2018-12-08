using System;

namespace GamblingProblem
{
    public abstract class Player
    {
        protected int money;
        public Hand hand;

        public Player()
        {
            money = 0;
            hand = new Hand();
        }
        public void addMoney(int m)
        {
            money += m;
        }
        public void removeMoney(int m)
        {
            money -= m;
        }
        public void playTurn()
        {

        }
        public void fold()
        {

        }
    }
}
