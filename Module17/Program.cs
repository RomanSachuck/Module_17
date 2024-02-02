namespace Module17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(AccountTypes.Ordinary, 52396.8, 12.3);
            Account account2 = new Account(AccountTypes.Salary, 52396.8, 12.3);

            Calculator.CalculateInterest(account);
            Console.WriteLine();
            Calculator.CalculateInterest(account2);
        }
    }
}
