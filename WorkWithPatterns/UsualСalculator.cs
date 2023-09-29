using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithPatterns
{
    public class UsualСalculator : ICalculateInterest
    {
        public void Execute(Account account)
        {
            Console.WriteLine("Используется обычный калькулятор");
            Console.WriteLine("Процентная ставка: ");

            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000)
                Console.WriteLine(account.Interest -= account.Balance * 0.2);

            if (account.Balance >= 1000)
                Console.WriteLine(account.Interest -= account.Balance * 0.4);
        }
    }
}
