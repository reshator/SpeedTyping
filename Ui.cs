namespace SpeedTyping
{

    public static class Ui
    {

        public static void Start()
        {
            Console.Title = "SpeedTyping";
            Console.Clear();
        }

        public static void ViewText(string text, int left, int top)
        {
            Console.SetCursorPosition(2, 1);
            Console.Write(text);
        }

        public static void UpdateFrame()
        {
            //Console.SetCursorPosition(2, 1);
        }

    }
}
