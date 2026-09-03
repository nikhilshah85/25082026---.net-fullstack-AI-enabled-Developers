using System.IO;
Console.WriteLine("Guest Management System");
Console.WriteLine("1. New Guest");
Console.WriteLine("2. View Guest");
int choice = Convert.ToInt32(Console.ReadLine());

if(choice == 1)
{
        string firstName;
string lastName;
string email;
double phone;
string SSN;

Console.WriteLine("Please Enter First Name");
firstName = Console.ReadLine();
Console.WriteLine("Please Enter Last Name");
lastName = Console.ReadLine();
Console.WriteLine("Please Enter Email Address");
email = Console.ReadLine();
Console.WriteLine("Please Enter Phone No");
phone = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter SSN");
SSN = Console.ReadLine();

FileStream guestFile = new FileStream(SSN + ".txt",FileMode.Create,FileAccess.Write);
StreamWriter writeGuest = new StreamWriter(guestFile);
writeGuest.WriteLine("First Name : " + firstName);
writeGuest.WriteLine("Last Name  : " + lastName);
writeGuest.WriteLine("Email Add  : " + email);
writeGuest.WriteLine("Phone No   : " + phone);
writeGuest.WriteLine("SSN No     : " + SSN);
writeGuest.Close();
guestFile.Close();
}
else if (choice == 2)
{
    Console.WriteLine("Enter SSN");
    int ssn = Convert.ToInt32(Console.ReadLine());
    FileStream readGuest = new FileStream(ssn + ".txt",FileMode.Open,FileAccess.Read);
    StreamReader read = new StreamReader(readGuest);
    Console.WriteLine(read.ReadToEnd());
    read.Close();
    readGuest.Close();

}





