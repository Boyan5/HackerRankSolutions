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
            Console.WriteLine("Solve me first");
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
            #endregion

            //2 simpleArraySum
            #region
            Console.WriteLine("Simple Array Sum");
            int[] ar = new int[] { 1, 1, 2, 3, 57, 1, 3, 4, 5 };
            Console.WriteLine(simpleArraySum(ar));
            #endregion

            //3 compareTriplets
            #region
            Console.WriteLine("Compare Triplets");
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
            Console.WriteLine("A Very Big Sum");
            long[] arL = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Console.WriteLine(aVeryBigSum(arL));
            #endregion

            //5 diagonalDifference
            #region
            Console.WriteLine("Diagonal Difference");
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
            Console.WriteLine("Plus Minus");
            int[] arrPlusMinus = new int[] { -4, 3, -9, 0, 4, 1 };
            plusMinus(arrPlusMinus);
            #endregion

            //7 staircase
            #region
            Console.WriteLine("Staircase");
            staircase(6);
            #endregion

            //8 miniMaxSum
            #region
            Console.WriteLine("MiniMax Sum");
            int[] arrMiniMaxSum = new int[] { 1, 2, 3, 4, 5 };
            miniMaxSum(arrMiniMaxSum);
            #endregion

            //9 birthdayCakeCandles 
            #region
            Console.WriteLine("Birthday Cake Candles");
            int[] arrBirthdayCakeCandles = new int[] { 3, 2, 1, 3 };
            Console.WriteLine(birthdayCakeCandles(arrBirthdayCakeCandles));
            #endregion

            //10 timeConversion
            #region
            Console.WriteLine("Time Conversion");
            string stringtimeConversion = "07:05:45PM";
            Console.WriteLine(timeConversion(stringtimeConversion));
            #endregion

            //11 gradingStudents
            #region
            Console.WriteLine("Grading Students");
            List<int> listgradingStudents = new List<int>();
            listgradingStudents.Add(73);
            listgradingStudents.Add(67);
            listgradingStudents.Add(38);
            listgradingStudents.Add(33);

            foreach (var LGS in gradingStudents(listgradingStudents))
                Console.WriteLine(LGS);
            #endregion

            //12 countApplesAndOranges
            #region
            Console.WriteLine("Count Apples and Oranges");
            int sAaO = 7;
            int tAaO = 11;
            int aAaO = 5;
            int bAaO = 15;
            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };

            countApplesAndOranges(sAaO, tAaO, aAaO, bAaO, apples, oranges);
            #endregion

            //13 kangoroo
            #region
            Console.WriteLine("Kangoroo");
            int x1Kangoroo = 0;
            int v1kangoroo = 3;
            int x2Kangoroo = 4;
            int v2Kangoroo = 2;

            Console.WriteLine(kangaroo(x1Kangoroo, v1kangoroo, x2Kangoroo, v2Kangoroo));

            #endregion

            //14 getTotalX
            #region
            Console.WriteLine("Get Total X");
            List<int> agetTotalX = new List<int>();
            agetTotalX.Add(2);
            agetTotalX.Add(4);
            List<int> bgetTotalX = new List<int>();
            bgetTotalX.Add(16);
            bgetTotalX.Add(32);
            bgetTotalX.Add(96);
            Console.WriteLine(getTotalX(agetTotalX, bgetTotalX));
            #endregion

            //15 breakingRecords
            #region
            Console.WriteLine("Breaking Records");
            int[] scoresBreakingRecords = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            foreach(var resultBreakingRecords in breakingRecords(scoresBreakingRecords))
                Console.Write(resultBreakingRecords + " ");
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

        static void staircase(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }

        static void miniMaxSum(int[] arr)
        {
            long sumMax = 0;
            long sumMin = 0;
            long n = arr.Length;
            long max = arr[0];
            long min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                sumMax += arr[i];

            }
            sumMax -= min;
            for (int i = 0; i < n; i++)
            {
                sumMin += arr[i];

            }
            sumMin -= max;

            Console.WriteLine(sumMin + " " + sumMax);

        }

        static int birthdayCakeCandles(int[] ar)
        {
            int counter = 0;
            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    counter++;
                }
            }
            return counter;

        }

        static string timeConversion(string s)
        {
            string firstTwo = s.Substring(0, 2);
            string lastTwo = s.Substring(s.Length - 2);
            string others = s.Substring(2, s.Length - 4);
            if (lastTwo.Equals("AM"))
            {
                if (firstTwo.Equals("12"))
                    firstTwo = "00";
                return firstTwo + others;
            }
            else
            {
                if (!firstTwo.Equals("12"))
                {
                    int hours = Int32.Parse(firstTwo);
                    hours += 12;
                    firstTwo = "" + hours;
                }
                return firstTwo + others;
            }

        }

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    grades[i] += 0;
                }
                else
                {
                    if (grades[i] % 5 > 2)
                    {
                        while (!(grades[i] % 5 == 0))
                        {
                            grades[i]++;
                        }
                    }
                }
            }
            return grades;

        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesCounter = 0;
            int orangesCounter = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if ((a + apples[i] >= s) && (a + apples[i] <= t))
                {
                    applesCounter++;
                }

            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (s <= b + oranges[i] && b + oranges[i] <= t)
                {
                    orangesCounter++;
                }

            }
            Console.WriteLine(applesCounter);
            Console.WriteLine(orangesCounter);

        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int jumpsFirstKangaroo = 0;
            int jumpsSecondKangaroo = 0;
            int distanceKangarooOne = x1 + v1;
            int distanceKangarooTwo = x2 + v2;

            for (int i = 1; i <= 10000; i++)
            {
                if (distanceKangarooOne == distanceKangarooTwo && jumpsFirstKangaroo == jumpsSecondKangaroo)
                    return "YES";
                else
                {
                    distanceKangarooOne += v1;
                    distanceKangarooTwo += v2;
                    jumpsFirstKangaroo++;
                    jumpsSecondKangaroo++;
                }
            }
            return "NO";


        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int foundCount = 0, maxA = a.Max(), minB = b.Min(), current = maxA;
            while (current <= minB)
            {
                if (a.All(e => current % e == 0 || e % current == 0) && b.All(e => current % e == 0 || e % current == 0))
                    foundCount++;
                current += maxA;
            };
            return foundCount;

        }

        static int[] breakingRecords(int[] scores)
        {
            int lowestScore = scores[0];
            int highestScore = scores[0];
            bool brokeLowest = false;
            bool brokeHighest = false;
            int counterLowest = 0;
            int counterHighest = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    brokeLowest = true;
                }
                if (brokeLowest)
                {
                    counterLowest++;
                    brokeLowest = false;
                }

            }

            for (int i = 01; i < scores.Length; i++)
            {
                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    brokeHighest = true;
                }
                if (brokeHighest)
                {
                    counterHighest++;
                    brokeHighest = false;
                }

            }

            return new int[] { counterHighest, counterLowest };
        }
    }
}
