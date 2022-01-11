using Kassa.Models;
using System;

namespace Kassa
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(0,Enums.Currency.Azn);
            cashRegister.AddNewSales(10, Enums.Currency.Azn);
            cashRegister.AddNewSales(10, Enums.Currency.Dollar);
            cashRegister.RemoveSales(10, Enums.Currency.Dollar);
            Console.WriteLine(cashRegister);
        }
    }
}
