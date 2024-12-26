using System;
using System.Text;

namespace assignmnent5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1-
            //int x = 1, y = 2;
            //Console.WriteLine("Pass By Value:");
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine($"x = {x}, y = {y}");
            //SwapByValue(x, y);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine($"x = {x}, y = {y}");
            ////Function only have a copy of values not the actual values with their address in stack.

            //Console.WriteLine("Pass By Reference");
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine($"x = {x}, y = {y}");
            //SwapByRef(ref x, ref y);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine($"x = {x}, y = {y}");
            ////Function have a reference of the actual values with their address in stack, So it changes in the variable in memory;
            #endregion

            #region 2-
            //Console.WriteLine("Pass By Value");
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //ArrByValue(arr1);
            //Console.WriteLine("After Function");
            //Console.WriteLine("arr[0] = " + arr1[0]);
            //Console.WriteLine("Pass By Reference");
            //int[] arr2 = { 1, 2, 3, 4, 5 };
            //ArrByRef(ref arr2);
            //Console.WriteLine("After Function");
            //Console.WriteLine("arr[0] = " + arr2[0]);

            // In pass by value or reference the array is passed always by reference because it's reference type and the address is always passed.
            // the pass by value has a copy of the address but pass by reference it have the actual address.
            #endregion

            #region 3-
            //Console.Write("Enter your First number:");
            //bool isParsed1 = int.TryParse(Console.ReadLine() ?? "0", out int num1);
            //while (!isParsed1)
            //{
            //    Console.WriteLine("Invalid number, Enter your First number:");
            //    isParsed1 = int.TryParse(Console.ReadLine() ?? "0", out num1);
            //}
            //Console.Write("Enter your Second number:");
            //bool isParsed2 = int.TryParse(Console.ReadLine() ?? "0", out int num2);
            //while (!isParsed2)
            //{
            //    Console.WriteLine("Invalid number, Enter your Second number:");
            //    isParsed2 = int.TryParse(Console.ReadLine() ?? "0", out num2);
            //}
            //int sum = 0, sub = 0;
            //Calculate(num1, num2, out sum, out sub);
            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Sub = {sub}");
            #endregion

            #region 4-
            //Console.Write("Enter your number:");
            //bool isParsed = int.TryParse(Console.ReadLine() ?? "0", out int num);
            //while (!isParsed)
            //{
            //    Console.WriteLine("Invalid number, Enter your First number:");
            //    isParsed = int.TryParse(Console.ReadLine() ?? "0", out num);
            //}
            //Console.WriteLine(CalcSum(num));
            #endregion

            #region 5-
            //Console.WriteLine(IsPrime(5));
            //Console.WriteLine(IsPrime(20));
            //Console.WriteLine(IsPrime(21));
            //Console.WriteLine(IsPrime(13));
            //Console.WriteLine(IsPrime(2));
            //Console.WriteLine(IsPrime(3));
            #endregion

            #region 6-
            //int[] arr = { 1, 5, 10, 8, 15, -9, 16 };
            //MinMaxArray(ref arr, out int max, out int min);
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");
            #endregion

            #region 7-
            //Console.Write("Enter +ve integer number:");
            //bool isParsed = int.TryParse(Console.ReadLine() ?? "0", out int num);
            //while (!isParsed || num < 0)
            //{
            //    Console.WriteLine("Invalid number, Enter +ve integer number");
            //    isParsed = int.TryParse(Console.ReadLine() ?? "0", out num);
            //}
            //Console.WriteLine($"Factorial = {Factorial(num)}");
            //Console.WriteLine($"Factorial = {FactorialR(num)}");
            #endregion

            #region 8-
            //Console.Write("Please enter Your String:");
            //string str = Console.ReadLine()??"";
            //Console.WriteLine("Enter Char that you want");
            //char ch = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //Console.WriteLine("Enter Index");
            //int index = int.Parse(Console.ReadLine()??"0");
            //Console.WriteLine(ChangeChar(index, str, ch));
            #endregion
        }

        #region 1-
        public static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region 2-
        public static int[] ArrByValue(int[] arr)
        {
            arr[0] = 10;
            return arr;
        }

         public static int[] ArrByRef(ref int[] arr)
         {
            arr[0] = 10;
            return arr;
        }
        #endregion

        #region 3-
        public static void Calculate(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        #endregion

        #region 4-
        public static int CalcSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        #endregion

        #region 5-
        public static bool IsPrime(int num)
        {
            bool isPrime = true;
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }
            return isPrime;
        }
        #endregion

        #region 6-
        public static void MinMaxArray(ref int[] arr, out int max, out int min)

        {
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }
                }
            }
        }
        #endregion

        #region 7-
        public static int Factorial(int x)
        {
            int fact = 1;
            if (x == 0 || x == 1)
            {
                return fact;
            }
            for (int i = 2; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        #region recursive
        public static int FactorialR(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            return x * FactorialR(x - 1);
        }
        #endregion
        #endregion

        #region 8-
        public static StringBuilder ChangeChar(int index, string str, char ch)
        {
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < str.Length; i++) {
                if (i == index)
                {
                    strb.Append(ch);
                }
                else
                {
                    strb.Append(str[i]);
                }
            }
            return strb;
        }
        #endregion
    }
}