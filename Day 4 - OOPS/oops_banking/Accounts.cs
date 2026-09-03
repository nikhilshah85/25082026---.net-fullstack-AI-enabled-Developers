namespace Banking
{
    public enum TypeOfAccount
    {
        Savings,
        Checking,
        Loans
    }
    public abstract class Accounts
    {
        #region Properties 
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }  = "";

        public TypeOfAccount AccountType { get; set; }
        public double AccountBalance { get; set; }
        public bool IsAccActive { get; set; }
     #endregion

        #region Methods

        public virtual double Withdraw(int amount)
        {
                //we should still have common validations placed here
                //eg. none of the account can withdraw a negative amount

                if(amount < 100)
                {
                    throw new Exception("Sorry you cannot withdraw less than 100$");
                }
                else
                {
                    AccountBalance = AccountBalance - amount;
                    return AccountBalance;

                }

        }

        public double Deposit(int amount)
        {
                AccountBalance = AccountBalance + amount;
                return AccountBalance;

        }

        public double CheckBalance()
        {
            return AccountBalance;
        }
        #endregion
    }
}