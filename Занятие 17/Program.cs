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
        {   //параметризированный экземпляр класса 
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.AccountInfo(11111, 29800, "Федорович С.Ю.");
            bankAccount1.Print();
            Console.WriteLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.AccountInfo("11111", 18999, "Федорович С.Ю.");
            bankAccount2.Print();
            Console.ReadLine();

        }
    }
    class BankAccount<T>  // Класс для моделирования счета в банке обобщенный
    {

        private T account;    //закрытые поля для номера счета, параметр Т определяет тип номера счета
        private double balance; // поле баланса
        private string name;    //поле фио владельца
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

        public void AccountInfo(T account, double balance, string name)    //метод для доступа к данным - заполнения и чтения
        {
            Console.WriteLine("Введите ФИО владельца счета: ");
            Name = (string)Convert.ChangeType(Console.ReadLine(), typeof(string));
            Console.WriteLine("Введите номер счета: ");
            Account = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс счета: ");
            Balance = (double)Convert.ChangeType(Console.ReadLine(), typeof(double));
        }

            public void Print() //метод для вывода информации на консоль
            {
                Console.WriteLine("Информация по счету: номер {0}, баланс счета {1}, фио владельца {2}", account, balance, name);
            }

        }
    }
