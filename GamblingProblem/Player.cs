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

        public Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }

        public void addMoney(int m)
        {
            money += Math.Abs(m);
        }
        public int removeMoney(int m)
        {
            int s = money;
            if (m <= money)
            {
                money -= Math.Abs(m);
                return m;
            }
            else
            {
                money = 0;
                return s;
            }
        }
        public int getMoney()
        {
            return money;
        }
        public void fold()
        {

        }
    }
}
