using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTyping
{

    public static class Ui
    {

        public static void Start()
        {
            Console.Title = "SpeedTyping";
            Console.Clear();
        }

        public static void ViewTaskText(string text)
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
