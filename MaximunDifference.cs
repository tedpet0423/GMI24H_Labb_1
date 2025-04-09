namespace GMI24H_Labb_1;

public class MaximunDifference
{
    
    // Metod för att räkna ut maxDiff, använder brute-force algoritm som loopar igenom arrayen och kollar skillnaden mellan alla siffror i arrayen.
    public int MaxDiffSlow(int[] arr)
    {
        int diff = 0;
        int arrLength = 0;
        int valueA = 0;
        int valueB = 0;
        // kontrollerar arrayens längd
        foreach (int i in arr)
        {
           arrLength++;
        }
        // nästlad loop för att testa alla kobinationer av värden, O(N^2)
        for (int i = 0; i < arrLength; i++)
        {
            for (int j = 0; j < arrLength; j++)
            {
                if (arr[i] > arr[j])
                {
                    valueA = arr[i];
                    valueB = arr[j];
                }
                else
                {
                    valueA = arr[j];
                    valueB = arr[i];
                }
                // sparar största differansen
                if ((valueA - valueB) > diff)
                {
                    diff = valueA - valueB;
                }
                
            }
            
        }
        // returnerar differensen
        return diff;
    }

    // Metod för att räkna ut maxDiff, använder en snabbare algoritm som först letar på största och minsta värde i arrayen, O(N)
    public int MaxDiffFast(int[] arr)
    {
        // initierar variabler
        int arrLength = 0;
        int valueA = 0;  
        int valueB = 100;
        // Kontrollerar arrayens längd
        foreach (int i in arr)   
        {                        
            arrLength++;          
        }
        // loop som kollar största och minsta värde i arrayen
        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] > valueA)
            {
                valueA = arr[i];
            }
            if (arr[i] < valueB)           
            {                              
                valueB = arr[i];           
            }  
            
        }
        // beräknar differensen mellan största och minsta värde
        int diff = valueA - valueB;
        return diff;
    }              
}