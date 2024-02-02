namespace Module17
{
    public class Account
    {
        public AccountTypes Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public Account(AccountTypes type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
    }
}

