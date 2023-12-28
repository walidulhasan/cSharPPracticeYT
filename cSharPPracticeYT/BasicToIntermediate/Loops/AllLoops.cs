namespace cSharPPracticeYT.BasicToIntermediate.Loops;

public class AllLoops
{
    public static void Main()
    {
        int i = 0;
        //while (i<=10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //do
        //{
        //    Console.WriteLine(i);
        //    i++;
        //} while (i<=10);


        for (int k = 0; k <= 10; k++)
        {
            if (k == 3)
                continue;
            if (k == 8)
                break;
            Console.WriteLine(k);
        }

        //int[] ints = { 1, 2, 3, 4, 5 };

        //foreach (var k in ints)
        //{
        //    Console.WriteLine(k);
        //}


    }
}
