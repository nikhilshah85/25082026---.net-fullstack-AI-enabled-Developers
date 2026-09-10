using EmpManagement;

// Employee empObj = new Employee()
// {
//    empNo=101,
//    empName = "Mike",
//     empAvailableLeave = 30,
//     empSalary = 20000,
//     empIsActive = true,
//     empPassword = "IncorrectPassword"
// };

Employee empObj = Employee.LoadObject();


bool continueWork = true;
while(continueWork)
{
Console.WriteLine("Employee Details ");
Console.WriteLine("E No : " + empObj.empNo);
Console.WriteLine("Name : " + empObj.empName);
Console.WriteLine("Leaves: " + empObj.empAvailableLeave);
Console.WriteLine("Salary: " + empObj.empSalary);
Console.WriteLine("Is Active : " + empObj.empIsActive);
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Please select from the option");
Console.WriteLine("1. Apply Leave");
Console.WriteLine("2. Apprise Salary");
Console.WriteLine("3. Edit first Name");
Console.WriteLine("4. Exit");

        int choice;
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter number of days for leaves");
                int leaves = Convert.ToInt32(Console.ReadLine());
                empObj.ApplyLeave(leaves);
                Console.WriteLine("Leaves approved");
                break;
            case 2:
                empObj.AppriseSalary();
                Console.WriteLine("Congratulations");
                break;
            case 3:
                Console.WriteLine("Enter New Name");
                string newName = Console.ReadLine();
                empObj.empName = newName;
                Console.WriteLine("Name changed");
                break;
            case 4:
                continueWork = false;
                Console.WriteLine("Thank you, see you again");
              Console.WriteLine(empObj.SaveObject());
                break;
            default:
                Console.WriteLine("Sorry, please choose right option");
                break;
        }



}