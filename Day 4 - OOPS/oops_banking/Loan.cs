namespace Banking
{

    public class Loans : Accounts
    {
        public override double Withdraw(int amount)
        {
            //we will have the validations for this class method
            throw new Exception("Sorry withdrawal not allow, please contact bank");

        }

    }


}