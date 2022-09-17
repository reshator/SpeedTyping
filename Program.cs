using SpeedTyping;

internal class Program
{
    private static void Main(string[] args)
    {
        Ui.Start();
        var typer = new Typer(args);
        typer.Task();
    }
}