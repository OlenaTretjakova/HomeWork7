using System;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 1, 32, 56, 78, 9, 56, 0, 21, 14, 15,21, 16, 17, 18 };
            MyArray arr1 = new MyArray(values);

            Console.WriteLine($"Number of elements in array less than your value:{arr1.Less(56)}");

            Console.WriteLine($"Number of elements in array more than your value:{arr1.Greater(56)}");

            Console.Write("Even numbers in the array:");
            arr1.ShowEven();

            Console.WriteLine();

            Console.Write("No even numbers in the array: ");
            arr1.ShowOdd();

            Console.WriteLine();

            Console.Write("Number of unique elements: ");
            Console.WriteLine(arr1.CountDistinct());

            Console.Write("The number of elements equal to the given value: ");
            Console.WriteLine(arr1.EqualToValue(21));

            Console.ReadLine();
        }
    }
}
