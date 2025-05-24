public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // Display the date
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {_date}");

        // Create a new instance of Prompt Generator
        PromptGenerator promptGenerator = new PromptGenerator(); 
        // Get a random prompt
        _promptText = promptGenerator.GetRandomPrompt(); 
        Console.WriteLine($"Prompt: {_promptText}");

        // Allow the user to enter their response
        Console.WriteLine("Type the entry:");
        Console.Write("> ");
        // Read the user's input
        _entryText = Console.ReadLine();
    } 
}