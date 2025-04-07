namespace GMI24H_Labb_1;

public class Utility
{
    public void WriteToCsv(string dataToWrite, string algorithmName)
    {
        
    
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_" + algorithmName + "_timelog.csv";
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(dataToWrite);
        writer.Close();    
       
    }

    public void CreateFileCsv(string algorithmName)
    {
        string headers = "Time,ArraySize,NumCount";
        string fileName = DateTime.Now.ToString("yyyyMMdd") + "_" + algorithmName + "_timelog.csv";   
        var writer = new StreamWriter(fileName, true);
        writer.WriteLine(headers); 
        writer.Close();            
        
    }
      
    
    
    // två metoder FindMax och FindMin
}

