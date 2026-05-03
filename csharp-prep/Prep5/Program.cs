using System;

class Program
{
     
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.

        // Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favoriteNumber = int.Parse(number);
            return favoriteNumber;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter the year you were born: ");
            string year = Console.ReadLine();
            birthYear = int.Parse(year);
        }

        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }

        static void DisplayResult(string name, int squaredNumber, int birthYear)
        {
            int age = 2026 - birthYear;
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
            Console.Write($"{name}, you will turn {age} this year.");
        }

        static void Main(string[] args)
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            PromptUserBirthYear(out int birthYear);
            int squaredNumber = SquareNumber(number);
            DisplayResult(name, squaredNumber, birthYear);

        }
    
}