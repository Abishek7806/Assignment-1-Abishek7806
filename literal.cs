using System;

class Program
{
    static void Main()
    {
        // i) Float literal - Temperature check
        float temperature = 36.6f;
        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");

        // ii) Int literal - Voting eligibility
        int age = 18;
        if (age >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");

        // iii) Char literal - Gender check
        char gender = 'M';
        if (gender == 'M')
            Console.WriteLine("Male");
        else if (gender == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");

        // iv) Double literals - Price and discount
        double price = 1000.0;
        double discount = 10.0;  // percentage
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price after discount: " + finalPrice);

        // v) Bool literal - Login check
        bool isLoggedIn = true;
        if (isLoggedIn)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");

        // vi) Print literals with data type
        int myAge = 25;
        float myTemperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"Value: {myAge}, Type: {myAge.GetType()}");
        Console.WriteLine($"Value: {myTemperature}, Type: {myTemperature.GetType()}");
        Console.WriteLine($"Value: {grade}, Type: {grade.GetType()}");
        Console.WriteLine($"Value: {isPassed}, Type: {isPassed.GetType()}");
    }
}
