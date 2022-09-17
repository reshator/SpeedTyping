using System.IO;

namespace SpeedTyping
{

    public class Typer
    {

        public static string Path { get; set; } = "static//dict//1-1000.txt";
        public static byte ArraySize { get; set; } = 10;
        
        private string[] lines = File.ReadAllLines(Path);

        public void Task()
        {
            //private static string[] lines = File.ReadAllLines();
            var generatedArray = GenerateArrayText(ArraySize, lines);
            var text = String.Join(" ", generatedArray);
            ViewTaskText(text);
            UserInput(generatedArray);
        }

        private void ViewTaskText(string text)
        {
            Console.Write(text);
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
            int left = 2, top = 3;
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(2, top);
                var userInput = Console.ReadLine();
                Console.Beep();
                Console.SetCursorPosition(2, top);
                Console.Write(new String(' ', Console.BufferWidth));
                var word = array[i];
                Console.SetCursorPosition(left, 1);

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

                left += array[i].Length + 1;
            }

        }
    }
}
