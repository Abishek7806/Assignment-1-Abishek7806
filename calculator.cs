using System;

class KidsLearningApp
{
    static void Main()
    {
        Console.WriteLine("=== Kids' Math Calculator ===");
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages when 10 pages are copied 5 times: " + (a * b));
        Console.WriteLine("Each kid gets " + (a / b) + " chocolates.");
        Console.WriteLine("Leftover candies after equal distribution: " + (a % b));

        Console.WriteLine("\n=== Score Comparison Game ===");
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A scored more than B: " + (playerA > playerB));
        Console.WriteLine("Scores are equal: " + (playerA == playerB));
        Console.WriteLine("Player A failed to beat B: " + (playerA <= playerB));
        Console.WriteLine("Player B failed to beat A: " + (playerB <= playerA));

        Console.WriteLine("\n=== Login System ===");
        bool usernameValid = true;
        bool passwordValid = false;

        if (usernameValid && passwordValid)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one condition is true: " + (usernameValid || passwordValid));
        Console.WriteLine("Username validity (opposite): " + (!usernameValid));
        Console.WriteLine("Password validity (opposite): " + (!passwordValid));

        Console.WriteLine("\n=== Quiz Score Tracker ===");
        int score = 50;
        score += 10;
        Console.WriteLine("After correct answer: " + score);
        score -= 5;
        Console.WriteLine("After wrong answer: " + score);
        score *= 2;
        Console.WriteLine("After bonus round: " + score);
        score /= 5;
        Console.WriteLine("After penalty: " + score);

        Console.WriteLine("\n=== Election Booth Eligibility ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age of person " + i + ": ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Eligible to Vote");
            else
                Console.WriteLine("Not Eligible");
        }

        Console.WriteLine("\n=== End of Program ===");
    }
}
