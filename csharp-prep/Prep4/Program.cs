using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter number: ");
            string listofnumbers = Console.ReadLine();
            number = int.Parse(listofnumbers);

        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}