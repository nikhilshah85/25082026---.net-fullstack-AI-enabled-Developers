namespace OOPS_bankingAPP
{
    public class Accounts
    {        
        #region Notes
 //Old way of creating property, we should not disclose the variable to outside world, so we will use auto implemented property
        // int v_accNo; //we should not disclose

        // public int AccNo
        // {
        //     get { return v_accNo; }
        //     set { v_accNo = value; }
        // }

//new way of creating property, we should not disclose the variable to outside world, so we will use auto implemented property
        //variable will be created and used by runtime dynamically, as anyways we are not suppose to be dealing with variables
        //public int AccNo { get; set; } //auto implemented property
#endregion

        #region Properties
        public int AccNo { get; set; } //auto implemented property
        public string AccName { get; set; } //auto implemented property
        public double AccBalance { get; set; } //auto implemented property
        public bool IsActive { get; set; } //auto implemented property
        public string email { get; set; } //auto implemented property
#endregion

        #region  Methods
    public double Withdraw(int amount)
    {
        AccBalance = AccBalance - amount;
        return AccBalance;
    }

    public double Deposit(int amount)
    {
        AccBalance = AccBalance + amount;
        return AccBalance;
    }
#endregion
   
    
   
    }
}