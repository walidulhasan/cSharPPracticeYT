namespace cSharPPracticeYT.BasicToIntermediate.Arrays;

internal static class JaggedArrays
{
    public static void Main()
    {
        int[][] jaggedArray = new int[][]
        {
            new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5},
        };

        int[][] jaggedArray1 = new int[3][];

        for (int i = 0; i < jaggedArray1.Length; i++)
        {
            int innerArraySize = i + 2;
            jaggedArray1[i] = new int[innerArraySize];

            for (int j = 0; j < innerArraySize; j++)
            {
                jaggedArray1[i][j] = i * innerArraySize + j + 1;
            }
        }
        
    }
}

