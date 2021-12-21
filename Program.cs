using System;
using System.Threading;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            calc.GetStandartAccount(new Account());

            calc.GetSalaryAccount(new Account());
        }
    }
}
