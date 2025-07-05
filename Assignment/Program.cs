using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        #region 4-calculate the sum of the individual digits of a given number
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10; // Add the last digit to sum
        //        number /= 10; // Remove the last digit
        //    }
        //    return sum;
        //}

        #endregion
        #region 5- isPrime
        //static bool IsPrime(int number)
        //{
        //  if(number <= 0)
        //        return false;
        //    for (int i = 2; i < Math.Sqrt(number); i++){
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        #endregion
        #region 6-MinMax Array
        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    if (arr is not null | arr.Length > 0)
        //    {
        //        foreach(int number in arr)
        //        {
        //            if (number < min)
        //                min = number;
        //            if (number > max)
        //                max = number;
        //        }

        //    }

        //}
        #endregion
        #region 7-iterative function
        static int Factorial(int num)
        {
            int result = 1;
            if (num > 0)
                for(int i = 2; i < num; i++)
                    result *= i;
            return result;
        }
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
            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.WriteLine("Sum Of digite for given number "+SumOfDigits(25));

            #endregion
            #region - Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not: 
            //int number = 29;
            //Console.WriteLine($"{number} is prime ? "+IsPrime(number)); 

            #endregion
            #region  Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Min Number = {min}");
            //Console.WriteLine($"Max Number {max}");
            #endregion
            #region iterative function
            //int number = 5;
            //int result = Factorial(number);
            //Console.WriteLine(result);
            #endregion
        }
    }
}
