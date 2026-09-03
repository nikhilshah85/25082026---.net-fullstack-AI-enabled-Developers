namespace Banking
{
    
    public class Savings : Accounts
    {

        public override double Withdraw(int amount)
        {
            if(amount > 5000)
            {
                throw new Exception("Max amount is 5000 for your Savings account");
            }
            else
            {
            return base.Withdraw(amount);
            }
        }

    }

}