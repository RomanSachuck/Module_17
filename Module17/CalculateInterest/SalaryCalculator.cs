namespace Module17
{
    public class SalaryCalculator : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;

            Console.WriteLine("Произведен расчет процентной ставки зарплатного аккаунта");
        }
    }
}