namespace cSharPPracticeYT.BasicToIntermediate.Arrays;

internal static class MultiDimensionalArray
{
    public static void Main()
    {
        //000
        //int[,,] ints =
        //{
        //    {
        //        {1,2 },{1,2 },{1,2 }
        //    },
        //    {
        //        {1,2 },{1,2 },{1,2 }
        //    },
        //    {
        //        {1,2 },{1,2 },{1,2 }
        //    },
        //    {
        //        {1,2 },{1,2 },{1,2 }
        //    },
        //};


        int[,,] intss = new int[10, 10, 50];

        int count = 1;
        for (int i = 0; i < intss.GetLength(0); i++)
        {
            for (int j = 0; j < intss.GetLength(1); j++)
            {
                for(int k = 0; k < intss.GetLength(2); k++)
                {
                    intss[i, j, k] = count++;
                    Console.Write($"{intss[i, j, k]}" + " ");
                }
                Console.WriteLine();
            }
        }
       
    } 
}



