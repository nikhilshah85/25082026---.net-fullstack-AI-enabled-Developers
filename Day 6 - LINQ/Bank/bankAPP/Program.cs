
using bankLIB;

Accounts acc = new Accounts();
acc.accBalance = 5000;
acc.accName = "Nik";
acc.accNo = 101;

Console.WriteLine(acc.checkBalance());
Console.WriteLine(acc.Withdraw(800));
Console.WriteLine(acc.Deposit(12000));
