public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries=new List<Entry>();
        prompts=new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
    public void AddEntry(string response)
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} does not exist.");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                    entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}