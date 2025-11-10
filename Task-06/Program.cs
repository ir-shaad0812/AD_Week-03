// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        try
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }

            Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
