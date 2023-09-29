using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithPatterns
{
    public class SalaryCalculator : ICalculateInterest
    {
        public void Execute(Account account)
        {
            Console.WriteLine("Используется зарплатный калькулятор.");
            Console.WriteLine("Процентная ставка: ");
            Console.Write(account.Interest = account.Balance * 0.5);
        }
    }
}
