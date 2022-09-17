using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpeedTyping {

public static class ArgsReader {

    
    public static void ArgHandler(string[] args) 
    {
        var commands = ArgReader();
        for (int i = 0; i < commands.Count; i++)
        {
            var arg = args[i];
            var command = commands[i];
            if (arg == command.param)
            {
                Console.WriteLine(command.text);
            }
        }
    }
    private static List<Command> ArgReader() 
    {
        string fileName = "static//commands//commands.json";
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Command>>(jsonString)!;
    }
}

}


