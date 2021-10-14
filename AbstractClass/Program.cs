using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public static double Seconds { get; private set; }

        static void Main(string[] args)
        {
            List<int> num = new List<int>() { };
            int sum = 0;
            {
                num.Add(5);
                num.Add(7);
                num.Add(10);
            }

            foreach (var item in num)
            
                sum += item;
                Console.WriteLine($"Number in collection: {sum}");
            
        }
    }
}