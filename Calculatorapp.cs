using System;

class Program
{
    static void Main()
    {
        // i) Calculator app for kids
        int a = 10, b = 5;
        Console.WriteLine("Total apples = " + (a + b));
        Console.WriteLine("Difference of pencils = " + (a - b));
        Console.WriteLine("Total pages copied = " + (a * b));
        Console.WriteLine("Chocolates per kid = " + (a / b));
        Console.WriteLine("Leftover candies = " + (a % b));
        Console.WriteLine();

        // ii) Game scores comparison
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A scored more than B: " + (playerA > playerB));
        Console.WriteLine("Scores are equal: " + (playerA == playerB));
        Console.WriteLine("Any player failed to beat the other: " + (playerA <= playerB || playerB <= playerA));
        Console.WriteLine();

        // iii) Login system with logical operators
        string username = "admin";
        string password = "1234";

        bool isUsernameValid = (username == "admin");
        bool isPasswordValid = (password == "1234");

        if (isUsernameValid && isPasswordValid)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one valid: " + (isUsernameValid || isPasswordValid));
        Console.WriteLine("Username valid: " + isUsernameValid);
        Console.WriteLine("NOT Username valid: " + !isUsernameValid);
        Console.WriteLine("Password valid: " + isPasswordValid);
        Console.WriteLine("NOT Password valid: " + !isPasswordValid);
    }
}
