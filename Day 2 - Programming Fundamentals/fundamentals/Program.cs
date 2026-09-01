using System.ComponentModel;

//Console.WriteLine("Hello, World!");


#region Notes
// ------------------------------------------
// string - with small s is a keyword / datatype
// String - with capital S is a class 


// There are 2 types of data types in C#
// 1. Primitive data types - int, double, bool, char - the 1 provided by C# language
// 2. (UDT)Non-primitive data types - string, object, array - the 1 provided by .NET framework
// 3. User-defined data types(by developers) - classes, interfaces, delegates


// There are 2 ways to look at data types in C#
// 1. Value types - int, double, bool, char, struct, enum
// 2. Reference types - string, object, array

// string firstName = "Nikhil";
// string designation = "Software Engineer";
// int age = 25; 
// double salary = 100000;
// double height = 5.9;
// bool isMarried = false;

// System.Console.WriteLine($"My name is {firstName}, I am a {designation}, my age is {age}, my salary is {salary}, my height is {height} and I am married: {isMarried}");
#endregion


#region Input (intenally also does conditional processing of values)

System.Console.WriteLine("!~~~~~~~~~~~~~~ Welcome to CITI Bank ~~~~~~~~~~~~~~!");
string name = string.Empty;
System.Console.WriteLine("Please enter your name: ");
name = System.Console.ReadLine();


string city = string.Empty;
System.Console.WriteLine("Please enter your city: ");
city = System.Console.ReadLine();

int age = 0;
System.Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(System.Console.ReadLine());

bool isMarried;
System.Console.WriteLine("Are you married? (true/false): ");
isMarried = Convert.ToBoolean(System.Console.ReadLine());


Console.WriteLine("Thank you for providing your details. We will process your information and get back to you shortly.");

// we need to process the information provided by the user and check them against the banking criteria. 
//we will not start working with conditions If, if ...else, nested if, switch, ternary operator, etc. in the next part of this session.

#region Conditional Processing of values
//condition
//a. Name
//name should not be empty or null
//name should not contain less than 3 characters and more than 25 characters
//user may input name in any case, eg. "nikhil", "NIKHIL", "Nikhil" - we need to convert it to a standard format, e.g. "Nikhil" - first letter capital and rest small letters

//b. City
//city should not be empty or null, and can only be one of the following cities: "New York", "Los Angeles", "Chicago";

//c. Age
//age should be between 18 and 60
//cannot be a negative number or zero
//cannot be a decimal number
//cannot be left blank

//d. isMarried
//isMarried should be either true or false, and is Mandatory to provide a value for this field. It cannot be left blank.

bool validationsPassed = false;

if(name == null || name == string.Empty || name.Length < 3 || name.Length > 25)
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid name. Please enter a valid name with 3 to 25 characters.");
}
else
{
    // Convert the first letter to uppercase and the rest to lowercase
    name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
    validationsPassed = true;
}


if(city == null || city == string.Empty || (city != "New York" && city != "Los Angeles" && city != "Chicago"))
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid city. Please enter a valid city: New York, Los Angeles, or Chicago.");
}
else
{
    validationsPassed = true;
}


if(age < 18 || age > 60 ) 
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid age. Please enter an age between 18 and 60.");
}
else if(age <= 0)
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid age. Age cannot be zero or negative.");
}
else if(age % 1 != 0)
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid age. Age cannot be a decimal number.");
}
else
{
    validationsPassed = true;
}


if(isMarried != true && isMarried != false)
{
    validationsPassed = false;
    System.Console.WriteLine("Invalid marital status. Please enter either true or false.");
}
else
{
    validationsPassed = true;
}


if(validationsPassed)
{
    System.Console.WriteLine($"Approved !! Thank you {name} from {city}, age {age}, for providing your details.");
}
else
{
    System.Console.WriteLine($"Rejected !!  {name} Please correct the errors and try again.");
}
#endregion




#endregion
