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
            money += Math.Abs(m);
        }
        public void removeMoney(int m)
        {
            money -= Math.Abs(m);
        }
        public int getMoney()
        {
            return money;
        }

        public void playTurn()
        {

        }
        public void fold()
        {

        }
    }
}
