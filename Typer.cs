using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SpeedTyping
{

    public class Typer
    {
        private const string path = "D:\\projects\\SpeedTyping\\words_alpha.txt";
        private readonly string[] lines = File.ReadAllLines(path);

        public float Time { get; }
        public string? Answer { get; }

        private int _time;
        private string? _answer;
        private string? text;


        public void Task()
        {
            ViewTaskText();
            UserInput();
        }

        private void UserInput()
        {
            var userInput = Console.ReadLine();
        }

        private void ViewTaskText()
        {
            var text = GenerateText();
            var reg = Regex.Split(text, "\\r\\n|\\r|\\n");
            Console.Write(text);
            Console.SetCursorPosition(2, 12);
            this.text = text;
        }

        private string GenerateText()
        {
            var random = new Random();
            string text = string.Empty;
            while (text.Split(" ").Length < 10) text += lines[random.Next(lines.Length)] + " ";
            text = text.Substring(0, text.Length - 1);
            return text;
        }


    }
}