namespace Banking
{
    public class Checking : Accounts
    {
        
        public bool isODEnabled {get; set;}

        public override double Withdraw(int amount)
        {
            if(amount > 30000)
            {
                throw new Exception("Max withdrawal for you is 30000");
            }
            return base.Withdraw(amount);
        }


    }
}