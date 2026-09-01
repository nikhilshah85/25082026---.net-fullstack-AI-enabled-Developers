

bool continueTransaction = true;
while (continueTransaction)
{
    Console.Clear();
System.Console.WriteLine("!~~~~~~~~~~~~~~~~~~ Bank of America ~~~~~~~~~~~~~~~~~~!");
System.Console.WriteLine("1. Create Account");
System.Console.WriteLine("2. Check Balance");
System.Console.WriteLine("3. Withdraw Funds");
System.Console.WriteLine("4. Deposit Funds");
System.Console.WriteLine("5. Transfer Funds");
System.Console.WriteLine("6. View Transaction History");
System.Console.WriteLine("7. Change ATM PIN");
System.Console.WriteLine("8. Request Loan");
System.Console.WriteLine("9. Exit");

int userChoice = Convert.ToInt32(System.Console.ReadLine());
switch (userChoice)
{
    case 1:
       Console.WriteLine("Create new account, will collect details and process account creation.");
        break;
    case 2:
        Console.WriteLine("Checking account balance.");
        break;
    case 3:
        Console.WriteLine("Withdrawing funds.");
        break;
    case 4:
        Console.WriteLine("Depositing funds.");
        break;
    case 5:
        Console.WriteLine("Transferring funds.");
        break;
    case 6:
        Console.WriteLine("Viewing transaction history.");
        break;
    case 7:
        Console.WriteLine("Changing ATM PIN.");
        break;
    case 8:
        Console.WriteLine("Requesting loan.");
        break;
    case 9:
        System.Console.WriteLine("Thank you for using Bank of America. Goodbye!");
        continueTransaction = false;
        break;
    default:
        System.Console.WriteLine("Invalid choice. Please try again.");
        continueTransaction = false;
         System.Console.WriteLine("Thank you for using Bank of America. Goodbye!");
        break;
}
Console.WriteLine("Press any key to continue... exit.");
Console.ReadKey();
}
