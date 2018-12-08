using System;

namespace GamblingProblem
{
    public class Hand
    {
        private Card[] cards;
        private int size;

        public Hand()
        {
            cards = new Card[5];
            int size = 0;
        }

        public void clearHand()
        {
            cards = new Card[5];
            size = 0;
        }

        public void addCard(Card c)
        {
            cards[size] = c;
            size++;
        }

        public int numCardsInHand()
        {
            return size + 1;
        }

        public Card getCard(int i)
        {
            return cards[i - 1];
        }

        public void newCard(int i, Card c)
        {
            cards[i - 1] = c;
        }

        private bool isOnePair()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(j != i && cards[i] == cards[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool isTwoPair()
        {
            string pair1 = "0";
            string pair2 = "0";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != i && cards[i] == cards[j])
                    {
                        pair1 = cards[i].Number;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != i && cards[i].Number != pair1 && cards[i] == cards[j])
                    {
                        pair2 = cards[i].Number;
                    }
                }
            }
            return pair1 != "0" && pair2 != "0";
        }

        private bool isThreeOfKind()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        if(i != j && j != k && cards[i] == cards[j] && cards[j] == cards[k])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isFourOfKind()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            if (i != j && j != k && k != m && cards[i] == cards[j] && cards[j] == cards[k] && cards[k] == cards[m])
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool isFullHouse()
        {
            return isOnePair() && isThreeOfKind();
        }

        private bool isFlush(int[][] matrix)
        {
            //sum each column
            int sum = 0;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    sum += matrix[j][i];
                }
                if (sum == 5)
                    return true;
            }
            return false;
        }

        private bool isStraight(int[][] matrix)
        {
            int[] nums = new int[13];
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(matrix[i][j] == 1)
                    {
                        nums[i] = 1;
                        break;
                    }
                }
            }

            for(int i = 0; i < 9; i++)
            {
                if(nums[i] == 1)
                {
                    if(nums[i+1] == 1 && nums[i+2] == 1 && nums[i+3] == 1)
                    {
                        if(nums[i+4] == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isStraightFlush(int[][] matrix)
        {
            return isStraight(matrix) && isFlush(matrix);
        }

        private bool isRoyalFlush(int[][] matrix)
        {
            if (isStraightFlush(matrix))
            {
                int[] nums = new int[13];
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[i][j] == 1)
                        {
                            nums[i] = 1;
                            break;
                        }
                    }
                }
                return nums[12] == 1;
            }
            return false;
        }
        //write a matrix flatteing function and use that to detect hands

        public int rank()
        {
            int[][] handMatrix = new int[13][];
            for(int i = 0; i < 13; i++)
            {
                handMatrix[i] = new int[4];
            }
            int[] rank = new int[9];
            for(int i = 0; i < 5; i++)
            {
                handMatrix[cards[i].getRawNumber()][cards[i].getRawSuit()] = 1;
            }
            if (isOnePair()) rank[0] = 1;
            if (isTwoPair()) rank[1] = 1;
            if (isThreeOfKind()) rank[2] = 1;
            if (isStraight(handMatrix)) rank[3] = 1;
            if (isFlush(handMatrix)) rank[4] = 1;
            if (isFullHouse()) rank[5] = 1;
            if (isFourOfKind()) rank[6] = 1;
            if (isStraightFlush(handMatrix)) rank[7] = 1;
            if (isRoyalFlush(handMatrix)) rank[8] = 1;

            int rankNum = 0;

            for(int i = 0; i < 9; i++)
            {
                if (rank[i] == 1)
                    rankNum += (int)Math.Pow(2, i+1);
            }
            return rankNum;
        }

        public static bool operator <(Hand a, Hand b)
        {
            return a.rank() < b.rank();
        }

        public static bool operator >(Hand a, Hand b)
        {
            return a.rank() > b.rank();
        }

        public static bool operator <=(Hand a, Hand b)
        {
            return a < b || a == b;
        }

        public static bool operator >=(Hand a, Hand b)
        {
            return a > b || a == b;
        }
    }
}