using SpeedTyping;
using System.CommandLine;

internal class Program
{

    static async Task<int> Main(string[] args)
    {
        var wordsOption = new Option<byte>(
            name: "--words",
            description: "The word count for task.",
            getDefaultValue: () => Typer.ArraySize
            );

        var langOption = new Option<string>(
            name: "--lang",
            description: "Change the word list",
            getDefaultValue: () => "");

        var rootCommand = new RootCommand("Simple typing test for CLI");
        rootCommand.AddOption(wordsOption);
        rootCommand.AddOption(langOption);

        rootCommand.SetHandler((wordsOptionValue, langOptionValue) =>
        {
            Ui.Start();
            Typer.ArraySize = wordsOptionValue;
            Typer.Task();

        }, wordsOption, langOption);

        return await rootCommand.InvokeAsync(args);

    }
}