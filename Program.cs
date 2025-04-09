using System.Diagnostics;

namespace GMI24H_Labb_1;

internal class Program
{
    public static void Main(string[] args)
    {
        // hårdkodat nummer att matcha, storleken på arrayen samt antalet iterationer för teststorlekarna.
        int findNum = 42;
        int[] testSizes = { 0, 0, 0, 0, 0, 100, 100, 100, 100, 100, 10000, 10000, 10000, 10000, 10000,  1000000, 1000000, 1000000, 1000000, 1000000, 100000000, 100000000, 100000000, 100000000, 100000000};
        int testSizes2 = 1000;

        // Algoritmerna som ska testas, används i filnamn
        string numCountAlgorithm = "CountNum";
        string diffAlgorithmS = "MaxDiffSlow";
        string diffAlgorithmF = "MaxDiffFast";

        // initierar klasserna som används i programmet
        ArrayGen arrayGen = new ArrayGen();
        CountNumber countNumber = new CountNumber();
        Utility utility = new Utility();
        MaximunDifference maxDiff = new MaximunDifference();



        // Skapar csv-filer för att lagra data om tidtagningarna
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
            string dataToWrite = ($"{strTime},{strTestSize},{strNumCount}");

            Console.WriteLine("Skriver ut data till csv-fil, Algoritm: " + numCountAlgorithm);
            utility.WriteToCsv(dataToWrite, numCountAlgorithm);
            Console.WriteLine("beep");
            Console.WriteLine("boop");
            Console.WriteLine("Klar!");

        }

        // Loop för att testa olika storlekar på arrayen och tidtagning för att räkna ut maxDiff, tidskomplexitet: 0(N^2)
        for (int i = 0; i < testSizes2; i++)
        {


            Stopwatch stopwatch = new Stopwatch();
            int[] arr = arrayGen.GenerateArray(i, true);
            //tidtagning av algoritmen
            stopwatch.Reset();
            stopwatch.Start();
            int diff = maxDiff.MaxDiffSlow(arr);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;


            string strTime = timeSpan.TotalNanoseconds.ToString("F0");
            string strTestSize = i.ToString();
            string strdiff = diff.ToString();
            string dataToWrite = ($"{strTime},{strTestSize},{strdiff}");

            // Skriver ut data till csv-fil
            Console.WriteLine("Skriver ut data till csv-fil, Algoritm: " + diffAlgorithmS);
            utility.WriteToCsv(dataToWrite, diffAlgorithmS);
            Console.WriteLine("beep");
            Console.WriteLine("boop");
            Console.WriteLine("Klar!");
        }


        // Loop för att ta tid på den snabbare algoritmen för att räkna ut maxDiff, tidskomplexitet: 0(N)
        for (int i = 0; i < testSizes2; i++)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] arr = arrayGen.GenerateArray(i, true);

            //tidtagning av algoritmen
            stopwatch.Reset();
            stopwatch.Start();
            int diff = maxDiff.MaxDiffFast(arr);
            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;

            string strTime = timeSpan.TotalNanoseconds.ToString("F0");
            string strTestSize = i.ToString();
            string strdiff = diff.ToString();
            string dataToWrite = ($"{strTime},{strTestSize},{strdiff}");


            // Skriver ut data till csv-fil
            Console.WriteLine("Skriver ut data till csv-fil, Algoritm: " + diffAlgorithmF);
            utility.WriteToCsv(dataToWrite, diffAlgorithmF);
            Console.WriteLine("beep");
            Console.WriteLine("boop");
            Console.WriteLine("Klar!");

        }
    }
}

