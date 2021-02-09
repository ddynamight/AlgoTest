using System;

namespace TriangleArea
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Welcome to Math Algo");

               Console.WriteLine("Please Enter the Value for A");
               int a = Int32.Parse(Console.ReadLine());

               Console.WriteLine("Please Enter the Value for B");
               int b = Int32.Parse(Console.ReadLine());

               Console.WriteLine("Please Enter the Value for C");
               int c = Int32.Parse(Console.ReadLine());

               var calculator = new Calculator();

               Console.WriteLine($"Result => {calculator.CalculateTriangleArea(a, b, c)}");

               Console.ReadLine();
          }
     }

     class Calculator
     {
          public double CalculateTriangleArea(int a, int b, int c)
          {
               double result = 0;

               double s = (a + b + c) / 2.0;

               result = Math.Sqrt(s * ((s - a)  * (s - b) * (s - c)));

               return result;
          }
     }
}
