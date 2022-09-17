using SpeedTyping;

internal class Program
{

    private static void Main(string[] args)
    {
        Ui.Start();
        ArgsReader.ArgHandler(args);
        var typer = new Typer();
        typer.Task();
    }
    


}