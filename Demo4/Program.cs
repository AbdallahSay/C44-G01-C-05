namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region jugged Array

            //int[][] marks = new int[3][];
            //marks[0] = new int[] { 10, 20, 30 };
            //marks[1] = new int[] { 40, 50 };
            //marks[2] = new int[] { 60 };
            //for(int i =0; i < marks.Length; i++)
            //{

            //    for (int j = 0; j < marks[i].Length; j++)
            //        Console.Write(marks[i][j] + "  ");
            //            Console.WriteLine();
            //}


            #endregion
            #region Array Method
            #region Static Method -- Array Class Members Methods 
            //int[] number = [9, 13, 19, 3, 4, 5, 6, 7 , 9];
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //    Console.Write(+number[i] + " ");




            //Array.Reverse(number);
            //    for (int j = 0; j < number.Length; j++)
            //    Console.Write( number[j] +" ");



            //int[] copy = new int[5];
            //Array.Copy(number, copy, 5);
            //foreach (int copys in copy)
            //    Console.Write(copys + " ");
            //int[] constrinedCopy = new int[5];
            //Array.ConstrainedCopy(number, 2, constrinedCopy, 2, 3);
            //foreach(int copy in constrinedCopy)
            //    Console.Write(copy + " ");
            //Console.WriteLine(Array.IndexOf(number ,9)); //Return the index of the first occurrence of the value 9 in the array
            //Console.WriteLine(Array.IndexOf(number , 20));//Return -1 because 20 is not in the array
            //Console.WriteLine(Array.LastIndexOf(number , 9));//Return the index of the last occurrence of the value 9 in the array
            //int[] arr = (int[])Array.CreateInstance(typeof(int), 4);
            //Console.WriteLine(arr.Length); //1D Array with 4 elements
            //int[ , ] arrTwo = (int[ , ])Array.CreateInstance(typeof(int), 5 , 6);
            //Console.WriteLine(arrTwo.Length); //2D Array with 30 elements (5 rows and 6 columns)
            //int[][] judgged = (int[][])Array.CreateInstance(typeof(int[]), 4 );
            // judgged[0] = new int[] { 1, 2, 3 };
            // judgged[1] = new int[] { 4, 5, 6, 7 };
            // judgged[2] = new int[] { 8, 9 };
            // judgged[3] = new int[] { 10, 11, 12, 13, 14 };
            // for(int i = 0; i < judgged.Length; i++)
            // {
            //     for(int j = 0; j < judgged[i].Length; j++)
            //         Console.Write(judgged[i][j] + " ");
            //     Console.WriteLine();
            // }





            #endregion
            #region Non-Static Method -- Object Members Methods
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //int[] copyNumbers = new int[5];
            //numbers.CopyTo(copyNumbers, 0);
            //foreach(int num in copyNumbers)
            //    Console.Write(num + " "); // must be copy all elements of numbers to copyNumbers starting at index 4
            //Array.Copy(numbers, copyNumbers, 3);
            //foreach (int num in copyNumbers)
            //    Console.Write(num + " "); //Copy Range of elements from numbers to copyNumbers 
            //Console.WriteLine(numbers[0]);// 1
            //Console.WriteLine(numbers.GetValue(0));
            ////numbers.SetValue(20, 0);
            ////Console.WriteLine(numbers[0]);//20
            //Console.WriteLine(numbers.GetValue(0));

            #endregion




            #endregion
            #region Boxing - UnBoxing
            //Boxing : Casting a value type to Reference type (Implicit Casting -- Safe)
            //UnBoxing : Casing Reference to Value Type (Explicit Casing -- Unsafe)
            //object obj = 10; // Boxing from int to object 
            //obj = 20; // Boxing 
            //int num = 10;
            //object obj2 = 20;
            //num = (int)obj2; // UnBoxing from object to int --Expicit Casting
            #endregion

        }
    }
}
