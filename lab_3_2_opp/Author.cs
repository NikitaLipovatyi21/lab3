using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_2_opp
{
    class Author : Book
    {
        public string author;
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
}
