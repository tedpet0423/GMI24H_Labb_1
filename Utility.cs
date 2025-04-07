namespace GMI24H_Labb_1;

public class Utility
{
    public void WriteToCsv(TimeSpan time, int arraySize, int numCount)
    {
        
        string dataToWrite = ($"{time},{arraySize},{numCount}\n");
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_timelog.csv";
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(dataToWrite);
        writer.Close();    
       
    }

    public void CreateFileCsv()
    {
        string headers = "Time,ArraySize,NumCount";
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_timelog.csv";
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(headers); 
        writer.Close();            
        
    }
      
}

