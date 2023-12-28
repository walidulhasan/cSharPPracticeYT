using cSharPPracticeYT;
using cSharPPracticeYT.BasicToIntermediate;
using cSharPPracticeYT.BasicToIntermediate.Arrays;
using cSharPPracticeYT.BasicToIntermediate.Conditional;
using cSharPPracticeYT.BasicToIntermediate.Loops;
using cSharPPracticeYT.BasicToIntermediate.Methods;

#region
//ArithmeticOperators.Main();
//ComparisonLogicalOperators.Main();
//BitwiseOperators.Main();
//StringLearning.Main();
//IntroductionToArrays.Main();
//TwoDimensionalArray.Main();
//MultiDimensionalArray.Main();
//JaggedArrays.Main();
//IfEalsCondition.Main();
//AllLoops.Main();
#endregion

var Methods = new Method();

#region Named Arguments pass by Value pass by reference

//Methods.User(name:"Kamal",gender:true,age:12);

//int val = 100;
//int returnVal=Methods.Test(val);

//Console.WriteLine(val);
//Console.WriteLine(returnVal);

//int[] ints = { 0 };

//var values = Methods.Test(ints);

//foreach (var item in values)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Ref and Out keyword
//int c = 9;
//int d;
//int k = 10;

//int result = Methods.Sum(ref c,out d,k);
#endregion

Methods.CountDown();
Console.ReadLine();

