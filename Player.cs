﻿using System;

namespace GamblingProblem
{
    public abstract class Player
    {
        private int money;
        public Hand hand;

        public Player()
        {
            money = 0;
            hand = new Card[5];
        }
        public void addMoney(int m)
        {
            money += m;
        }
        public void removeMoney(int m)
        {
            money -= m;
        }
        public void playTurn();
        public void fold();
    }
}