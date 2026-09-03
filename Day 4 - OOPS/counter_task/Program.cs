using System.IO;

//so there should be a file which will have a first default number
//We can create it manually or ask the application to create it on first run
FileStream counterFile;
StreamWriter writeNumber;
StreamReader readNumber;
int counterNumber = 1;
string myFileName = "Counter.txt";
//check of file does not exist, create it and store a default number in it
if(!File.Exists("counter.txt"))
{
    counterFile = new FileStream(myFileName,FileMode.Create,FileAccess.Write);
    writeNumber = new StreamWriter(counterFile);
    writeNumber.WriteLine(counterNumber); //this is the default value
    writeNumber.Close(); //this is ur pen
    counterFile.Close(); //close the book
}
//else open the file and read the number, 
// increase it by 1 and save it back to the file,
//  so next time that same number would be read and we will increase it by 1 
// and save it back to file,......
else
{
    counterFile = new FileStream(myFileName,FileMode.Open,FileAccess.Read);
    readNumber = new StreamReader(counterFile);
    counterNumber =Convert.ToInt32(readNumber.ReadLine());
    counterNumber = counterNumber + 1;
    readNumber.Close();
    counterFile.Close();

    counterFile = new FileStream(myFileName,FileMode.Open,FileAccess.Write);
    writeNumber = new StreamWriter(counterFile);
    writeNumber.WriteLine(counterNumber);
    writeNumber.Close();
    counterFile.Close();
}

Console.WriteLine("Counter Number : " + counterNumber);