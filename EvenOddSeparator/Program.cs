using System;
using System.Collections.Generic;

namespace EvenOddSeparator
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Hello World!");
               int[] numbers = new int[] {25, 47, 42, 56, 32};

               var separator = new Separator();

               Console.WriteLine(separator.Separate(numbers));

               Console.ReadLine();
          }
     }

     public class Separator
     {
          public string Separate(int[] numbers)
          {
               List<int> evenElements = new List<int>();
               List<int> oddElements = new List<int>();

               foreach (var t in numbers)
               {
                    if (t % 2 == 1)
                    {
                         oddElements.Add(t);
                    }
                    else
                    {
                         evenElements.Add(t);
                    }
               }
               
               return $"Even Elements: {string.Join(", ", evenElements)} | Odd Elements {string.Join(", ", oddElements)}";
          }
     }
}
