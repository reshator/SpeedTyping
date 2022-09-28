using SpeedTyping;
using System.CommandLine;

internal class Program
{

    //private static void Main(string[] args)
    //{
    //    Ui.Start();
    //    //if (args.Length != 0) ArgsReader.ArgHandler(args);
    //    var typer = new Typer();
    //    typer.Task();
    //}
    static async Task<int> Main(string[] args)
    {
        var wordsOption = new Option<byte>(
            name: "--words",
            description: "The word count for task.",
            getDefaultValue: () => Typer.ArraySize
            );

        var rootCommand = new RootCommand("Simple typing test for CLI");
        rootCommand.AddOption(wordsOption);

        rootCommand.SetHandler((wordsOptionValue) =>
        {
            Ui.Start();
            Typer.ArraySize = wordsOptionValue;
            Typer.Task();

        }, wordsOption);

        return await rootCommand.InvokeAsync(args);

    }
}