namespace Module17
{
    public static class Calculator
    {
        //можно было сделать как в примере из модуля, чтобы этот метод принимал интерфейс ICalculateInterest и просто вызывал из него метод расчета,
        //но тогда вызывающий должен всегда знать с аккаунтом какого типа он иммет дело, чтобы передать нужный интерфейс.
        //не знаю, нарушил ли я правило открытости/закрытости, но, в любом случае, где то должно быть ветвление с проверкой типа аккаунта.
        public static void CalculateInterest(Account account)
        {
            switch (account.Type)
            {
                case AccountTypes.Ordinary:
                    new OrdinaryCalculator().CalculateInterest(account);
                    break;
                case AccountTypes.Salary:
                    new SalaryCalculator().CalculateInterest(account);
                    break;
                default:
                    break;
            }
        }
    }
}
