

namespace SpeedTyping
{

    public class Typer
    {

        //public static string Path { get; set; } = "D:\\projects\\SpeedTyping\\static\\dict\\1-1000.txt";
        public static byte ArraySize { get; set; } = 10;
        
        private static string path = "..\\..\\..\\static\\dict\\1-1000.txt";
        private string[] lines = File.ReadAllLines(path);
        private int leftGap = 2, topGap = 3;

        public void Task()
        {
            var generatedArray = GenerateArrayText(ArraySize, lines);
            var text = String.Join(" ", generatedArray);
            Ui.ViewText(text, leftGap, topGap, ConsoleColor.Yellow);
            InputHandler(generatedArray);
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

        private void InputHandler(string[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                var userInput = UserInput();
                var word = array[i];
                var checkedWord = CheckWord(word, userInput);

                Ui.ViewText(word, leftGap, topGap, checkedWord);
                Console.ResetColor();

                leftGap += word.Length + 1;
            }

        }

        private string? UserInput()
        {

            Console.SetCursorPosition(2, 5);
            var userInput = Console.ReadLine()!;
            Console.SetCursorPosition(2, 5);
            Console.Write(new String(' ', Console.BufferWidth - 1));
            return userInput;
        }

        private ConsoleColor CheckWord(string word, string userInput)
        {
            if (userInput == word)
            {
                return ConsoleColor.Green;
            }
            else
            {
                return ConsoleColor.Red;
            }
        }
    }
}
