using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int>bankAccount1 = new BankAccount<int>();

            BankAccount<double> bankAccount2 = new BankAccount<double>();

            BankAccount<string> bankAccount3 = new BankAccount<string>();
            
            Console.ReadKey();

        }
    }
    class BankAccount<T>  // Класс для моделирования счета в банке с универсальным параметром
    {
        private T account;    //закрытые поля для номера счета
        private double balance; // ...баланса
        private string name;    //фио владельца
        public void Info<T>(T value)
        {
            Console.WriteLine();
        }
        public T Account
        {
            set
            {
                account = value;
            }
            get
            {
                return account;
            }
        }
        public double Balance
        {
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс счета не может быть отрицательным");
                }
            }
            get
            {
                return balance;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
