using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        #region 1- passing value type
        //static void passByValue(int x , int y)// passing by value
        //{

        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        //static void passByValue(ref int x , ref int y) // passing by reference
        //{

        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion
        #region 2- passing reference type
        //static double multiplayOfArray(int[] arr)
        //{
        //    double result = 1;
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        result *= arr[i];
        //    }
        //    return result;
        //}
        //static double multiplayOfArray( ref int[] arr)
        //{
        //    double result = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        result *= arr[i];
        //    }
        //    return result;
        //}
        #endregion
        #region 3- Passing by out
        //static void summationAndSubtraction(int x ,int y , out int sum , out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //passing by value means copy value of the variable to the method parameter // don't change the original variable value
            //passing by reference means copy of the reference is passed to the method. // do change the original variable value

            // Example of passing by valueParameter
            //int a = 5 , b = 10;
            //Console.WriteLine($"a befor swap {a}");
            //Console.WriteLine($"b befor swap {b}");
            //passByValue(a, b);
            //Console.WriteLine($"a after swap {a}");
            //Console.WriteLine($"b after swap {b}");
            // Example of passing by referenceParameter
            //int a = 5 , b = 10;
            //Console.WriteLine($"a befor swap {a}");
            //Console.WriteLine($"b befor swap {b}");
            //passByValue(ref a,ref b);
            //Console.WriteLine($"a after swap {a}");
            //Console.WriteLine($"b after swap {b}");


            #endregion
            #region  Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c#  example.
            //passing by value means copy reference of the variable to the method parameter //  change the original variable value
            //passing by reference means actual reference is passed to the method. // do change the original variable value
            // Example of passing by valueParameter
            //int[] numbers = { 1, 2, 3, 4 };
            //double result = multiplayOfArray(numbers);
            //Console.WriteLine(result); //24
            //numbers[0] = 10;
            //Console.WriteLine(result);// 24 This change won't affect the original array

            // Example of passing by referenceParameter\
            //int[] numbers = { 1, 2, 3, 4 };
            //double result = multiplayOfArray(ref numbers);
            //Console.WriteLine(result); //24
            //numbers[0] = 10;
            //Console.WriteLine(result); // 24 This change not will affect the original array

            #endregion
            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x = 10, y = 5;
            //summationAndSubtraction(x, y, out int sum, out int sub);
            //Console.WriteLine("Summation = "+sum);
            //Console.WriteLine("Substraction ="+sub);



            #endregion
        }
    }
}
