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
            BankAccount<string> bankAccount2 = new BankAccount<string>();




            /* BankAccount<double> bankAccount2 = new BankAccount<double>();
             bankAccount2.Balance = 0;
             BankAccount<string> bankAccount3 = new BankAccount<string>();
             bankAccount3.Name = "{}";
             bankAccount1.accountInfo <int>();
             bankAccount1.P   */         //метод для вывода информации об экземпляре класса на печать

            bankAccount1.Print<T>();  

            Console.ReadKey();

        }
    }
    class BankAccount<T>  // Класс для моделирования счета в банке обобщенный
    {
        internal T account;    //закрытые поля для номера счета, параметр Т определяет тип номера счета
        internal double balance; // поле баланса
        internal string name;    //поле фио владельца
        public void AccountInfo<T> (T value)    //метод для доступа к данным - заполнения и чтения
        {
            int Account = Convert.ToInt32(Console.ReadLine());
            double balance = Convert.ToDouble(Console.ReadLine());
            string name = Console.ReadLine();
        }
       public void Print<T>(T value)
        {
            Console.WriteLine("Информация по счету: номер {0}, баланс {1}, фио владельца {2}",account, balance,name);
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
                    Console.WriteLine("Баланс счета должен быть положительным");
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
