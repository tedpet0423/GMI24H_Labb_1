namespace GMI24H_Labb_1;

public class Utility
{   
    
    //Metod för att skriva data till CSV-fil
    public void WriteToCsv(string dataToWrite, string algorithmName)
    {
        
    
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_" + algorithmName + "_timelog.csv";
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(dataToWrite);
        writer.Close();    
       
    }
    
    // Metod för att skapa csv-fil
    public void CreateFileCsv(string algorithmName)
    {   
        
        // Headers, med tid, storlek och värde, värde för CountNum är antalet räknade siffror och för MaxDiff är det deferansen
        string headers = "Time,ArraySize,Value";
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_" + algorithmName + "_timelog.csv";   
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(headers); 
        writer.Close();            
        
    }
      
    
    
    
}

