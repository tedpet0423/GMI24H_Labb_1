namespace GMI24H_Labb_1;

public class MaximunDifference
{
    public int MaxDiffSlow(int[] arr)
    {
        int diff = 0;
        int arrLength = 0;
        int valueA = 0;
        int valueB = 0;
        
        foreach (int i in arr)
        {
           arrLength++;
        }

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
                diff = valueA - valueB;
            }
            
        }
        return diff;
    }


    public int MaxDiffFast(int[] arr)
    {
        int diff = 0;
        int arrLength = 0;
        int valueA = 0;  
        int valueB = 0;
        
        foreach (int i in arr)   
        {                        
            arrLength++;          
        }

        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] > valueA)
            {
                valueA = arr[i];
            }
        }
        
        for (int i = 0; i < arrLength; i++)
        {                                  
            if (arr[i] < valueB)           
            {                              
                valueB = arr[i];           
            }                              
        }
        diff = valueA - valueB;
        return diff;
    }              
}