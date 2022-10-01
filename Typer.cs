namespace SpeedTyping
{

    public static class Typer
    {
        public static byte ArraySize { get; set; } = 10;
        public static string Lang { get; set; } = "1-1000.txt";
        private static readonly string dir = "..\\..\\..\\static\\dict\\";
        private static int leftGap = 2, topGap = 3;

        public static void Task()
        {
            var lines = File.ReadAllLines(dir + Lang);
            var generatedArray = GenerateArrayText(ArraySize, lines);
            var text = String.Join(" ", generatedArray);
            Ui.ViewText(text, leftGap, topGap, ConsoleColor.Yellow);
            InputHandler(generatedArray);
        }

        public static void GetFileName(string langOptionValue)
        {
            string[] files = Directory.GetFiles(dir);
            foreach (var file in files)
            {
                if (langOptionValue == Path.GetFileName(file))
                {
                    Typer.Lang = file;
                }
            }
            
        }

        private static string[] GenerateArrayText(int arraySize, string[] arrayText)
        {
            var random = new Random();
            string[] text_array = new string[arraySize];
            for (int i = 0; i < text_array.Length; i++)
            {
                text_array[i] = arrayText[random.Next(arrayText.Length)];
            }

            return text_array;
        }

        private static void InputHandler(string[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                var userInput = UserInput();
                var word = array[i];
                var checkedWord = CheckWord(word, userInput!);

                Ui.ViewText(word, leftGap, topGap, checkedWord);
                Console.ResetColor();

                leftGap += word.Length + 1;
            }

        }

        private static string? UserInput()
        {

            Console.SetCursorPosition(2, 5);
            var userInput = Console.ReadLine()!;
            Console.SetCursorPosition(2, 5);
            Console.Write(new String(' ', Console.BufferWidth - 1));
            return userInput;
        }

        private static ConsoleColor CheckWord(string word, string userInput)
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
