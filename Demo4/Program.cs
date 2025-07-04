using System.Reflection.Metadata.Ecma335;

namespace Demo4
{
    //Class - struct - interface - enum 
    // enum can not contain methods
    internal class Program
    {
        #region Function [Print Shape]

        //static void PrintShape(string Shape = "***/****" , int counter) // InValid -- default must be at the end of the parameter list 
        //{
        //    for(int i = 0; i < counter; i++)
        //        Console.WriteLine(Shape);
        //}

        //    static void PrintShape(  int counter ,string Shape = "***/****") // Valid -- default must be at the end of the parameter list 
        //{
        //    for(int i = 0; i < counter; i++)
        //        Console.WriteLine(Shape);
        //}
        #endregion
        #region Swap
        //static void Swap(int x , int y)//Passing by value
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //}
        //static void Swap(ref int x , ref int y)//Passing by Reference 
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //}


        #endregion
        #region SumOfArray
        //static int SumArray(int[] arr) // Passing by Value
        //{
        //    arr[0] = 100;
        //    int sum = 0;
        //    for(int i = 0; i < arr.Length; i++)
        //        sum += arr[i];
        //    return sum;
        //}
        //static int SumArray(ref int[] arr) //Passing by Reference
        //{
        //    arr[0] = 100;
        //    int sum = 0;
        //    for(int i = 0; i < arr.Length; i++)
        //        sum += arr[i];
        //    return sum;
        //}




        #endregion
        #region SumOf Array Change the Reference
        //static int SumArray(ref int[] arr) // Passing by reference
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {

        //         arr = new int[3] { 100, 200, 300 };//Chage the reference of arr to a new array 

        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];


        //    }
        //    return sum;

        //}
        //static int SumArray(int[] arr) // Passing by Value
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {

        //         arr = new int[3] { 100, 200, 300 };//Chage the reference of arr to a new array 

        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];


        //    }
        //    return sum;

        //}
        #endregion
        #region SumMultiplay
        //static void SumMultiplay(int x , int y , out int Sum , out int Multiplay)
        //{
        //    Sum = x + y;
        //    Multiplay = x * y;

        //}
        #endregion
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
            #region Nullable Type
            //object obj = null; // Null Reference
            //string name = null; // Null Reference
            ////int x = null;//InValid Operation Exception
            ////Reference type can be null but value type cannot be null
            ////Nullable type allow value type to be null\
            //int? x = null; // Nullable type -- Valid
            #region Casting between Nullable Type and Value Type
            //int x = 10;
            //int? y = 20;
            ////x = y;//InValid 
            /*******************/
            ////x = (int)y; //Casting Valid 
            //if (y != null)
            //    x = (int)y;
            //else
            //    x = default;

            //Console.WriteLine(x); // Output: 20
            /********************/
            //y = null;
            //if (y is not null)
            //    x = (int)y;
            //else
            //    x = default;
            //Console.WriteLine(x); // Output: 0 beause y is null and default value of int is 0
            /********************/
            //x = y is not null ? (int)y : default; // Using Ternary Operator
            //Console.WriteLine(x);
            //int num = 10;
            //int? num2 = 20;
            //num = num2  is not null ? (int)num2 : default; // Using Ternary Operator
            //Console.WriteLine(num);
            /**Null-Coalescing Operator**/
            //x = y ?? default; // If y is not null, assign its value to x, otherwise assign default value of int
            //Console.WriteLine(x);
            //***********//
            //if (y.HasValue)
            //    x = (int)y;
            //else 
            //    x = default;
            //Console.WriteLine(x);



            #endregion
            #endregion
            #region Null Propagation operator (?)
            //int[]? numbers = { 10, 21, 19 }; 
            //numbers = null; // Assigning null to the array
            ////Console.WriteLine(numbers.Length); NullReferenceException
            ////Console.WriteLine(numbers?.Length); //Handel null reference exception 
            //Console.WriteLine(numbers?.Length?? 0); //Return 0 if numbers is null --Coalesce Operator
            //Console.WriteLine(numbers?.Length?? default); //Return default value if numbers is null --Coalesce Operator
            #endregion
            #region Null Forgeviness operators
            //Skip warning
            string  name = null!;
            #endregion
            #region Function 1 (Print Shape)
            //PrintShape("\\*\\");// \*\
            //PrintShape();//print default shape = ***/****
            //PrintShape(9, "-_-");
            //PrintShape("-_-", 9);//InValid Arguments -- The first argument should be an integer and the second argument should be a string
            //PrintShape(Shape: "-_-_", counter: 10);//Valid Arguments -- passing by name
            //PrintShape(6 , " \/*"); //InValid 
            //PrintShape(6, "\\/*");//Valid
            //PrintShape(6, @"\/*"); //Valid

            #region \ @
            //Console.Write("Abdallah \n Sayed");
            //Console.Write("Abdallah \t Sayed");
            //Console.Write("Abdallah \\ Sayed");
            //Console.Write(@"Abdallah \ Sayed");
            #endregion

            #endregion
            #region Print Swap
            //Passing by value --Send copy of the value
            //int a = 10, b = 20;
            //Console.WriteLine($"a before Swap {a}");
            //Console.WriteLine($"b before Swap {b}");
            //Swap(a, b);
            //Console.WriteLine($"a after Swap {a}");
            //Console.WriteLine($"b after Swap {b}");
            //Passing by ref -- send variable itself
            //int a = 10, b = 20;
            //Console.WriteLine($"a before Swap {a}");
            //Console.WriteLine($"b before Swap {b}");
            //Swap(ref a,ref b);
            //Console.WriteLine($"a after Swap {a}");
            //Console.WriteLine($"b after Swap {b}");

            #endregion
            #region Print SumArray
            //Passing By Value
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers);
            //Console.WriteLine(result); // 105
            //Passing By ref
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine(result);
            #endregion
            #region Print Change SumArray
            //Passing By Value
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers);
            //Console.WriteLine(result); // 600
            //Console.WriteLine(numbers[0]); // 1
            //Passing By ref
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine(result);// 600
            //Console.WriteLine(numbers[0]);//100
            #endregion
            #region Print SumMultiplay
            //int a = 10, b = 20;
            //int sum, multiplay;
            //SumMultiplay(a, b, out sum, out multiplay);
            //Console.WriteLine(sum);
            //Console.WriteLine(multiplay);

            #endregion
        }
    }
}
