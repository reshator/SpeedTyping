using System.IO;

namespace SpeedTyping
{

    public class Typer
    {

        public static string Path { get; set; } = "static//dict//1-1000.txt";
        public static byte ArraySize { get; set; } = 10;

        private string[] lines = File.ReadAllLines(Path);
        private int leftGap = 2, topGap = 3;

    
        public void Task()
        {
            var generatedArray = GenerateArrayText(ArraySize, lines);
            var text = String.Join(" ", generatedArray);
            Ui.ViewText(text, leftGap, topGap);
            UserInput(generatedArray);
        }

        private string[] GenerateArrayText(int arraySize, string[] arrayText)
        {
            var random = new Random();
            string[] text_array = new string[arraySize];
            for (int i = 0; i < text_array.Length; i++)
            {
                text_array[i] = arrayText[random.Next(lines.Length)];
            }

            return text_array;
        }

        private void UserInput(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(2, topGap);
                var userInput = Console.ReadLine();
                Console.Beep();
                Console.SetCursorPosition(2, topGap);
                Console.Write(new String(' ', Console.BufferWidth));
                var word = array[i];
                Console.SetCursorPosition(leftGap, 1);

                if (userInput == word)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(word);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(word);
                }
                Console.ResetColor();

                leftGap += array[i].Length + 1;
            }

        }
    }
}
