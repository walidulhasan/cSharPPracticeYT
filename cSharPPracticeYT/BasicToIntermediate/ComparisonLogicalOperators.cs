using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharPPracticeYT.BasicToIntermediate;

public class ComparisonLogicalOperators
{
    public static void Main()
    {
        //Comparison Operators

        //==
        Console.WriteLine($"== {2 == 3}");//False
        //!=
        Console.WriteLine($"!= {2 != 3}");//True
        //>
        Console.WriteLine($"> {2 > 3}"); //False
        //<
        Console.WriteLine($"< {3 < 3}");//False
        //<=
        Console.WriteLine($"<= {3 <= 3}");//True
        //>=
        Console.WriteLine($">= {3 >= 3}");//Ture

        //Logical Operators
        //&&
        Console.WriteLine($"&& {2 == 3 && 2 > 3}");//False
        //||
        Console.WriteLine($"|| {3 == 3 || 2 > 3}");//Ture
        //!
        Console.WriteLine($"! {!true}");//False
    }
}
