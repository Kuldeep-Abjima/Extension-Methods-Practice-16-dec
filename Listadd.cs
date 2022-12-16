using System;
using System.Drawing;

namespace ListPractise
{
    class program
    {
        static void Main(string[] args)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            Console.WriteLine("enter the size of list");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first List elements -: ");
            for (int i = 0; i < size; i++)
            {
                l1.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("enter the Elemts of second list - ;");
            for(int i =0; i <size; i++)
            {
                l2.Add(int.Parse(Console.ReadLine()));
            }
            var l3 = new List<int>();
            int j = size-1;
            int sum = 0;
            for(int i = 0; i <size; i++)
            {

                l3.Add(l1[i] + l2[j]);
                j--;

            }
            
            Console.WriteLine("l3 elements are - :");
            foreach(var item in l3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sum of all - : ");

            for(int i = 0; i < l3.Count; i++)
            {
                sum += l3[i];
            }

            Console.WriteLine(sum);
           
        }
    }
}