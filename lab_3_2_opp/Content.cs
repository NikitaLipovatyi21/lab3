using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_2_opp
{
    class Content : Book
    {
        public string content;

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
