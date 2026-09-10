namespace bankLIB;

public class Accounts
{
 public int accNo { get; set; }
 public string accName { get; set; }
 public double accBalance { get; set; }
 public bool accIsActive { get; set; }
 public int branchNo { get; set; }


 public double withdraw(int amount)
    {
        accBalance = accBalance - amount;
        return accBalance;
    }

     public double Deposit(int amount)
    {
        accBalance = accBalance + amount;
        return accBalance;
    }
}


