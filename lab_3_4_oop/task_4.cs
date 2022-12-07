using System;

namespace lab_3_4_oop
{
    class task_4
    {
        static void Main(string[] args)
        {
            Invoice shoes = new Invoice(2000, "Tom", "Nike");
            Console.WriteLine("Оберiть кiлькiсть обраного товару:");
            shoes.ChooseQuantity();
            shoes.Calculation();
            Console.ReadKey();
        }
    }
}
