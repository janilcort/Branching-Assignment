// This program calculates a shipping quote for a package using simple user input and arithmetic.
// The program follows the specified steps: asks for weight and dimensions, checks limits, and calculates the quote.

using System; // Importing the System namespace to use Console methods

namespace PackageExpress // Define a namespace for organization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message at the start of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine()); // Convert input from string to decimal

            // Check if the package weight is greater than 50
            if (weight > 50)
            {
                // Display message and end the program if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user to enter the package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the sum of dimensions is greater than 50
            if (width + height + length > 50)
            {
                // Display message and end the program if package is too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the quote using the given formula:
            // (width * height * length * weight) / 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the calculated shipping quote to the user in currency format
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // End the program with a thank-you message
            Console.WriteLine("Thank you!");
        }
    }
}
