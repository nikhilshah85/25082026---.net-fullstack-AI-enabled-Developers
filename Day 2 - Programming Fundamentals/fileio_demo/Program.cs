using System.IO;
Console.WriteLine("FILE IO Demo");


#region Create and write to a file

// //this of this is a book
// FileStream myFile = new FileStream("myFile.txt",FileMode.Create,FileAccess.Write);

// //this is a pen
// StreamWriter myPen = new StreamWriter(myFile);

// //lets write
// myPen.WriteLine("Hello, My name is Nikhil welcome to my book");
// myPen.WriteLine("I am a software engineer and I love to code");
// myPen.WriteLine("I am from India and I love to travel");
// string hobbie ="";
// Console.WriteLine("What is your hobbie?");
// hobbie = Console.ReadLine();
// myPen.WriteLine(hobbie);

// myPen.Close(); //if you do not close the pen then the data will not be written to the file, and memory will not be released
// myFile.Close(); //if you do not close the file then the data will not be written to the file, and memory will not be released
// Console.WriteLine("File has been created and data has been written to the file");
#endregion

#region Read from a file

FileStream myBook = new FileStream("myFile.txt", FileMode.Open, FileAccess.Read);

StreamReader myReader = new StreamReader(myBook);

Console.WriteLine(myReader.ReadToEnd());


myReader.Close();
myBook.Close();

#endregion