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
        }
    }
}
