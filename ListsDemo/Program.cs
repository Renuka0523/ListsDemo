using System;
using System.Collections.Generic;
namespace ListsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Add & AddRang

            var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[] { 6, 7,8 });
            foreach (int n in numbers) 
            Console.WriteLine(n);

            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.AddRange(new int[] { 6, 7, 8 });
            //foreach (int n in numbers)
            //    Console.WriteLine(n);


            //IndexOf
            Console.WriteLine();
            Console.WriteLine("IndexOf 1:" +numbers.IndexOf(1));
            Console.WriteLine("Last IndexOf 1:" + numbers.LastIndexOf(1));

            //Count

            Console.WriteLine("Count:"+numbers.Count);
            
            //Remove

           
            for(var i=0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]) ;
            }
            foreach (var number in numbers)
                Console.WriteLine(number);
            

            numbers.Clear();
            Console.WriteLine("Count:"+numbers.Count);

           
        }
    }
}
