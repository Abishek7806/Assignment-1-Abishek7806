using System;

class Program
{
    // ---------- i) ATM System ----------
    static void ATMSimulation()
    {
        string correctPIN = "1234";
        int attempts = 0;
        bool accessGranted = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            string enteredPIN = Console.ReadLine();

            if (enteredPIN == correctPIN)
            {
                Console.WriteLine("Access Granted");
                accessGranted = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                attempts++;
            }
        }

        if (!accessGranted)
        {
            Console.WriteLine("Card Blocked");
        }
    }

    // ---------- ii) Multiplication Table ----------
    static void MultiplicationTable()
    {
        string choice;
        do
        {
            Console.Write("Enter a number for multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.Write("Do you want to try another number? (Y/N): ");
            choice = Console.ReadLine().ToUpper();

        } while (choice == "Y");
    }

    // ---------- ii) Electricity Bill ----------
    static void ElectricityBill()
    {
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        int bill = 0;

        if (units <= 100)
        {
            bill = units * 2;
        }
        else if (units <= 200)
        {
            bill = (100 * 2) + ((units - 100) * 3);
        }
        else
        {
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
        }

        Console.WriteLine($"Total Bill: ₹{bill}");
    }

    // ---------- iii) Student Scores ----------
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }
        return (double)sum / marks.Length;
    }

    static void StudentAnalysis()
    {
        int[] marks = new int[5];
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        double avg = CalculateAverage(marks);
        Console.WriteLine($"Average = {avg}");

        if (avg >= 40)
            Console.WriteLine("Result: Passed");
        else
            Console.WriteLine("Result: Failed");
    }

    // ---------- iv) Name Validation ----------
    static bool IsValidName(string name)
    {
        foreach (char c in name)
        {
            if (!char.IsLetter(c) && c != ' ')
                return false;
        }
        return true;
    }

    static void NameValidation()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
            Console.WriteLine("Valid Name");
        else
            Console.WriteLine("Invalid Name (No digits or special characters allowed)");
    }

    // ---------- Main Menu ----------
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. ATM System");
            Console.WriteLine("2. Multiplication Table");
            Console.WriteLine("3. Electricity Bill");
            Console.WriteLine("4. Student Analysis");
            Console.WriteLine("5. Name Validation");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: ATMSimulation(); break;
                case 2: MultiplicationTable(); break;
                case 3: ElectricityBill(); break;
                case 4: StudentAnalysis(); break;
                case 5: NameValidation(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}
