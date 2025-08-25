using System;
using System.Text.RegularExpressions;

class MultiFeatureApp
{
    static void Main()
    {
        Console.WriteLine("=== Welcome to the Multi-Feature Learning App ===\n");

        ATMSystem();
        MultiplicationTable();
        ElectricityBillCalculator();
        StudentScoreAnalyzer();
        NameValidator();

        Console.WriteLine("\n=== Program Completed ===");
    }

    // i) ATM System
    static void ATMSystem()
    {
        Console.WriteLine("\n--- ATM System ---");
        int correctPIN = 1234;
        int attempts = 0;
        bool accessGranted = false;

        while (attempts < 3)
        {
            Console.Write("Enter your PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());

            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                accessGranted = true;
                break;
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
                attempts++;
            }
        }

        if (!accessGranted)
            Console.WriteLine("Card Blocked");
    }

    // ii) Multiplication Table + Electricity Bill
    static void MultiplicationTable()
    {
        Console.WriteLine("\n--- Multiplication Table Generator ---");
        string choice;

        do
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            Console.Write("Do you want to try another number? (Y/N): ");
            choice = Console.ReadLine().ToUpper();
        }
        while (choice == "Y");

        ElectricityBillCalculator();
    }

    static void ElectricityBillCalculator()
    {
        Console.WriteLine("\n--- Electricity Bill Calculator ---");
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        int bill = 0;

        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = (100 * 2) + ((units - 100) * 3);
        else
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);

        Console.WriteLine("Total Bill: ₹" + bill);
    }

    // iii) Student Score Analyzer
    static void StudentScoreAnalyzer()
    {
        Console.WriteLine("\n--- Student Score Analyzer ---");
        int[] marks = new int[5];
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
            total += marks[i];
        }

        double average = total / 5.0;
        Console.WriteLine("Average Score: " + average);

        if (average >= 40)
            Console.WriteLine("Result: Passed");
        else
            Console.WriteLine("Result: Failed");
    }

    // iv) Name Validator
    static void NameValidator()
    {
        Console.WriteLine("\n--- Name Validator for ID Cards ---");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
            Console.WriteLine("Name is valid for ID card.");
        else
            Console.WriteLine("Invalid name. Please avoid digits or special characters.");
    }

    static bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
    }
}
