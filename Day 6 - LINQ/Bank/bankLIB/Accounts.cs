namespace bankLIB;

public class Accounts
{
    public int accNo { get; set; }
    public double accBalance { get; set; }
    public string accName { get; set; } = "";


    public double checkBalance()
    {
        return accBalance;
    }

    public double Withdraw(int amount)
    {
        //do your validations
        //connect to database and execute sql query on  table (we will use linq)
        accBalance = accBalance - amount;
        return accBalance;
    }

    public double Deposit(int amount)
    {
         //do your validations
        //connect to database and execute sql query on  table (we will use linq)
        accBalance = accBalance + amount;
        return accBalance;
    }
}

