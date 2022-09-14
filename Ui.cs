using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTyping
{

    internal class Ui
    {

        public Ui()
        {
            Console.Title = "SpeedTyping";
            Console.Clear();
            UpdateFrame();
                    
        }
        public void UpdateFrame()
        {
            Console.SetCursorPosition(2, 1);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        private void SingleLine()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }

        }
    }
}
