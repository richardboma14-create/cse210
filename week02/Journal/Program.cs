using System;
// Enhancements beyond the core requirements:
// 1. Records the exact date and time of each entry.
// 2. Allows users to record their daily mood.
// 3. Provides journal statistics showing the total number of entries.
// 4. Includes error handling for file operations.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== MY JOURNAL =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Journal statistics");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(saveFile))
                    {
                        try
                        {
                            journal.SaveToFile(saveFile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error saving journal: {ex.Message}");
                        }
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(loadFile))
                    {
                        try
                        {
                            journal.LoadFromFile(loadFile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error loading journal: {ex.Message}");
                        }
                    }
                    break;

                case "5":
                    Console.WriteLine(
                        $"You have written {journal.GetEntryCount()} journal entries."
                    );
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Thank you for journaling. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select 1-6.");
                    break;
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine("\nJournal Prompt:");
        Console.WriteLine(prompt);

        Console.Write("\nYour response: ");
        string response = Console.ReadLine() ?? "";

        Console.Write("How are you feeling today? ");
        string mood = Console.ReadLine() ?? "";

        Entry entry = new Entry();

        entry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        entry._prompt = prompt;
        entry._response = response;
        entry._mood = mood;

        journal.AddEntry(entry);

        Console.WriteLine("\nYour journal entry has been added!");
    }
}