namespace Tap.Solid.Ocp
{
    public class BankAccount
    {
        public decimal AccountBalance { get; private set; }
        public AccountType AccountType { get; private set; }

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            AccountBalance = initialBalance;
            AccountType = accountType;
        }

        public void ExtractMoney(decimal value)
        {
            var commision = 0m;

            if(AccountType == AccountType.Regular)
            {
                commision = value * 0.04m;
            }

            if (AccountType == AccountType.Gold)
            {
                commision = value * 0.02m;
            }

            AccountBalance = AccountBalance - (value + commision);
        }
    }
}
