using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _journal = new List<Entry>();
    private PromptGenerator _promptgen = new PromptGenerator();

    public Journal()
    {
        
    }

    public void Save()
    {
        //Prompt for filename, path
        Console.Write("Enter filename to save: ");
        string fileName = Console.ReadLine();

        try
        {
            //save journal object to file
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                //write the date, prompt and entry text of each entry to the file in a json format
                string json = JsonSerializer.Serialize(_journal);
                //store json as fileName
                outputFile.WriteLine(json);
                //close file
                outputFile.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error saving file: " + e.Message);
        }
    }

    public void Load()
    {
        //Prompt for filename, path
        Console.Write("Enter filename to load: ");
        string fileName = Console.ReadLine();

        try
        {
            //read json from file
            string json = File.ReadAllText(fileName);

            //deserialize json back into a Journal object
            _journal = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error loading file: " + e.Message);
        }

    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry._prompt = _promptgen.GetPrompt();
        entry.displayPrompt();
        Console.Write("Enter your entry text: ");
        entry._entryText = Console.ReadLine();
        _journal.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _journal)
        {
            entry.displayEntry();
        }
    }
}
