using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 solveMeFirst
            #region
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
            #endregion

            //2 simpleArraySum
            #region
            int[] ar = new int[] { 1, 1, 2, 3, 57, 1, 3, 4, 5 };
            Console.WriteLine(simpleArraySum(ar));
            #endregion

            //3 compareTriplets
            #region
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            a.Add(5);
            a.Add(6);
            a.Add(7);

            b.Add(3);
            b.Add(6);
            b.Add(10);

            foreach (var c in compareTriplets(a, b))
                Console.WriteLine(c);
            #endregion

            //4 aVeryBigSum
            #region
            long[] arL = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Console.WriteLine(aVeryBigSum(arL));
            #endregion

            //5 diagonalDifference
            #region
            List<List<int>> list = new List<List<int>>();
            List<int> list1 = new List<int>();
            list1.Add(11);
            list1.Add(2);
            list1.Add(4);
            List<int> list2 = new List<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            List<int> list3 = new List<int>();
            list3.Add(10);
            list3.Add(8);
            list3.Add(-12);

            list.Add(list1);
            list.Add(list2);
            list.Add(list3);

            Console.WriteLine(diagonalDifference(list));
            #endregion

            //6 plusMinus
            #region
            int[] arrPlusMinus = new int[] { -4, 3, -9, 0, 4, 1 };
            plusMinus(arrPlusMinus);
            #endregion

        }

        static int solveMeFirst(int a, int b)
        {
            return a + b;

        }

        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var ScoreAlice = 0;
            var ScoreBob = 0;
            var i = 0;
            for (i = 0; i < 3; i++)
            {
                if (a.ElementAt(i) > b.ElementAt(i))
                {
                    ScoreAlice++;
                }
                if (a.ElementAt(i) < b.ElementAt(i))
                {
                    ScoreBob++;
                }
            }
            return new List<int> { ScoreAlice, ScoreBob };
        }

        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumDiagonal = 0;
            int sumAntiDiagonal = 0;
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sumDiagonal += arr[i][j];
                    }
                    if (i == n - 1 - j)
                    {
                        sumAntiDiagonal += arr[i][j];
                    }
                }
            }
            return Math.Abs(sumDiagonal - sumAntiDiagonal);
        }

        static void plusMinus(int[] arr)
        {
            int countPositive = 0;
            int countNegative = 0;
            int countZeros = 0;
            int n = arr.Length;
            decimal temp = (decimal)1 / n;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    countPositive++;
                }
                else if (arr[i] < 0)
                {
                    countNegative++;
                }
                else
                {
                    countZeros++;
                }
            }
            Console.WriteLine(Math.Round(countPositive * temp, 6));
            Console.WriteLine(Math.Round(countNegative * temp, 6));
            Console.WriteLine(Math.Round(countZeros * temp, 6));

        }
    }
}
