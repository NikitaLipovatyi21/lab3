using System;

namespace lab_3_1_oop
{
    class task_1
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10,5);
            Console.WriteLine("Вас вiтає калькулятор площi та периметра прямокутника!");
            Console.WriteLine("На даний момент сторони запрограмованi як 10 см та 5 см, бажаєте змiнити?");
            Console.WriteLine("Напишiть +, якщо так, та -, якщо нi");
            rectangle.rechangesides = Console.ReadLine();
            rectangle.RechangeSides();
            Console.WriteLine("Введiть першу сторонy прямокутника:");
            rectangle.DoubleCheckOne();
            Console.WriteLine("Супер! Тепер Введiть другу сторону:");
            rectangle.DoubleCheckTwo();
            Console.WriteLine("Бажаєте дiзнатись периметр цього прямокутника?");
            Console.WriteLine("Напишiть +, якщо так, та -, якщо нi");
            rectangle.choice1 = Console.ReadLine();
            rectangle.ChoiceOne();
            Console.WriteLine("Бажаєте дiзнатись площу цього прямокутника?");
            Console.WriteLine("Напишiть +, якщо так, та -, якщо нi");
            rectangle.choice2 = Console.ReadLine();
            rectangle.ChoiceTwo();
            Console.WriteLine("Дякую, що завiтали!!!");
            Console.ReadKey();
        }
    }
}
