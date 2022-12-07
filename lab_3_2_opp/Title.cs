using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_2_opp
{
    class Title : Book
    {
        public string title;

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}
