using System;

namespace Task_01
{
    public class Operator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(b != 0 ? "Division Result: " + ((double)a / b) : "Error: Division by zero");
        }

        public void OddEvenFinder(int number)
        {
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }
}
