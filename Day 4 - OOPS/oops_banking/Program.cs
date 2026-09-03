

using Banking;

// Accounts acc = new Accounts();

//this is the older way of createing an object
//2 challanges, 
//a. when I want to deal only with properties, why is it showing me the list of methods ?
//b. YOU might end repeating the property, increase the line of code, because property once assigned a value, still shows up intelliscence
Savings sav = new Savings();
sav.AccountNumber = 101;
sav.AccountType = TypeOfAccount.Savings;
sav.AccountBalance = 10000;
sav.AccountHolderName = "Nikhil";
sav.IsAccActive = true;

//thus MS gave us a new way
Savings sav2 = new Savings()
{
     AccountNumber=102, 
     AccountBalance =12000,
     AccountHolderName = "Peter Parker",
     AccountType = TypeOfAccount.Savings,
    IsAccActive = false 
};

Console.WriteLine("Avaialable Balance " + sav.AccountBalance);
try
{
sav.Withdraw(3000);
}
catch(Exception es)
{
    Console.WriteLine(es.Message);
}
Console.WriteLine("Avaialable Balance " + sav.AccountBalance);











