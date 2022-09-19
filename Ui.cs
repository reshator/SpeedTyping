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
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }

        public static void UpdateFrame()
        {
            //Console.SetCursorPosition(2, 1);
        }

    }
}
