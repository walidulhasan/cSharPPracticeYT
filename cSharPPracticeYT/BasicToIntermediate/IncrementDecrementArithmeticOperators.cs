namespace cSharPPracticeYT.BasicToIntermediate;

public class IncrementDecrementArithmeticOperators
{
    public static void Main()
    {
        //(+)
        Console.WriteLine($"+ {3 + 2}");
        //(-)
        Console.WriteLine($"- {3 - 2}");
        //(*)
        Console.WriteLine($"* {3 * 2}");
        //(/)
        Console.WriteLine($"/ {3 / 2}");
        //(%)
        Console.WriteLine($"% {3 % 2}");


        int number = 10;
        int numbers = 10;

        //++n Pre.
        Console.WriteLine($"++ {++number}");//11 // 1+10;
        //--n Pre.
        Console.WriteLine($"-- {--number}");//10 // 1-11;

        //n++ Post..
        Console.WriteLine($"n++ {numbers++}");//10 //11 //10+1;
        Console.WriteLine(numbers);//11
        //n-- Post..
        Console.WriteLine($"n-- {numbers--}");//11 //10 //10-1;
        Console.WriteLine(numbers);



        Console.ReadLine();

    }
}
