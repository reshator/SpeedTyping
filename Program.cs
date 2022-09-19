using SpeedTyping;

internal class Program
{

    private static void Main(string[] args)
    {
        Ui.Start();
        //if (args.Length != 1) ArgsReader.ArgHandler(args);
        var typer = new Typer();
        typer.Task();
    }
    
}