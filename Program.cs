// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace GMI24H_Labb_1;

internal class Program
{
    public static void Main(string[] args)
    {
        // hårdkodat nummer att matcha, storleken på arrayen samt antalet iterationer för teststorlekarna.
        int findNum = 42;
        int arrSize = 100000;
        int[] testSizes = { 0, 10, 10000, 1000000, 100000000 };
        int[] testSizes2 = { 1, 10, 100, 1000};

        ArrayGen arrayGen = new ArrayGen();
        CountNumber countNumber = new CountNumber();
        Utility utility = new Utility();
        MaximunDifference maxDiff = new MaximunDifference();
        string numCountAlgorithm = "NumberCounter";
        string diffAlgorithmS = "maxDiffSlow";
        string diffAlgorithmF = "maxDiffFast";



        utility.CreateFileCsv(numCountAlgorithm);
        utility.CreateFileCsv(diffAlgorithmS);
        utility.CreateFileCsv(diffAlgorithmF);

        // Loop för att testa de olika testarrayerna med tillhörande tidtagning, tidskomplexitet: 0(N)
        for (int i = 0; i < testSizes.Length; i++)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] arr = arrayGen.GenerateArray(testSizes[i], true);

            stopwatch.Reset();
            stopwatch.Start();
            int numCount = countNumber.CountNum(arr, findNum);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;

            string strTime = timeSpan.TotalNanoseconds.ToString("F0");
            string strTestSize = testSizes[i].ToString();
            string strNumCount = numCount.ToString();
            string dataToWrite = ($"{strTime},{strTestSize},{strNumCount}\n");

            utility.WriteToCsv(dataToWrite, numCountAlgorithm);

            // Skriver ut output OBS ska ändras till csv-fil
            Console.WriteLine("Number of " + findNum + "s : " + numCount + " \nSize of array: " + testSizes[i] +
                              " \nTime taken: " + timeSpan.TotalNanoseconds + "ms\n");
        }

        for (int i = 0; i < testSizes2.Length; i++)
        {


            Stopwatch stopwatch = new Stopwatch();
            int[] arr = arrayGen.GenerateArray(testSizes2[i], true);

            stopwatch.Reset();
            stopwatch.Start();
            int diff = maxDiff.MaxDiffSlow(arr);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;
            string strTime = timeSpan.TotalNanoseconds.ToString("F0");
            string strTestSize = testSizes2[i].ToString();
            string strdiff = diff.ToString();
            string dataToWrite = ($"{strTime},{strTestSize},{strdiff}\n");
            utility.WriteToCsv(dataToWrite, diffAlgorithmS);
        }

        for (int i = 0; i < testSizes2.Length; i++)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] arr = arrayGen.GenerateArray(testSizes2[i], true);

            stopwatch.Reset();
            stopwatch.Start();
            int diff = maxDiff.MaxDiffFast(arr);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;
            string strTime = timeSpan.TotalNanoseconds.ToString("F0");
            string strTestSize = testSizes2[i].ToString();
            string strdiff = diff.ToString();
            string dataToWrite = ($"{strTime},{strTestSize},{strdiff}\n");
            utility.WriteToCsv(dataToWrite, diffAlgorithmF);

        }
    }
}
        
