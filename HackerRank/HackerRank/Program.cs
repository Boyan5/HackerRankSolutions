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

            foreach (var resultBreakingRecords in breakingRecords(scoresBreakingRecords))
                Console.Write(resultBreakingRecords + " ");
            #endregion

            //16 birthday
            #region
            Console.WriteLine("Birthday");
            List<int> listBirthday = new List<int>();
            listBirthday.Add(1);
            listBirthday.Add(2);
            listBirthday.Add(1);
            listBirthday.Add(3);
            listBirthday.Add(2);
            int dBirthday = 3;
            int mBirthday = 2;
            Console.WriteLine(birthday(listBirthday, dBirthday, mBirthday));
            #endregion

            //17 divisibleSumPairs
            #region
            Console.WriteLine("Divisible Sum Pairs");
            int nDivisibleSumPairs = 6;
            int kDivisibleSumpairs = 3;
            int[] arDivisibleSumPairs = new int[] { 1, 3, 2, 6, 1, 2 };
            Console.WriteLine(divisibleSumPairs(nDivisibleSumPairs, kDivisibleSumpairs, arDivisibleSumPairs));
            #endregion

            //18 migratoryBirds 
            #region
            Console.WriteLine("Migratory Birds");
            List<int> listMigratoryBirds = new List<int>();
            listMigratoryBirds.Add(1);
            listMigratoryBirds.Add(4);
            listMigratoryBirds.Add(4);
            listMigratoryBirds.Add(4);
            listMigratoryBirds.Add(5);
            listMigratoryBirds.Add(3);
            Console.WriteLine(migratoryBirds(listMigratoryBirds));
            #endregion

            //19 dayOfProgrammer
            #region
            Console.WriteLine("Day of Programmer");
            Console.WriteLine(dayOfProgrammer(2017));
            #endregion

            //20 bonAppetit
            #region
            Console.WriteLine("Bon Appetit");
            List<int> listBonAppetit = new List<int>();
            listBonAppetit.Add(3);
            listBonAppetit.Add(10);
            listBonAppetit.Add(2);
            listBonAppetit.Add(9);
            int kBonAppetit = 1;
            int bBonAppetit = 12;
            bonAppetit(listBonAppetit, kBonAppetit, bBonAppetit);
            #endregion

            //21 sockMerchant
            #region
            Console.WriteLine("Sock Merchant");
            int nSockMerchant = 9;
            int[] arSockMerchant = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, };
            Console.WriteLine(sockMerchant(nSockMerchant, arSockMerchant));
            #endregion

            //22 pageCount
            #region
            Console.WriteLine("Page Count");
            int nPageCount = 6;
            int pPageCount = 2;
            Console.WriteLine(pageCount(nPageCount, pPageCount));
            #endregion

            //23 countingValleys 
            #region
            Console.WriteLine("Counting Valleys");
            int nCountingValleys = 8;
            string sCountingValleys = "UDDDUDUU";
            Console.WriteLine(countingValleys(nCountingValleys, sCountingValleys));
            #endregion

            //24 getMoneySpent
            #region
            Console.WriteLine("Get Money Spent");
            int[] keyboards = new int[] { 3, 1 };
            int[] drives = new int[] { 5, 2, 8 };
            int bgetMoneySpent = 10;
            Console.WriteLine(getMoneySpent(keyboards, drives, bgetMoneySpent));
            #endregion

            //25 catAndMouse
            #region
            Console.WriteLine("Cat and Mouse");
            int xCaM = 1;
            int yCaM = 2;
            int zCaM = 3;
            Console.WriteLine(catAndMouse(xCaM, yCaM, zCaM));
            #endregion

            //26 formingMagicSquare
            #region
            Console.WriteLine("Forming Magic Square");
            int[][] sFormingMagicSquare = new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 5 } };
            Console.WriteLine(formingMagicSquare(sFormingMagicSquare));
            #endregion

            //27 pickingNumbers
            #region
            Console.WriteLine("Picking Numbers");
            List<int> aPickingNumbers = new List<int>();
            aPickingNumbers.Add(4);
            aPickingNumbers.Add(6);
            aPickingNumbers.Add(5);
            aPickingNumbers.Add(3);
            aPickingNumbers.Add(3);
            aPickingNumbers.Add(1);
            Console.WriteLine(pickingNumbers(aPickingNumbers));
            #endregion

            //28 hurdleRace
            #region
            Console.WriteLine("Hurdle Race");
            int kHurdleRace = 4;
            int[] heightHurdleRace = new int[] { 1, 6, 3, 5, 2 };
            Console.WriteLine(hurdleRace(kHurdleRace, heightHurdleRace));
            #endregion

            //29 designerPDFViewer
            #region
            Console.WriteLine("Designer PDF Viewer");
            int[] hDesignerPDFViewer = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, };
            string wordDesignerPDFViewer = "abc";
            Console.WriteLine(designerPdfViewer(hDesignerPDFViewer, wordDesignerPDFViewer));
            #endregion

            //30 utopianTree
            #region
            Console.WriteLine("Utopian Tree");
            int nUtopianTree = 0;
            Console.WriteLine(utopianTree(nUtopianTree));
            #endregion

            //31 angryProfessor
            #region
            Console.WriteLine("Angry Professor");
            int kAngryProfessor = 3;
            int[] aAngryProfessor = new int[] { -1, -3, 4, 2 };
            Console.WriteLine(angryProfessor(kAngryProfessor, aAngryProfessor));
            #endregion

            //32 beautifulDays 
            #region
            Console.WriteLine("Beautiful Days");
            int iBeautifulDays = 20;
            int jBeautifulDays = 23;
            int kBeautifulDays = 6;
            Console.WriteLine(beautifulDays(iBeautifulDays, jBeautifulDays, kBeautifulDays));
            #endregion

            //33 viralAdvertising
            #region
            Console.WriteLine("Viral Advertising");
            int nViralAdvertising = 3;
            Console.WriteLine(viralAdvertising(nViralAdvertising));
            #endregion

            //37 saveThePrisoner
            #region
            Console.WriteLine("Save the Prisoner");
            int nSavethePrisoner = 5;
            int mSavethePrisoner = 2;
            int sSavethePrisoner = 1;
            Console.WriteLine(saveThePrisoner(nSavethePrisoner, mSavethePrisoner, sSavethePrisoner));
            #endregion

            //38 circularArrayRotation
            #region
            Console.WriteLine("Circular Array Rotation");
            int[] aCircularArrayRotation = new int[] { 1, 2, 3 };
            int kCircularArrayRotation = 2;
            int[] queriesCircularArrayRotation = new int[] { 0, 1, 2 };
            foreach (var CAR in circularArrayRotation(aCircularArrayRotation, kCircularArrayRotation, queriesCircularArrayRotation))
                Console.WriteLine(CAR);
            #endregion

            //39 jumpingOnClouds
            #region
            Console.WriteLine("Jumping On Clouds");
            int[] cJumpingOnClouds = new int[] { 0, 0, 1, 0, 0, 1, 1, 0 };
            int kJumpingOnClouds = 2;
            Console.WriteLine(jumpingOnClouds(cJumpingOnClouds, kJumpingOnClouds));
            #endregion

            //40 findDigits
            #region
            Console.WriteLine("Find Digits");
            int nFindDigits = 12;
            Console.WriteLine(findDigits(nFindDigits));
            #endregion

            //41 squares
            #region
            Console.WriteLine("Squares");
            int aSquares = 17;
            int bSquares = 24;
            Console.WriteLine(squares(aSquares, bSquares));
            #endregion

            //42 libraryFine
            #region
            Console.WriteLine("Library Fine");
            int d1LibraryFine = 9;
            int m1LibraryFine = 6;
            int y1LibraryFine = 2015;
            int d2LibraryFine = 6;
            int m2LibraryFine = 6;
            int y2LibraryFine = 2015;
            Console.WriteLine(libraryFine(d1LibraryFine, m1LibraryFine, y1LibraryFine, d2LibraryFine, m2LibraryFine, y2LibraryFine));
            #endregion

            //43 cutTheSticks
            #region
            Console.WriteLine("Cut the Sticks");
            int[] arrCutTheSticks = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };
            foreach (var CTS in cutTheSticks(arrCutTheSticks))
                Console.WriteLine(CTS);
            #endregion

            //44 repeatedString
            #region
            Console.WriteLine("Repeated String");
            string sRepeatedString = "aba";
            long nRepeatedString = 10;
            Console.WriteLine(repeatedString(sRepeatedString, nRepeatedString));
            #endregion

            //45 jumpingOnClouds
            #region
            Console.WriteLine("Jumping on Clouds");
            int[] cJumpingOnCloudsTwo = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(cJumpingOnCloudsTwo));
            #endregion

            //46 equalizeArray
            #region
            Console.WriteLine("Equalize Array");
            int[] arrEqualizeArray = new int[] { 3, 3, 2, 1, 3 };
            Console.WriteLine(equalizeArray(arrEqualizeArray));
            #endregion

            //47 taumBday
            #region
            Console.WriteLine("Taum Bday");
            long bTaumBday = 10;
            long wTaumBday = 10;
            long bcTaumBday = 1;
            long wcTaumBday = 1;
            long zTaumBday = 1;
            Console.WriteLine(taumBday(bTaumBday, wTaumBday, bcTaumBday, wcTaumBday, zTaumBday));
            #endregion

            //48 encryption
            #region
            Console.WriteLine("Encryption");
            string sEncryption = "haveaniceday";
            Console.WriteLine(encryption(sEncryption));
            #endregion

            //49 kaprekarNumbers 
            #region
            Console.WriteLine("Kaprekar Numbers");
            int pKaprekarNumbers = 1;
            int qKaprekarNumbers = 100;
            kaprekarNumbers(pKaprekarNumbers, qKaprekarNumbers);
            Console.WriteLine();
            #endregion

            //50 beautifulTriplets
            #region
            Console.WriteLine("Beautiful Triplets");
            int dBeautifulTriplets = 3;
            int[] arrBeatufilTriplets = new int[] { 1, 2, 4, 5, 7, 8, 10 };
            Console.WriteLine(beautifulTriplets(dBeautifulTriplets, arrBeatufilTriplets));
            #endregion

            //51 minimumDistances 
            #region
            Console.WriteLine("Minimum distances");
            int[] aMinimumDistances = new int[] { 7, 1, 3, 4, 1, 7 };
            Console.WriteLine(minimumDistances(aMinimumDistances));
            #endregion

            //52  howManyGames
            #region
            Console.WriteLine("How Many Games");
            int pHowManyGames = 20;
            int dHowManyGames = 3;
            int mHowManyGames = 6;
            int sHowManyGames = 80;
            Console.WriteLine(howManyGames(pHowManyGames, dHowManyGames, mHowManyGames, sHowManyGames));
            #endregion

            //53 chocalateFeast
            #region
            Console.WriteLine("Chocolate Feast");
            int nChocolateFeast = 10;
            int cChocolateFeast = 2;
            int mChocolateFeast = 5;
            Console.WriteLine(chocolateFeast(nChocolateFeast, cChocolateFeast, mChocolateFeast));
            #endregion

            //54 serviceLane
            #region
            Console.WriteLine("Service Lane");
            int nServiceLane = 5;
            int[] widthServiceLane = new int[] { 2, 3, 1, 2, 3, 2, 3, 3 };
            int[][] casesServiceLane = new int[][]
            {
                new int[] { 0, 3 },
                new int[] { 4, 6 },
                new int[] { 6, 7 },
                new int[] { 3, 5 },
                new int[] { 0, 7 }
            };
            foreach (var SL in serviceLane(nServiceLane, widthServiceLane, casesServiceLane))
                Console.WriteLine(SL);
            #endregion

            //55 workBook
            #region
            Console.WriteLine("Workbook");
            int nWorkbook = 5;
            int kWorkbook = 3;
            int[] arrWorkbook = new int[] { 4, 2, 6, 1, 10 };
            Console.WriteLine(workbook(nWorkbook, kWorkbook, arrWorkbook));
            #endregion

            //56 flatlandSpaceStations 
            #region
            Console.WriteLine("FlatlandSpaceStations");
            int nFlatlandSpaceStations = 5;
            int[] cFlatlandSpaceStations = new int[] { 0, 4 };
            Console.WriteLine(flatlandSpaceStations(nFlatlandSpaceStations, cFlatlandSpaceStations));
            #endregion

            //57 fairRations 
            #region
            Console.WriteLine("Fair Rations");
            List<int> BFairRations = new List<int>();
            BFairRations.Add(2);
            BFairRations.Add(3);
            BFairRations.Add(4);
            BFairRations.Add(5);
            BFairRations.Add(6);
            Console.WriteLine(fairRations(BFairRations));
            #endregion

            //58 cavityMap
            #region
            Console.WriteLine("Cavity Map");
            List<string> gridCavityMap = new List<string>();
            gridCavityMap.Add("1112");
            gridCavityMap.Add("1912");
            gridCavityMap.Add("1892");
            gridCavityMap.Add("1234");
            foreach (var Cavitymap in cavityMap(gridCavityMap))
                Console.WriteLine(Cavitymap);
            #endregion

            //59 strangeCounter
            #region
            Console.WriteLine("Strange Counter");
            long tStrangeCounter = 4;
            Console.WriteLine(strangeCounter(tStrangeCounter));
            #endregion

            //60 superReducedString
            #region
            Console.WriteLine("Super Reduced String");
            string sSuperReducedString = "aaabccddd";
            Console.WriteLine(superReducedString(sSuperReducedString));
            #endregion

            //61 introTutorial
            #region
            Console.WriteLine("Intro Tutorial");
            int VIntroTutorial = 4;
            int[] arrIntroTutorial = new int[] { 1, 4, 5, 7, 9, 12 };
            Console.WriteLine(introTutorial(VIntroTutorial, arrIntroTutorial));
            #endregion

            //62 camelCase
            #region
            Console.WriteLine("Camel Case");
            string sCamelCase = "saveChangesInTheEditor";
            Console.WriteLine(camelcase(sCamelCase));
            #endregion

            //63 minimumNumber
            #region
            Console.WriteLine("Minimum Number");
            int nMinimumNumber = 3;
            string passwordMinimumNumber = "Ab1";
            Console.WriteLine(minimumNumber(nMinimumNumber, passwordMinimumNumber));
            #endregion

            //64 insertionSort
            #region
            Console.WriteLine("Insertion Sort");
            int[] AInsertionSort = new int[] { 4, 1, 3, 5, 6, 2 };
            insertionSort(AInsertionSort);
            #endregion

            //65 caesarCipher
            #region
            Console.WriteLine("Caesar Cipher");
            string sCaesarCipher = "middle-Outz";
            int kCaesarCipher = 2;
            Console.WriteLine(caesarCipher(sCaesarCipher, kCaesarCipher));
            #endregion

            //66 marsExploration
            #region
            Console.WriteLine("Mars Exploration");
            string sMarsExploration = "SOSSPSSQSSOR";
            Console.WriteLine(marsExploration(sMarsExploration));
            #endregion

            //67 hackerrankInString
            #region
            Console.WriteLine("HackerRank in String");
            string sHackerRankInString = "hereiamstackerrank";
            Console.WriteLine(hackerrankInString(sHackerRankInString));
            #endregion

            //68 quickSort
            #region
            Console.WriteLine("Quick Sort");
            int[] arrQuickSort = new int[] { 4, 5, 3, 7, 2 };
            foreach (var aQuickSort in quickSort(arrQuickSort))
                Console.Write(aQuickSort + " ");
            Console.WriteLine();
            #endregion

            //69 pangrams
            #region
            Console.WriteLine("Pangrams");
            string sPangrams = "We promptly judged antique ivory buckles for the next prize";
            Console.WriteLine(pangrams(sPangrams));
            #endregion

            //70 separateNumbers
            #region
            Console.WriteLine("Separate Numbers");
            string sSeparateNumbers = "99100";
            separateNumbers(sSeparateNumbers);
            #endregion

            //71 funnyString
            #region
            Console.WriteLine("Funny String");
            string sFunnyString = "acxz";
            Console.WriteLine(funnyString(sFunnyString));
            #endregion

            //72 countingSort
            #region
            Console.WriteLine("Counting Sort");
            int[] arrCountingSort = new int[] { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 };
            foreach (var aCountingSort in countingSort(arrCountingSort))
                Console.Write(aCountingSort + " ");
            Console.WriteLine();
            #endregion

            //73 countingSort2
            #region
            Console.WriteLine("Counting Sort 2");
            int[] arrCS2 = new int[] { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 };
            List<int> arrCountingSort2 = arrCS2.ToList();
            foreach (var aCountingSort2 in countingSort2(arrCountingSort2))
                Console.Write(aCountingSort2 + " ");
            Console.WriteLine();
            #endregion

            //74 gemStones
            #region
            Console.WriteLine("Gemstones");
            string[] arrGemStones = new string[] { "abcdde", "baccd", "eeabg" };
            Console.WriteLine(gemstones(arrGemStones));
            #endregion

            //75 alternatingCharacters
            #region
            Console.WriteLine("Alternating Characters");
            string sAlternatingCharacters = "AAABBB";
            Console.WriteLine(alternatingCharacters(sAlternatingCharacters));
            #endregion

            //76 beautifulBinaryString
            #region
            Console.WriteLine("Beautiful Binary String");
            string bBeautifulBinaryString = "0101010";
            Console.WriteLine(beautifulBinaryString(bBeautifulBinaryString));
            #endregion

            //77 closestNumbers
            #region
            Console.WriteLine("Closest Numbers");
            int[] arrClosestNumbers = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };
            foreach (var aClosestNumbers in closestNumbers(arrClosestNumbers))
                Console.Write(aClosestNumbers + " ");
            Console.WriteLine();
            #endregion

            //78 theLoveLetterMystery 
            #region
            Console.WriteLine("The Love Letter Mystery");
            string sTheLoveLetterMystery = "cba";
            Console.WriteLine(theLoveLetterMystery(sTheLoveLetterMystery));
            #endregion

            //79 findMedian
            #region
            Console.WriteLine("Find Median");
            List<int> arrFindMedian = new List<int>();
            arrFindMedian.Add(0);
            arrFindMedian.Add(1);
            arrFindMedian.Add(2);
            arrFindMedian.Add(4);
            arrFindMedian.Add(6);
            arrFindMedian.Add(5);
            arrFindMedian.Add(3);
            Console.WriteLine(findMedian(arrFindMedian));
            #endregion

            //80 anagram
            #region
            Console.WriteLine("Anagram");
            string sAnagram = "asdfjoieufoa";
            Console.WriteLine(anagram(sAnagram));
            #endregion

            //81 makingAnagrams
            #region
            Console.WriteLine("Making Anagrams");
            string s1MakingAnagrams = "cde";
            string s2MakingAnagrams = "abc";
            Console.WriteLine(makingAnagrams(s1MakingAnagrams, s2MakingAnagrams));
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

        static int birthday(List<int> s, int d, int m)
        {
            int total = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                var segsSum = s.GetRange(i, m).Aggregate((a, b) => a + b);
                if (segsSum == d)
                {
                    total++;
                }
            }
            return total;
        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int counter = 0;
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i < n - j; i++)
                {
                    if ((ar[j] + ar[i + j]) % k == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static int migratoryBirds(List<int> arr)
        {
            int n = arr.Count;
            int[] ary = new int[n];
            for (int i = 0; i < n; i++)
                ary[arr[i]]++;
            int max = 0, maxpos = 0;
            for (int i = 0; i < n; i++)
            {
                if (ary[i] > max)
                {
                    max = ary[i];
                    maxpos = i;
                }
            }
            return maxpos;

        }

        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
            {
                return "26.09." + year;
            }
            else if ((year >= 1700 && year <= 1917 && year % 4 == 0) || (year > 1918 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)))
            {
                return "12.09." + year;
            }
            else
            {
                return "13.09." + year;
            }
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int fullBill = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                fullBill += bill[i];

            }
            int billActual = (fullBill - bill[k]) / 2;
            if (b == billActual)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - billActual);
            }



        }

        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            int[] colorsCount = ar.GroupBy(x => x).
                        Select(x => x.Count()).
                        ToArray();
            foreach (int count in colorsCount)
            {
                pairs += ((count - (count % 2)) / 2);
            }
            return pairs;
        }

        static int pageCount(int n, int p)
        {
            int totalPageTurnCountFromFront = n / 2;
            int targetPageTurnCountFromFront = p / 2;
            int targetPageTurnCountFromBack = totalPageTurnCountFromFront - targetPageTurnCountFromFront;

            return Math.Min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);

        }

        static int countingValleys(int n, string s)
        {
            int altitude = 0;
            int valleys = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i].Equals('U'))
                {
                    if (altitude == -1)
                    {
                        valleys++;
                    }
                    altitude++;
                }

                if (s[i].Equals('D'))
                {
                    altitude--;
                }
            }

            return valleys;
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if ((keyboards[i] + drives[j] > max) && keyboards[i] + drives[j] <= b)
                    {
                        max = keyboards[i] + drives[j];
                    }
                }
            }
            return max;
        }

        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) < Math.Abs(y - z))
            {
                return "Cat A";
            }
            else if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }

        static int formingMagicSquare(int[][] s)
        {
            int cost = Int32.MaxValue;
            int[,] t = new int[,]
                    {
                        {4,9,2,3,5,7,8,1,6},
                        {4,3,8,9,5,1,2,7,6},
                        {2,9,4,7,5,3,6,1,8},
                        {2,7,6,9,5,1,4,3,8},
                        {8,1,6,3,5,7,4,9,2},
                        {8,3,4,1,5,9,6,7,2},
                        {6,7,2,1,5,9,8,3,4},
                        {6,1,8,7,5,3,2,9,4},
                    };
            int temp = 0;
            for (int i = 0; i < 8; i++)
            {
                temp = Math.Abs(s[0][0] - t[i, 0]) + Math.Abs(s[0][1] - t[i, 1]) + Math.Abs(s[0][2] - t[i, 2]) + Math.Abs(s[1][0] - t[i, 3]) + Math.Abs(s[1][1] - t[i, 4]) + Math.Abs(s[1][2] - t[i, 5]) + Math.Abs(s[2][0] - t[i, 6]) + Math.Abs(s[2][1] - t[i, 7]) + Math.Abs(s[2][2] - t[i, 8]);
                cost = temp < cost ? temp : cost;
            }
            return cost;
        }

        public static int pickingNumbers(List<int> a)
        {
            int[] frequency = new int[101];
            int result = Int32.MinValue;

            for (int i = 0; i < a.Count; i++)
            {
                int index = a[i];
                frequency[index]++;
            }

            for (int i = 1; i <= 100; i++)
            {
                result = Math.Max(result, frequency[i] + frequency[i - 1]);
            }
            return result;
        }

        static int hurdleRace(int k, int[] height)
        {
            int max = k;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                }
            }
            return max - k;
        }

        static int designerPdfViewer(int[] h, string word)
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] indexes = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i].Equals(letters[j]))
                    {
                        indexes[i] = j;
                    }
                }
            }
            int max = h[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (h[indexes[i]] > max)
                {
                    max = h[indexes[i]];
                }
            }
            return max * word.Length;
        }

        static int utopianTree(int n)
        {
            int i = 0;
            int sum = 0;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    sum += 1;
                }
                else
                {
                    sum *= 2;
                }
                i++;
            }
            return sum;
        }

        static string angryProfessor(int k, int[] a)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 1)
                {
                    counter++;
                }
            }
            return counter >= k ? "NO" : "YES";
        }

        //beautifulDays
        #region
        static int beautifulDays(int i, int j, int k)
        {
            int counter = 0;
            for (int c = i; c <= j; c++)
            {
                if (Math.Abs(c - reverseInt(c)) % k == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int reverseInt(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                reverse = 10 * reverse + number % 10;
                number = number / 10;
            }
            reverse += number;
            return reverse;
        }
        #endregion

        static int viralAdvertising(int n)
        {
            int shared = 5;
            int liked = 0;
            int cumulative = 0;
            for (int i = 0; i < n; i++)
            {
                liked = shared / 2;
                cumulative += liked;
                shared = liked * 3;
            }
            return cumulative;
        }

        static int saveThePrisoner(int n, int m, int s)
        {
            return ((m + s - 2) % n) + 1;
        }

        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] newArr = new int[a.Length];
            int[] indices = new int[queries.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[(i + k) % a.Length] = a[i];
            }

            for (int i = 0; i < indices.Length; i++)
            {
                indices[i] = newArr[queries[i]];
            }
            return indices;
        }

        static int jumpingOnClouds(int[] c, int k)
        {
            int n = c.Length;
            int energy = 100;
            int i = k % n;
            energy -= c[i] * 2 + 1;
            while (i != 0)
            {
                i = (i + k) % n;
                energy -= c[i] * 2 + 1;
            }
            return energy;
        }

        static int findDigits(int n)
        {
            int counter = 0;
            int copied = n;
            while (copied != 0)
            {
                if (copied % 10 != 0 && n % (copied % 10) == 0)
                    counter++;
                copied /= 10;
            }
            return counter;
        }

        static int squares(int a, int b)
        {
            int start = (int)Math.Ceiling(Math.Sqrt(a));
            int end = (int)Math.Floor(Math.Sqrt(b));
            return end - start + 1;
        }

        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = 0;
            if (y1 > y2)
            {
                fine = 10000;
                return fine;
            }
            else if (y1 < y2)
                return fine;

            else
            {
                if (m1 > m2)
                    fine = 500 * (m1 - m2);
                else if (m1 < m2)
                    return fine;
                else
                {
                    if (d1 > d2)
                        fine = 15 * (d1 - d2);
                }

            }
            return fine;
        }

        static int[] cutTheSticks(int[] arr)
        {

            List<int> cuts = new List<int>();
            arr = arr.OrderBy(x => x).ToArray();
            int min = arr[0];
            cuts.Add(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                    cuts.Add(arr.Length - i);
                }
            }
            return cuts.ToArray();
        }

        static long repeatedString(string s, long n)
        {
            long whole = n / s.Length;
            int remainder = (int)(n % s.Length);
            int aCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('a'))
                    aCount++;
            }
            long total = aCount * whole;
            if (remainder == 0)
                return total;
            else
            {
                string part = s.Substring(0, remainder);
                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i].Equals('a'))
                        total++;
                }
            }
            return total;
        }

        static int jumpingOnClouds(int[] c)
        {
            int count = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == 0) i++;
                count++;
            }
            return count;
        }

        static int equalizeArray(int[] arr)
        {
            int[] frequency = new int[500];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                frequency[index]++;
            }
            var max = frequency.Max();
            int maxIndex = Array.IndexOf(frequency, max);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != maxIndex)
                    counter++;
            }

            return counter;
        }

        public static long taumBday(long b, long w, long bc, long wc, long z)
        {
            long result = 0;
            if (bc > wc + z)
            {
                result = w * wc + b * (wc + z);
            }
            else if (wc > bc + z)
            {
                result = b * bc + w * (bc + z);
            }
            else
            {
                result = b * bc + w * wc;
            }
            return result;
        }

        static string encryption(string s)
        {
            string sWithoutSpace = s.Replace(" ", String.Empty);
            double stringLength = sWithoutSpace.Length;
            int upperBoundary = (int)Math.Ceiling(Math.Sqrt(stringLength));
            int lowerBoundary = (int)Math.Floor(Math.Sqrt(stringLength));
            if (upperBoundary * lowerBoundary < stringLength)
            {
                lowerBoundary += 1;
            }
            string result = "";

            for (int i = 0; i < upperBoundary; i++)
            {
                for (int j = i; j < sWithoutSpace.Length; j += upperBoundary)
                {
                    result += sWithoutSpace[j];
                }
                result += " ";
            }
            return result;
        }

        // kaprekarNumbers
        #region
        static void kaprekarNumbers(int p, int q)
        {
            bool kaprekar = false;
            for (int i = p; i <= q; i++)
            {
                if (iskaprekarNumber(i))
                {
                    kaprekar = true;
                    Console.Write(i + " ");
                }

            }
            if (!kaprekar)
                Console.WriteLine("INVALID RANGE");
        }

        static bool iskaprekarNumber(int n)
        {
            long squared = (long)n * n;
            string str = squared.ToString();
            string left = str.Substring(0, str.Length / 2);
            string right = str.Substring(str.Length / 2);
            int numL = (left == "" || left == null) ? 0 : int.Parse(left);
            int numR = (right == "" || right == null) ? 0 : int.Parse(right);
            if (numL + numR == n)
                return true;
            else
                return false;
        }
        #endregion

        static int beautifulTriplets(int d, int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] == d)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (arr[k] - arr[j] == d)
                                counter++;
                        }
                    }
                }
            }
            return counter;
        }

        static int minimumDistances(int[] a)
        {
            int minDistance = int.MaxValue;
            bool equalElement = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        equalElement = true;
                        if (j - i < minDistance)
                        {
                            minDistance = j - i;
                        }
                    }
                }
            }
            if (equalElement)
                return minDistance;
            else
                return -1;
        }

        static int howManyGames(int p, int d, int m, int s)
        {
            int counter = 0;
            int sum = 0;
            int previousPrice = 0;

            while (s >= sum + m && !(s < p))
            {
                if (previousPrice + p > s)
                {
                    break;
                }
                counter++;
                sum += p;
                previousPrice = p;
                if (p - d < m)
                    p = m;
                else
                    p -= d;
            }
            return counter;
        }

        static int chocolateFeast(int n, int c, int m)
        {
            int choco = n / c;
            int wrappers = 0;
            int counter = 0;

            while (choco > 0)
            {
                counter += choco;
                wrappers += choco;
                choco = wrappers / m;
                wrappers %= m;
            }
            return counter;
        }

        static int[] serviceLane(int n, int[] width, int[][] cases)
        {
            List<int> mins = new List<int>();

            for (int i = 0; i < cases.GetLength(0); i++)
            {
                int min = int.MaxValue;
                for (int j = cases[i][0]; j <= cases[i][1]; j++)
                {
                    if (width[j] < min)
                    {
                        min = width[j];
                    }
                }
                mins.Add(min);
            }
            return mins.ToArray();
        }

        static int workbook(int n, int k, int[] arr)
        {
            int page = 1;
            int counter = 0;
            int initialK = k;
            for (int i = 1; i <= arr.Length; i++)
            {
                for (int j = 1; j <= arr[i - 1]; j++)
                {
                    if (j > k)
                    {
                        page++;
                        k += initialK;
                    }
                    if (page == j)
                        counter++;
                }
                page++;
                k = initialK;
            }
            return counter;
        }

        static int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int maxDistance = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                if (maxDistance < distance) maxDistance = distance;
            }
            int lastGap = (n - 1) - c[c.Length - 1];
            return (lastGap < maxDistance) ? maxDistance : lastGap;
        }

        public static string fairRations(List<int> B)
        {
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < B.Count; i++)
            {
                sum += B[i];
            }

            if (sum % 2 != 0)
                return "NO";
            else
            {
                for (int i = 0; i < B.Count - 1; i++)
                {
                    if (B[i] % 2 != 0)
                    {
                        B[i]++;
                        B[i + 1]++;
                        counter += 2;
                    }
                }
            }
            return counter.ToString();
        }

        public static List<string> cavityMap(List<string> grid)
        {
            char[,] chars = new char[grid.Count, grid[0].Length];
            List<string> result = new List<string>();
            int[,] elements = new int[grid.Count, grid[0].Length];

            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    chars[i, j] = grid[i][j];
                    elements[i, j] = int.Parse(grid[i][j].ToString());
                }
            }

            for (int i = 1; i < elements.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < elements.GetLength(1) - 1; j++)
                {
                    var current = elements[i, j];
                    if (current > elements[i - 1, j] && current > elements[i, j - 1] && current > elements[i, j + 1] && current > elements[i + 1, j])
                        chars[i, j] = 'X';
                }
            }

            for (int i = 0; i < chars.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    row += chars[i, j];
                }
                result.Add(row);
            }
            return result;
        }

        static long strangeCounter(long t)
        {
            long rem = 3;
            while (t > rem)
            {
                t = t - rem;
                rem *= 2;
            }
            return rem - t + 1;
        }

        static string superReducedString(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].Equals(s[i - 1]))
                {
                    s = s.Substring(0, i - 1) + s.Substring(i + 1);
                    i = 0;
                }
            }

            if (s.Length == 0)
                return "Empty String";
            else
                return s;
        }

        static int introTutorial(int V, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == V)
                    return i;
            }
            return 2;
        }

        static int camelcase(string s)
        {
            string lower = s.ToLower();
            int counter = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != lower[i])
                    counter++;
            }
            return counter;
        }

        static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            string numbers = "0123456789";
            bool containsDigit = false;
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            bool containsLower = false;
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool containsUpper = false;
            string special_characters = "!@#$%^&*()-+";
            bool containsSpecial = false;

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (password.Contains(numbers[i]))
                {
                    containsDigit = true;
                    break;
                }
            }

            for (int i = 0; i < lower_case.Length; i++)
            {
                if (password.Contains(lower_case[i]))
                {
                    containsLower = true;
                    break;
                }
            }

            for (int i = 0; i < upper_case.Length; i++)
            {
                if (password.Contains(upper_case[i]))
                {
                    containsUpper = true;
                    break;
                }
            }

            for (int i = 0; i < special_characters.Length; i++)
            {
                if (password.Contains(special_characters[i]))
                {
                    containsSpecial = true;
                    break;
                }
            }

            if (!containsDigit)
                counter++;
            if (!containsLower)
                counter++;
            if (!containsUpper)
                counter++;
            if (!containsSpecial)
                counter++;

            if (password.Length < 6 && 6 - password.Length > counter)
            {
                return 6 - password.Length;
            }
            else
                return counter;
        }

        public static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }

        static string caesarCipher(string s, int k)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string messageToLower = s.ToLower();
            string encrypted = "";

            string[] shifted = new string[alphabet.Length];

            for (int i = 0; i < alphabet.Length; i++)
            {
                shifted[i] = alphabet[(i + k) % alphabet.Length].ToString();
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j].Equals(messageToLower[i]))
                    {
                        if (char.IsUpper(s[i]))
                            encrypted += shifted[j].ToUpper();
                        else
                            encrypted += shifted[j];
                        break;
                    }

                    if (!(alphabet.Contains(messageToLower[i])))
                    {
                        encrypted += s[i];
                        break;
                    }

                }
            }
            return encrypted;
        }

        static int marsExploration(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i += 3)
            {
                string current = s.Substring(i, 3);
                if (current[0] != 'S')
                    counter++;
                if (current[1] != 'O')
                    counter++;
                if (current[2] != 'S')
                    counter++;
            }

            return counter;
        }

        static string hackerrankInString(string s)
        {
            string hackerrank = "hackerrank";
            int j = 0;
            for (int i = 0; i < hackerrank.Length; i++)
            {
                char current = hackerrank[i];
                while (s[j] != current && j < s.Length)
                {
                    j++;
                    if (j == s.Length)
                    {
                        return "NO";
                    }
                }
                j++;
                if (j == s.Length && i == hackerrank.Length - 1)
                {
                    return "YES";
                }
                if (j == s.Length)
                {
                    return "NO";
                }
            }
            return "YES";
        }

        static int[] quickSort(int[] arr)
        {
            int p = arr[0];
            int leftLength = 0;
            int rightLength = 0;
            int equalLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < p)
                    leftLength++;
                else if (arr[i] > p)
                    rightLength++;
                else
                    equalLength++;
            }
            int[] left = new int[leftLength];
            int[] right = new int[rightLength];
            int[] equal = new int[equalLength];

            int iLeft = 0;
            int iRight = 0;
            int iEqual = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < p)
                {
                    left[iLeft] = arr[i];
                    iLeft++;
                }
                else if (arr[i] > p)
                {
                    right[iRight] = arr[i];
                    iRight++;
                }
                else
                {
                    equal[iEqual] = arr[i];
                    iEqual++;
                }
            }

            int[] result = new int[leftLength + rightLength + equalLength];
            int j = 0;
            for (int i = 0; i < left.Length; i++)
            {
                result[j] = left[i];
                j++;
            }

            for (int i = 0; i < equal.Length; i++)
            {
                result[j] = equal[i];
                j++;
            }

            for (int i = 0; i < right.Length; i++)
            {
                result[j] = right[i];
                j++;
            }

            return result;
        }

        static string pangrams(string s)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            bool isPangram = true;
            string sToLower = s.ToLower();

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (!(sToLower.Contains(alphabet[i])))
                    isPangram = false;
            }

            if (isPangram)
                return "pangram";
            else
                return "not pangram";
        }

        public static void separateNumbers(string s)
        {
            string subString = "";
            bool isValid = false;
            for (int i = 1; i <= s.Length / 2; i++)
            {
                subString = s.Substring(0, i);
                long num = long.Parse(subString);
                string validString = subString;
                while (validString.Length < s.Length)
                {
                    validString += ++num;
                }
                if (s.Equals(validString))
                {
                    isValid = true;
                    break;
                }

            }
            Console.WriteLine((isValid ? "YES " + subString : "NO"));
        }

        static string funnyString(string s)
        {
            string reversed = "";
            bool isFunny = true;
            List<int> sDifference = new List<int>();
            List<int> reverseDifference = new List<int>();
            for (int i = s.Length - 1; i >= 0; i--)
                reversed += s[i];

            for (int i = 0; i < s.Length - 1; i++)
            {
                sDifference.Add(Math.Abs((int)s[i] - (int)s[i + 1]));
            }

            for (int i = 0; i < reversed.Length - 1; i++)
            {
                reverseDifference.Add(Math.Abs((int)reversed[i] - (int)reversed[i + 1]));
            }

            for (int i = 0; i < sDifference.Count; i++)
            {
                if (sDifference[i] != reverseDifference[i])
                    isFunny = false;
            }

            if (isFunny)
                return "Funny";
            else
                return "Not Funny";
        }

        static int[] countingSort(int[] arr)
        {
            int[] zeros = new int[100];
            for (int i = 0; i < arr.Length; i++)
                zeros[arr[i]]++;
            return zeros;
        }

        public static List<int> countingSort2(List<int> arr)
        {
            List<int> values = new List<int>();
            int max = arr.Max();

            int[] frequency = new int[max + 1];

            for (int i = 0; i < frequency.Length; i++)
            {
                frequency[i] = 0;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                frequency[arr[i]]++;
            }

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] == 0)
                    continue;
                else
                {
                    for (int j = 0; j < frequency[i]; j++)
                    {
                        values.Add(i);
                    }
                }
            }

            return values;
        }

        static int gemstones(string[] arr)
        {
            int counter = 1;
            int globalCounter = 0;
            string first = arr[0];
            var firstDistinct = first.Distinct();
            int j = 1;
            for (int i = 0; i < firstDistinct.Count(); i++)
            {
                while (j < arr.Length)
                {
                    if (arr[j].Contains(firstDistinct.ElementAt(i)))
                        counter++;
                    j++;
                }
                if (counter == arr.Length)
                    globalCounter++;
                j = 1;
                counter = 1;
            }

            return globalCounter;
        }

        static int alternatingCharacters(string s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(s[i + 1]))
                    counter++;
            }
            return counter;
        }

        static int beautifulBinaryString(string b)
        {
            int counter = 0;
            for (int i = 2; i < b.Length;)
            {
                if (b[i] == '0' && b[i - 2] == '0' && b[i - 1] == '1')
                {
                    counter++;
                    i += 3;
                }
                else
                    i++;
            }
            return counter;
        }

        static int[] closestNumbers(int[] arr)
        {
            Array.Sort(arr);
            int min = int.MaxValue;
            List<int> mins = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) <= min)
                {
                    min = Math.Abs(arr[i] - arr[i + 1]);
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == min)
                {
                    mins.Add(arr[i]);
                    mins.Add(arr[i + 1]);
                }
            }
            return mins.ToArray();
        }

        public static int theLoveLetterMystery(string s)
        {
            int counter = 0;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                counter += Math.Abs(s[j] - s[i]);
            }
            return counter;
        }

        public static int findMedian(List<int> arr)
        {
            var array = arr.ToArray();
            Array.Sort(array);
            return array[array.Length / 2];
        }

        public static int anagram(string s)
        {
            if (s.Length % 2 != 0)
                return -1;
            else
            {
                int n = s.Length / 2;
                string s1;
                string s2;
                s1 = s.Substring(0, n);
                s2 = s.Substring(n, s.Length - n);

                foreach (char c in s2)
                {
                    if (s1.IndexOf(c) > -1)
                    {
                        s1 = s1.Remove(s1.IndexOf(c), 1);
                    }
                }
                return s1.Length;
            }
        }

        public static int makingAnagrams(string s1, string s2)
        {
            int[] frequencys1 = new int[26];
            int[] frequencys2 = new int[26];
            int counter = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                frequencys1[s1[i] - 97]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                frequencys2[s2[i] - 97]++;
            }

            for (int i = 0; i < 26; i++)
            {
                counter += Math.Abs(frequencys1[i] - frequencys2[i]);
            }

            return counter;
        }
    }
}
