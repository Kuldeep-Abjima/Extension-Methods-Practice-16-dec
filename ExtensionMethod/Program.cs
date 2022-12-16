using System;
using System.Globalization;
using MYarrayLIb;
namespace ExtensionMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the Size of an array : ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter the elements");
            for(int i = 0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"sum of this array is : {a.SUM()}");
            Console.WriteLine($"Max of this array is : {a.MAX()}");
            Console.WriteLine($"Avg of this array is : {a.AVG()}");
            Console.WriteLine($"Min of this array is : {a.MIN()}");
        }
    }
}