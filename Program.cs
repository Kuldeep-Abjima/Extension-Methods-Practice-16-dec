using System;

namespace ListPractise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            Console.WriteLine("Enter the total number of names you want to insert in list");
            int size = int.Parse(Console.ReadLine());   
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("enter the name :");
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("your List is - :");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter the name you want to remove");
            string remove = Console.ReadLine();
            list.FindAll(x => x == remove);
            Console.WriteLine(list.Remove(remove));
            foreach(var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}