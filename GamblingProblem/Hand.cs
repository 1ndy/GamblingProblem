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

        public HumanPlayer HumanPlayer
        {
            get => default(HumanPlayer);
            set
            {
            }
        }

        public ComputerPlayer ComputerPlayer
        {
            get => default(ComputerPlayer);
            set
            {
            }
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

        public Card maxCard()
        {
            Card m = cards[0];
            for(int i = 0; i < 5; i++)
            {
                if(cards[i] > m)
                {
                    m = cards[i];
                }
            }
            return m;
        }

        private int isOnePair(int[][] matrix)
        {
            int[] nums = flatten(matrix);
            for (int i = 0; i < 13; i++)
            {
                if (nums[i] == 2)
                {
                    return 1 + (i*7);
                }
            }
            return 0;
        }

        private int isTwoPair(int[][] matrix)
        {
            int firstPair = 0;
            int[] nums = flatten(matrix);
            int i;
            for (i = 0; i < 13; i++)
            {
                if (nums[i] == 2)
                {
                    firstPair = 1+(i*7);
                    break;
                }
            }
            if(firstPair > 0)
            {
                for (int j = 12; j > i; j--)
                {
                    if (nums[j] == 2)
                        return firstPair + (j*7);
                }
            }
            return 0;
        }

        private int isThreeOfKind(int[][] matrix)
        {
            int[] nums = flatten(matrix);
            for (int i = 0; i < 13; i++)
            {
                if (nums[i] == 3)
                    return 1 + (i*7);
            }
            return 0;
        }

        private int isFourOfKind(int[][] matrix)
        {
            int[] nums = flatten(matrix);
            for (int i = 0; i < 13; i++)
            {
                if (nums[i] == 4)
                    return 1+(i*7);
            }
            return 0;
        }

        private int isFullHouse(int[][] matrix)
        {
            if(isOnePair(matrix) > 0 && isThreeOfKind(matrix) > 0)
            {
                return 1 + ((isOnePair(matrix) + (isThreeOfKind(matrix))*7));
            }
            return 0;
        }

        private int isFlush(int[][] matrix)
        {
            //sum each column
            int sum = 0;
            int maxJ = 0;
            for(int i = 0; i < 4; i++)
            {
                sum = 0;
                for (int j = 0; j < 13; j++)
                {
                    sum += matrix[j][i];
                    if(matrix[j][i] > 0)
                    {
                        maxJ = j;
                    }
                }
                if (sum == 5)
                    return 1 + (maxJ*7);
            }
            return 0;
        }

        private int isStraight(int[][] matrix)
        {
            int[] nums = flatten(matrix);
            for(int i = 0; i < 9; i++)
            {
                if(nums[i] == 1)
                {
                    if(nums[i+1] == 1 && nums[i+2] == 1 && nums[i+3] == 1)
                    {
                        if(nums[i+4] == 1)
                        {
                            return 1 + ((i + 4)*7);
                        }
                    }
                }
            }
            return 0;
        }

        private int isStraightFlush(int[][] matrix)
        {
            if(isStraight(matrix) > 0  && isFlush(matrix) > 0)
            {
                return 1 + ((isStraight(matrix) + isFlush(matrix)) * 7);
            }
            return 0;
        }

        private int isRoyalFlush(int[][] matrix)
        {
            if (isStraightFlush(matrix) > 0)
            {
                if(flatten(matrix)[12] == 1)
                {
                    return 1 + (isStraightFlush(matrix)*7);
                }
            }
            return 0;
        }
        //write a matrix flatteing function and use that to detect hands

        private int[] flatten(int[][] matrix)
        {
            int[] nums = new int[13];
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    nums[i] += matrix[i][j];
                }
            }
            return nums;
        }

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
            rank[0] = isOnePair(handMatrix);
            rank[1] = isTwoPair(handMatrix);
            rank[2] = isThreeOfKind(handMatrix);
            rank[3] = isStraight(handMatrix);
            rank[4] = isFlush(handMatrix);
            rank[5] = isFullHouse(handMatrix);
            rank[6] = isFourOfKind(handMatrix);
            rank[7] = isStraightFlush(handMatrix);
            rank[8] = isRoyalFlush(handMatrix);

            int rankNum = 0;

            int t = 8;
            while(t > -1 && rank[t] == 0)
            {
                t--;
            }
            if(t >= 0)
            {
                rankNum = (int)Math.Pow(10.0, t+1) + rank[t];
            }
            else
            {
                rankNum = 1;
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

        public static bool operator ==(Hand a, int b)
        {
            return a.rank() == b;
        }

        public static bool operator !=(Hand a, int b)
        {
            return a.rank() != b;
        }
    }
}