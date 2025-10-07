using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message for the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask user for the package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Stop the program here
            }

            // Ask for the width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask for the height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask for the length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too big
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Stop the program
            }

            // Calculate the quote
            // Multiply width * height * length * weight and then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Show the total price
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");
        }
    }
}

