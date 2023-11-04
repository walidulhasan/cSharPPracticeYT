namespace cSharPPracticeYT.BasicToIntermediate.Arrays;

public class IntroductionToArrays
{
    public static void Main()
    {
        //Array Declaration

        int[] ints;

        //Array Allocation

        ints = new int[5];//0,1,2,3,4

        //Array Assignmetn

        ints[0] = 1;
        ints[1] = 2;
        ints[2] = 3;
        ints[3] = 4;
        ints[4] = 5;

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }


    }
}
