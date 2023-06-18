using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Lesson 4

        // Task 1
        string firstName, lastName, pesel, employeeNumber;
        int age;
        char sex;

        //Task 2
        char var1 = '1', var2 = '2', var3 = '3';
        Console.WriteLine($"{var3}, {var2}, {var1}");

        //Task 3
        double length = 13, width = 14.5, diagonal;
        diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
        Console.WriteLine($"Diagonal: {diagonal}");

        //Task 4
        int numberInt = 1;
        string text = "Szkoła Dotneta";
        double numberDouble = 12.5;

        //Task 5
        Console.WriteLine("Enter your first name:");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter your height");
        double height;
        bool result = double.TryParse(Console.ReadLine(), out height);

        Console.WriteLine("Enter your age:");
        bool result2 = Int32.TryParse(Console.ReadLine(), out age);

        Console.WriteLine("ENter your sex ( M or F):");
        bool result3 = char.TryParse(Console.ReadLine(), out sex);
        Console.WriteLine(sex);

    }
}