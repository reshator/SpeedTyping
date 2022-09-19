using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpeedTyping {

public static class ArgsReader {

    public static void ArgHandler(string[] args) 
    {
        var commands = ArgReader();
        


    }   
    private static List<Command> ArgReader() 
    {
        string fileName = @"static/commands/commands.json";
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Command>>(jsonString)!;
    }


}

}


