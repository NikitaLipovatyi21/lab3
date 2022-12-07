using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_4_oop
{
    class Invoice
    {
        public readonly int account; 
        public readonly string consumer;
        public readonly string provider;

        private string article; 
        private int quantity;

        int Account
        {
            get { return this.account; }
        }

        string Consumer
        {
            get { return this.consumer; }
        }
        string Provider
        {
            get { return this.provider; }
        }
        public Invoice(int account,string consumer,string provider)
        {
            this.account = account;
            this.consumer = consumer;
            this.provider = provider;
        }
        public void Calculation()
        {
            double PWD = 0.07;
            this.article = "Shoes";
            double WithPWD;
            double WithoutPWD;
            WithPWD = this.quantity*this.account + this.account*this.quantity*PWD ;
            WithoutPWD = this.account * this.quantity;
            Console.WriteLine($"Сума платежу з ПВД становить : {WithPWD} UAH");
            Console.WriteLine($"Сума платежу без ПВД становить : {WithoutPWD} UAH");
        }
        public void ChooseQuantity()
        {
           do
             {
                  
             }
                while (!int.TryParse(Console.ReadLine(), out this.quantity) || this.quantity < 1); 
        }
    }
}
