using System.Timers;
using Timer = System.Threading.Timer;

namespace SpeedTyping
{

    public static class Ui
    {

        public static void Start()
        {
            Console.Title = "SpeedTyping";
            Console.Clear();
        }

        public static void ViewText(string text, int left, int top, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }


        public static void SetTimer()
        {
            Timer t = new Timer(ComputeBoundOp, 0, 0, 0);
        }

        private static void ComputeBoundOp(Object state)
        {
            int x = 30;
            while (x > 0)
            {
                x -= 1;
                Console.Title = Convert.ToString(x);
                Thread.Sleep(1000);
            
            }
        }

    }
}
