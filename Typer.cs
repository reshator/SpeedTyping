public class Typer
{
    private const string path = "D:\\projects\\SpeedTyping\\words_alpha.txt";

    public float Time { get; }
    public string? Answer { get; }

    private int _time;
    private string? _answer;
        
    private string[] lines = File.ReadAllLines(path);

    public Typer()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Typing test");
        Console.WriteLine("Write this text");
        Console.ResetColor();
    }

    public void UserInput()
    {
        var text = GenerateText();
        Console.WriteLine(text);
        var userInput = Console.ReadLine();
        Task(userInput, text);
    }

    private string GenerateText()
    {
        var random = new Random();
        string text = string.Empty;
        while(text.Split(" ").Length < 5) text += lines[random.Next(lines.Length)] + " ";
        text.Substring(0, text.Length - 1);
        return text;
    }

    private void Task(string? userInput, string text)
    {
        if (userInput == null)
        {
            Console.WriteLine("You're great");
        }
    }
}