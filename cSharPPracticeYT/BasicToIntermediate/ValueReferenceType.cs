namespace cSharPPracticeYT.BasicToIntermediate;

public class ValueReferenceType
{
    public void Main()
    {
        //Value Type
        int a = 10;
        int b = a;

        Console.WriteLine("Value Type Example:");
        Console.WriteLine($"Original Value of a {a} and b {b}");

        a = 20;
        Console.WriteLine($"Modified value of a {a} b {b}");


        //Reference Type
        int[] ints = { 1, 2, 3 };
        int[] ints1 = ints;

        Console.WriteLine("Reference Type Example: ");
        Console.WriteLine($"Orginal Value of ints: {string.Join(", ",ints)}");
        Console.WriteLine($"Orginal Value of ints1: {string.Join(", ", ints1)}");
        ints[0] = 10;
        Console.WriteLine($"Modified Value of ints: {string.Join(", ", ints)}");
        Console.WriteLine($"Modified Value of ints1: {string.Join(", ", ints1)}");

    }
   
}
