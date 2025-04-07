namespace GMI24H_Labb_1;

// Klass för att skapa upp array
public class ArrayGen
{
    // Metod för att skapa array
    public int[] GenerateArray(int size, bool seed)
    {
        // initierar en int array
        int[] arr = new int[size];
        if (seed)
        {
            // Intierar en slumpmässigt frö som är satt till seed 42. Sedan loopar igenom array och fyller index och returnerar sedan arrayen. 
            Random randSeed = new Random(42);
            for (int i = 0; i < size; i++)
            {
                arr[i] = randSeed.Next(1, 100);
            }

            return arr;
        }
        
        // Samma process fast utan seed. 
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100);
        }

        return arr;
    }
}