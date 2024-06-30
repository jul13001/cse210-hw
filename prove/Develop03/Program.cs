using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1);

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
    }
    }
}