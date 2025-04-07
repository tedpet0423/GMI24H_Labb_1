namespace GMI24H_Labb_1;

// Klass för att räkna vår siffra att räkna. 
public class CountNumber
{
    // Metod för räkningen
    public  int CountNum(int[] arr, int num)
    {
        // Loopar igenom arrayen och om siffran stämmer räknar vi upp den och returnerar sedan antalet räknande siffror
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                count++;
            }
        }

        return count;
    }
    
    
}