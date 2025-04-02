namespace GMI24H_Labb_1;

public class ArrayGen
{
    public int[] GenerateArray(int size, bool seed)
    {
        int[] arr = new int[size];
        if (seed)
        {
            Random randSeed = new Random(42);
            for (int i = 0; i < size; i++)
            {
                arr[i] = randSeed.Next(1, 100);
            }

            return arr;
        }
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100);
        }

        return arr;
    }
}