using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpeedTyping {

public static class ArgsReader {

    public static void ArgHandler(string[] args) 
    {
        var commands = ArgReader();
        //Ui.ViewText(command.text, 2, 5);
    }   
    private static List<Command> ArgReader() 
    {
        string fileName = @"static/commands/commands.json";
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Command>>(jsonString)!;
    }
}

}


