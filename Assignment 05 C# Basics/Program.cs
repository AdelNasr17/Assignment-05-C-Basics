namespace Assignment_05_C__Basics
{
    internal class Program
    {

        #region example : Q1 ( Function)
        //// Passing By Value
        //static void SWAP(int x , int y)
        //{
        //    int tamp;
        //    tamp = x ;
        //    x = y;
        //    y = tamp; 
        //}

        //// Passing By Ref
        //static void SWAP(ref int x, ref int y)
        //{
        //    int tamp;
        //    tamp = x;
        //    x = y;
        //    y = tamp;
        //}
        #endregion

        #region Q02: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //static int CalculateSumOfDigits(int number)
        //{
        //    string ConvertNumberToString = number.ToString();
        //    int[] ConvertIntArray = new int[ConvertNumberToString.Length];

        //    for (int i = 0; i < ConvertNumberToString.Length; i++)
        //    {
        //        ConvertIntArray[i] = int.Parse(ConvertNumberToString[i].ToString());
        //    }

        //    int Result = 0;
        //    for (int i = 0; i < ConvertIntArray.Length; i++)
        //    {
        //        if (ConvertIntArray[i] % 2 != 0) 
        //        {
        //            Result += ConvertIntArray[i]; 
        //        }
        //    }

        //    return Result; 
        //}

        #endregion

        #region Q03: Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

        //static string Isparsed(int Number)
        //{
        //    if(Number <= 1)
        //    {
        //        return "false";
        //    }

        //    for (int i = 2; i <= Math.Sqrt( Number) ; i++)
        //    {
        //        if( Number % i == 0 )
        //        {

        //            return " False";
        //        }
        //    }

        //    return " true";
        //}

        #endregion

        #region Q04 : Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .

        //static int CalculateTheFactorial(int n)
        //{

        //    int Result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        Result*=i;
        //    }
        //    return Result;
        //}

        #endregion

        #region Q05 : Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter .

        //static string ChangeChar( ref string Text, int Position, char NewChar)
        //{
        //    // Check if the position is valid
        //    if (Position < 0 || Position >= Text.Length)
        //    {

        //        Console.WriteLine ("position", "Position is out of range.");
        //    }

        //    char[] charArray = Text.ToCharArray();

        //    charArray[Position] = NewChar;

        //    return new string(charArray);
        //}
        #endregion

        static void Main(string[] args)
        {
            #region Q19:  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write(" Please Enter the Size  Matrix (n) : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int n);

            //if (flag = true && n > 0)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write("1 ");
            //            }
            //            else
            //            {
            //                Console.Write("0 ");
            //            }

            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter A Valid Positive Integer .");
            //}


            #endregion

            #region Q20:Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int Sum = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Sum += Numbers[i];
            //}

            //Console.WriteLine($" SumTotal = {Sum}");
            #endregion

            #region Q21 :Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Num1 = { 1, 2, 3, 4, 5, 6 };
            //int[] Num2 = { 7, 8, 9, 10, 11,12 };

            //int[] MergeArrays = new int[Num1.Length + Num2.Length];
            //Array.Copy(Num1,MergeArrays, Num1.Length);
            //Array.Copy(Num2,0,MergeArrays, Num1.Length, Num2.Length);

            //Array.Sort(MergeArrays);
            //foreach (int i in MergeArrays)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Q22 : Write a program in C# Sharp to count the frequency of each element of an array
            //int[] Num = { 1,1,1,2,2,2,3,3,3,2, 3 };    

            //bool[] ProceItem = new bool[Num.Length];
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    if (ProceItem[i])
            //        continue;
            //    int Count = 1;
            //    for (int j = i + 1; j < Num.Length; j++)
            //    {
            //        if (Num[i] == Num[j])
            //        {
            //        Count++;
            //            ProceItem[j] = true;
            //        }

            //    }
            //    Console.WriteLine($"element {Num[i]} = {Count}");
            //}


            #endregion

            #region Q23 : Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Num = { 8, 5, 10, 4, 2, 6, 7, 1, 9, 3 };
            //int Max = Num[0];
            //int Min = Num[0];

            //for (int i = 0; i < Num.Length; i++)
            //{
            //    if (Num[i] > Max)
            //    {
            //        Max = Num[i];
            //    }
            //}

            //for (int j = 0; j < Num.Length; j++)
            //{
            //    if (Num[j] < Min)
            //    {
            //        Min = Num[j];
            //    }
            //}

            //Console.WriteLine($" Maximum Element  = {Max}");
            //Console.WriteLine($" Minimum Element  = {Min}");


            #endregion

            #region Q24 :Write a program in C# Sharp to find the second largest element in an array.

            //int[] Num = { 8, 5, 10, 4, 2, 6, 7, 1, 9, 3 };
            //int Max = Num[0];
            //int SecondMax = int.MinValue;
            //for (int i = 0; i < Num.Length; i++)
            //{
            //    if (Num[i] > Max)
            //    {

            //        Max = Num[i];
            //    }
            //}

            //for (int i = 0;i < Num.Length; i++)
            //{
            //    if (Num[i]>SecondMax&& Num[i]< Max)
            //    {
            //        SecondMax= Num[i];
            //    }
            //}
            //Console.WriteLine( $"second largest element= {SecondMax}");

            #endregion

            #region Q25 : Consider an Array of Integer values with size N, having values as in this Example
            ////{ 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            ////write a program find the longest distance between Two equal cells.In this example.
            ////The distance is measured by the number Of cells- for example, the distance between
            ////the first and the fourth cell is 2(cell 2 and cell 3).
            ////In the example above, the longest distance is between the first 7 and the
            ////10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            ////And the 10th 7s.
            ////Note:
            ////-Array values will be taken from the user
            ////-If you have input like 1111111 then the distance is the number of
            ////Cells between the first and the last cell.


            //Console.Write("Enter the size of the array (N):  ");
            //int.TryParse(Console.ReadLine(), out int N);

            //int[] num = new int[N];
            //Console.WriteLine("Enter the elements of the array: m");

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Element {i + 1} : ");
            //    num[i] = int.Parse(Console.ReadLine());
            //}


            //int MaxDistance = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = i + 1; j < num.Length; j++)
            //    {
            //        if (num[i] == num[j])
            //        {
            //            int Distance;
            //            Distance = j - i;
            //            if (Distance > MaxDistance)
            //            {
            //                MaxDistance = Distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"the longest distance  = {MaxDistance}");


            #endregion

            #region Q26 : Given a list of space separated words, reverse the order of the words.
            ////Input: this is a test        Output: test a is this
            ////Input: all your base        Output: base your all
            ////Input: Word                   Output: Word
            ////Note : 
            ////Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

            //Console.Write( " Please Enter The  Text  :  ");
            //string? Text = Console.ReadLine();

            //string[] Words = Text.Split(' ');
            //Array.Reverse(Words);
            //string ReversedText = string.Join(" ", Words);

            //Console.WriteLine(ReversedText);
            #endregion

            #region Q27: Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("Please Enter The Value: ");
            //int[,] FirstArray = new int[3, 3];
            //int[,] SecondArray = new int[3, 3];


            //for (int i = 0; i < FirstArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < FirstArray.GetLength(1);)
            //    {
            //        Console.Write($"Enter value for element [{i},{j}]: ");
            //        bool IsParsed = int.TryParse(Console.ReadLine(), out FirstArray[i, j]);
            //        if (IsParsed)
            //        {
            //            j++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //        }
            //    }
            //}
            //Console.Clear();

            //// copy all the elements of first array on second array .

            //for (int i = 0; i < SecondArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < SecondArray.GetLength(1); j++)
            //    {
            //        SecondArray[i, j] = FirstArray[i, j];
            //    }
            //}



            //// print second array
            //Console.WriteLine("The second array is:");

            //for (int i = 0; i < SecondArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < SecondArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(SecondArray[i, j]);
            //    }
            //}

            #endregion

            #region Q28 : Write a Program to Print One Dimensional Array in Reverse Order
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //for (int i=numbers.Length-1; i>=0; i--) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            // Function 

            #region Q01:  Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            ////1. Passing By Value 
            //// Modifying a value inside a function does not affect the original value outside the function.
            //// (A copy of the original value is passed.)


            ////2. Passing By Reference 
            ////Changes made within the function directly affect the original variable.
            ////(The address of the variable itself is passed)


            //// Example

            //int num1 = 3 , num2 = 4 ;

            //// Passing By Value
            //SWAP(num1, num2);//( 3,4)
            //Console.WriteLine(num1); //3 
            //Console.WriteLine(num2); // 4 

            //Console.WriteLine("=================================");
            //// Passing By Ref
            //SWAP(ref num1, ref num2);//( 3,4)
            //Console.WriteLine(num1); //4
            //Console.WriteLine(num2); // 3

            #endregion

            #region Q02: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine(CalculateSumOfDigits(25));
            #endregion

            #region Q03: Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .


            //Console.WriteLine(Isparsed(9));
            #endregion

            #region Q04:Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .

            //Console.WriteLine(CalculateTheFactorial(5));

            #endregion

            #region Q05:Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter .

            //string Name = "Adel Nasr";
            //Console.WriteLine( ChangeChar(ref Name, 5,  'n')); // Adel nasr 


            #endregion

        }
    }
}
