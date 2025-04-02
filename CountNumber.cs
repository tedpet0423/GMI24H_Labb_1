namespace GMI24H_Labb_1;

public class CountNumber
{
    public  int CountNum(int[] arr, int num)
    {
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