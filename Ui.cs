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
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030; 
        const int SC_SIZE = 0xF000;


        public Ui()
        {
            Console.Title = "SpeedTyping";
            Console.WriteLine();
            UpdateFrame();
                    
        }
        public void UpdateFrame()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            SingleLine();
            for (int i = 1; i < 9; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(" ");
                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write(" ");

            }
            SingleLine();
            Console.SetCursorPosition(2, 5);
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
