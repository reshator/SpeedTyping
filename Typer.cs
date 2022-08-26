public class Typer
{
    private const string path = "D:\\projects\\SpeedTyping\\words_alpha.txt";
    private readonly string[] lines = File.ReadAllLines(path);

    public float Time { get; }
    public string? Answer { get; }

    private int _time;
    private string? _answer;
    private string? text;
        

    public Typer()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Typing test");
        Console.ResetColor();
    }

    public void Task()
    {
        Thread thread = new Thread(new ThreadStart(ViewTaskText));
        thread.Start();
        UserInput();
    }

    public void UserInput()
    {
        var userInput = Console.ReadLine();
    }

    public void ViewTaskText()
    {
        var text = GenerateText();
        Console.WriteLine("Write this text");
        Console.WriteLine(text);
        this.text = text;
    }
    
    private string GenerateText()
    {
        var random = new Random();
        string text = string.Empty;
        while(text.Split(" ").Length < 5) text += lines[random.Next(lines.Length)] + " ";
        text = text.Substring(0, text.Length - 1);
        return text;
    }

    
}