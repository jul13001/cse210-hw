using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();


    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        _entries.Add(new Entry(prompt, response));
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry}");
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
        string[] parts = line.Split(",");

        string date = parts[0];       
        }
    } 
    
}