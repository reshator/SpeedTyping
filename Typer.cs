using System.Text.RegularExpressions;

public class Typer
{
    public float Time { get; set; }
    public string? Answer { get; set; }

    private float _time = 0;
    private string? _answer;

    public Typer()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Typing test");
        Console.WriteLine("Write this text");
        Console.ResetColor();
    }

    public void Task()
    {
        Console.WriteLine(GenerateText());
        UserAnswer();
    }

    private string PrintTime()
    {
        return string.Empty;
    }


    private string? UserAnswer()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Answer = Console.ReadLine();
        Console.ResetColor();
        return Answer;
    }

    private static string GenerateText()
    {
        return "Hello govern time print very from face with tell possible out";
    }
}
