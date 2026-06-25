using System;
using System.Data;
using System.IO;
using System.IO.Enumeration;



class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following Choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                journal.AddEntry(prompt, response, date);
            }
            else if (choice == "2")
            {
             journal.Display();   
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter a file name: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter a filename: ");
                string filename = Console.ReadLine();
                journal.Load(filename);

            }
            else
            {
                Console.WriteLine("Thank you! Have a good day!!!!!!");
            }
        }
    }
}