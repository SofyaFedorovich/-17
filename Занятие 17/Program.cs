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
            BankAccount<int> account = new BankAccount<int>();
            Console.WriteLine("Ввести номер счёта:");
            BankAccount<int> balance = new BankAccount<int>();
            Console.WriteLine("Ввести баланс счёта:");
            BankAccount<string> name = new BankAccount<string>();
            Console.WriteLine("Ввести  фио владельца счёта:");

        }
    }
    class BankAccount <T>  // Класс для моделирования счета в банке с универсальным параметром
    {
        internal int account;    //закрытые поля для номера счета
        internal double balance; // ...баланса
        internal string name;    //фио владельца


    }
}
