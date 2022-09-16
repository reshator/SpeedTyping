using System.IO; 

namespace SpeedTyping
{

public class Typer
{
   
    private const string path = "static//dict//1-1000.txt";

    public float Time { get; }
    public string? Answer { get; }

    private int _time;
    private string? _answer;

    private string[] lines = File.ReadAllLines(path);

    public byte ArraySize { get; set; } = 10;
         
        public void Task()
        {
            var generatedArray = GenerateArrayText(ArraySize);
            var text = String.Join(" ", generatedArray);
            ViewTaskText(text);
            UserInput(generatedArray);
        }

        private void ViewTaskText(string text) {
            Console.Write(text);
            Console.SetCursorPosition(1,5);
        }

        private string[] GenerateArrayText(int arraySize)
       {
            var random = new Random();
            string[] text_array = new string[arraySize];
            for (int i = 0; i < text_array.Length; i++)
            {
                text_array[i] = lines[random.Next(lines.Length)];
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
                Console.Write(new String(' ', Console.BufferWidth - 1));
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