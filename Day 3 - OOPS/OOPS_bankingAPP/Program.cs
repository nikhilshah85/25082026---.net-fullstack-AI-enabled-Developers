using OOPS_bankingAPP;
//name mangaling - a feature of every compiler to avoid name conflicts
Accounts acc1 = new Accounts()
{
    AccNo = 101,
    AccName = "John",
    AccBalance = 1000,
    email = "john@somewhere.com",
    IsActive = true
};

Console.WriteLine("Account Balance is " + acc1.AccBalance);
Console.WriteLine("Choose an Operation: 1. Deposit \n 2. Withdraw");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("Enter the amount to deposit");
        int depositAmount = Convert.ToInt32(Console.ReadLine());
        acc1.Deposit(depositAmount);
        break;
    case 2:
        Console.WriteLine("Enter the amount to withdraw");
        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
        acc1.Withdraw(withdrawAmount);
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

Console.WriteLine("Account Balance is " + acc1.AccBalance);

