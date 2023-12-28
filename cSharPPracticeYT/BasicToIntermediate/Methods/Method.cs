namespace cSharPPracticeYT.BasicToIntermediate.Methods;

public class Method
{
    #region Defining and Calling Parameters
    //string GetUserInput(string prompt)
    //{
    //    Console.Write(prompt);
    //    string? input = Console.ReadLine();

    //    while (string.IsNullOrEmpty(input))
    //    {
    //        Console.WriteLine("Invalid input. Please try again.");
    //        Console.Write(prompt);
    //        input = Console.ReadLine();
    //    }

    //    return input;
    //}

    //public void User()
    //{
    //    string name = GetUserInput("Enter your name: ");
    //    string age = GetUserInput("Enter your age: ");
    //    string gender = GetUserInput("Enter your gender: ");

    //    Console.WriteLine("\n");

    //    Console.WriteLine($"Name: {name}");
    //    Console.WriteLine($"Age: {age}");
    //    Console.WriteLine($"Gender: {gender}");
    //}
    #endregion

    #region Method Overloading Optional Parameters Params Keyword
    //public void Calculator(int numOne,int numTwo)
    //{
    //    Console.WriteLine($"Sum: {numOne + numTwo}");
    //}
    //public void Calculator(decimal numOne, decimal numTwo)
    //{
    //    Console.WriteLine(numOne * numTwo);
    //}


    //public void Sum(int i,int k, int l = 0)
    //{
    //    Console.WriteLine(i+k+l);
    //}

    //public void ParamasFun(params dynamic[] param)
    //{
    //    foreach(var v in param)
    //    {
    //        if(v is string)
    //        {
    //            Console.WriteLine(v);
    //        }
    //        else if(v is int)
    //        {
    //            Console.WriteLine(v);
    //        }
    //    }
    //}
    #endregion

    #region Named Arguments pass by Value pass by reference

    //public void User(int age,string name, bool gender)
    //{
    //    Console.Write($"{name}-{age}-{gender}");
    //}

    //public int Test(int i)
    //{
    //    i = 10;
    //    return i;
    //}

    //public int[] Test(int[] ints)
    //{
    //    ints = new int[] { 10 };

    //    return ints;
    //}
    #endregion

    #region Ref and Out Keyword

    //public int Sum(ref int a , out int b, int m)
    //{
    //    a = 10;
    //    b = 20;
    //    m = 30;
    //    return a + b + m;
    //}







    #endregion

    public void CountDown()
    {
        int x = 10;
        Recursion(x);
        Console.WriteLine("Done");

        static void Recursion(int i)
        {
            if (i <= 0) return;
            Console.WriteLine(i);
            Thread.Sleep(1000); // wait 1 second
            Recursion(i - 1);
        }
    }
}
