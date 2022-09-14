using System.IO; 
namespace SpeedTyping
{
public class Typer
{
   
    private const string path = "words_alpha.txt";

    public float Time { get; }
    public string? Answer { get; }

    private int _time;
    private string? _answer;
    private static string directory;

    private string[] lines = File.ReadAllLines(path);

        public byte ArraySize { get; set; } = 10;
        public Typer() {
          directory = Directory.GetCurrentDirectory() + path;
        } 
        public void Task()
        {
            var generateArray = GenerateArrayText(ArraySize);
            var text = String.Join(" ", generateArray);
            ViewTaskText(text);
            UserInput(generateArray);
        }

        private void UserInput(string[] array)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.SetCursorPosition(2, 5);
            //Console.Write(userInput);
            int left = 2, top = 3;
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(left, top);
                var userInput = Console.ReadLine();
                if (userInput == array[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(left, 1);
                    Console.Write(userInput);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(left, 1);
                    Console.Write(userInput);
                }
                Console.ResetColor();
                left += array[i].Length + 1;
            }

        }
        
        //private void CursorMove(string element, int left = 2, int top = 10)
        //{
        //    Console.SetCursorPosition(left, top);
        //    var userInput = Console.ReadLine();
        //    left += element.Length + 1;

        //}

        private void ViewTaskText(string text)
        {
            Console.Write(text);
            Console.SetCursorPosition(2, 12); 
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


    }
}
