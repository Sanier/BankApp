using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Calculator
    {
        StandartAccountCalc standartAccount = new StandartAccountCalc();
        SalaryAccountCalc salaryAccount = new SalaryAccountCalc();
        public void GetStandartAccount(Account account)
        {
            standartAccount.CalculateInterest(account);
        }

        public void GetSalaryAccount(Account account)
        {
            salaryAccount.CalculateInterest(account);
        }

    }
}
