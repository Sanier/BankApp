﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class StandartAccountCalc : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
            {
                account.Interest -= account.Balance * 0.2;
            }
               

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
