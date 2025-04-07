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
            int[] testSizes = {10, 10000, 1000000, 1000000000};
            
            ArrayGen arrayGen = new ArrayGen();
            CountNumber countNumber = new CountNumber();
            Utility utility = new Utility();
            
            utility.CreateFileCsv();
            
            // Loop för att testa de olika testarrayerna med tillhörande tidtagning, tidskomplexitet: 0(N)
            for(int i = 0; i < testSizes.Length; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] arr = arrayGen.GenerateArray(testSizes[i], true);
                
                stopwatch.Reset();
                stopwatch.Start();
                int numCount = countNumber.CountNum(arr, findNum);
                stopwatch.Stop();
                
                TimeSpan timeSpan = stopwatch.Elapsed;
                
                utility.WriteToCsv(timeSpan, testSizes[i], numCount);
                
                // Skriver ut output OBS ska ändras till csv-fil
                Console.WriteLine("Number of " + findNum + "s : " + numCount + " \nSize of array: " + testSizes[i] + " \nTime taken: " + timeSpan.TotalNanoseconds + "ms\n");
            }
            
            

        }
    }
