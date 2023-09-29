using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithPatterns
{
    public static class Calculator
    {
        public static void UseProfile(ICalculateInterest calculateInterest, Account account)
        {
            calculateInterest.Execute(account);
        }
    }
}
