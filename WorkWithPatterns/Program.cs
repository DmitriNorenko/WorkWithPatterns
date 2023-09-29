namespace WorkWithPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account { Balance = 15000 };

            Calculator.UseProfile(new UsualСalculator(), account);
            Calculator.UseProfile(new SalaryCalculator(), account);
        }
    }
}