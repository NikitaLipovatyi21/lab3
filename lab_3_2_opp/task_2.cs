using System;

namespace lab_3_2_opp
{
    class task_2
    {
        static void Main(string[] args)
        {
            Book title = new Title();
            Book author = new Author();
            Book content = new Content();
            Console.WriteLine("Вiтаю! Додайте назву своєї улюбленої книги:");
            ((Title)title).title = Console.ReadLine();
            Console.WriteLine("Хм..Цiкаво, а хто iї автор?");
            ((Author)author).author = Console.ReadLine();
            Console.WriteLine("Класс! А про що ця книга??");
            ((Content)content).content = Console.ReadLine();
            Console.WriteLine("Ось, що ви записали! У вас неперевершений смак у книгах!");
            ((Title)title).Show();
            ((Author)author).Show();
            ((Content)content).Show();
            Console.WriteLine("Дякую! Побiгла читати!");
    
   

            /* Book book2 = new Author();
             Author author = (Author)book2;
             Book book3 = new Content();
             Content content = (Content)book3;*/

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
