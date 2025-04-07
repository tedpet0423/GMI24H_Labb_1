namespace GMI24H_Labb_1;

public class Utility
{
    public void UtilityWriteToCsv(DateTime time, int arraySize, int numCount)
    {
        string dataToWrite = ($"{time},{arraySize},{numCount}\n");
        string fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_timelog.csv";
        
        var writer = new StreamWriter(fileName);
        Console.Write(dataToWrite);
        Console.WriteLine(fileName);
        writer.WriteLine(dataToWrite);
        writer.Close();
        Console.WriteLine("Done");
    }
    
    
    
        
    
}