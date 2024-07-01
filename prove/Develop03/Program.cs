using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = "Nephi 3:7";
        var scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(1);
                Console.WriteLine(scripture.GetDisplayText());
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }


            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}