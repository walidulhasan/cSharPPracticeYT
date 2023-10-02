namespace cSharPPracticeYT;

public class BitwiseOperators
{
    public static void Main()
    {
        // & | ^ ~ >>  <<

        int a = 5;  //binary:0101
        int b = 3;  //binary : 0011

        int resultAnd = a & b;  // binary And ->  1
        //int resultAndDemo= 0101 & 0011 => 0001
        Console.WriteLine($"And {resultAnd}");

        int resultOr = a | b; //binary Or -> 7
        //int resultRodemo = 0101 | 0011=> 0111
        Console.WriteLine($"Or {resultOr}");

        int resultXor = a ^ b; //binary Xor -> 6
        //int resultXor = 0101 | 0011=> 0110
        Console.WriteLine($"Xor {resultXor}");

        int resultNot = ~a; //binary Not -> -6
        //int resultNot = ~1110101 => 11111010  10001010
        Console.WriteLine($"Not {resultNot}");

        int resultRightShift = a >> 1; //binary RightShift -> 2
        //int resultRightShift = 0101 => 0010
        Console.WriteLine($"Right Shift {resultRightShift}");

        int resultLeftShift = a << 2; //binary Left Shift ->20
        //int resultLeftShift = 0101 => 010100
        Console.WriteLine($"Left Shift {resultLeftShift}");
    }
}
