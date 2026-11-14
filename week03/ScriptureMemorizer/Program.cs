using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity enhancement:
        // The program contains a library of scriptures and randomly
        // selects one each time the application starts.
        // It also hides only words that have not already been hidden.

        (Reference Reference, string Text)[] scriptures =
        {
            (
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            (
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."
            )
        };

        Random random = new Random();

        int selectedIndex = random.Next(scriptures.Length);

        Reference reference = scriptures[selectedIndex].Reference;
        string text = scriptures[selectedIndex].Text;

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Congratulations! You have hidden the entire scripture.");
        }
    }
}
