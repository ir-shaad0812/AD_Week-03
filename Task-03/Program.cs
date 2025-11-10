// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Loop through the ages if else if 
        if (age < 13)
            Console.WriteLine("Child");
        else if (age >= 13 && age <= 19)
            Console.WriteLine("Teenager");
        else
            Console.WriteLine("Adult");

        // Using switch expression 
        string category = age switch
        {
            < 13 => "Child",
            >= 13 and <= 19 => "Teenager",
            _ => "Adult"
        };

        Console.WriteLine("Using switch: " + category);
    }
}
