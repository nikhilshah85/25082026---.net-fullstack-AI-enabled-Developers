
using System.Collections;
using System.Collections.Generic;
using EmployeeManagement;
#region Arrays
// int[] myNumber = new int[10];
// for(int i=0;i < myNumber.Length;i++)
// {
//     Console.WriteLine("Please enter your " + i + " Number");
//     myNumber[i] = Convert.ToInt32(Console.ReadLine());
// }

// int additions = 0;
// int evenNumber = 0;
// int oddNumber = 0;

// for (int i = 0; i < myNumber.Length; i++)
// {   
//     additions = additions + myNumber[i];    
//     if(myNumber[i] % 2 == 0)
//     {
//         evenNumber++;
//     }
//     else
//     {
//         oddNumber++;
//     }
// }
// Console.WriteLine("Addition of numbers : " + additions);
// Console.WriteLine("Even Numbers         :"  + evenNumber);
// Console.WriteLine("Odd Numbers         :"  + oddNumber);
#endregion

#region ArrayList


// ArrayList myList = new ArrayList();
// myList.Add(10);
// myList.Add("Nikhil");
// myList.Add(true);
// myList.Add(40);
// myList.Add(10.4);
// myList.Add(new DateTime());
// myList.Add(new {empNo=101,empName="Jack",empDesignation="Sales"});

// foreach (var item in myList)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine(myList.Count);
#endregion

#region List
// List<string> friends  = new List<string>();
// friends.Add("Cole");

// string newfriend = "a";

// while(newfriend != "")
// {
//     Console.Write("Add new friend");
//     newfriend = Console.ReadLine();
//     friends.Add(newfriend);
// }
// Console.WriteLine("Total friends " + friends.Count);

#region List with object
// List <Employee> empList = new List<Employee>();

// empList.Add(new Employee(){ empNo=101, empName="Michal", empLastName="Jackson", empDept=10, empIsPermenant=true, empSalary=5000});
// empList.Add(new Employee(){ empNo=102, empName="Donald", empLastName="Trump", empDept=20, empIsPermenant=true, empSalary=2000});
// empList.Add(new Employee(){ empNo=103, empName="Peter", empLastName="Parker", empDept=30, empIsPermenant=false, empSalary=3000});
// empList.Add(new Employee(){ empNo=104, empName="Shaun", empLastName="Micheal", empDept=10, empIsPermenant=true, empSalary=5000});
// empList.Add(new Employee(){ empNo=105, empName="Mary", empLastName="Jane", empDept=20, empIsPermenant=false, empSalary=400});
// empList.Add(new Employee(){ empNo=106, empName="Britney", empLastName="Spear", empDept=20, empIsPermenant=true, empSalary=6000});
// empList.Add(new Employee(){ empNo=107, empName="Drew Bery", empLastName="More", empDept=30, empIsPermenant=true, empSalary=9000});
// empList.Add(new Employee(){ empNo=108, empName="Under", empLastName="Taker", empDept=30, empIsPermenant=false, empSalary=12000});
// empList.Add(new Employee(){ empNo=109, empName="Sunny", empLastName="Haynes", empDept=30, empIsPermenant=true, empSalary=17000});
// empList.Add(new Employee(){ empNo=110, empName="Big", empLastName="Show", empDept=20, empIsPermenant=false, empSalary=55000});
// empList.Add(new Employee(){ empNo=111, empName="Randy", empLastName="Orton", empDept=10, empIsPermenant=true, empSalary=75000});

// int count_permenat = 0;
// int count_notpermenant = 0;
// int highly_paid = 0;
// foreach (var item in empList)
// {

//     if(item.empIsPermenant)
//     {
//         count_permenat++;
//     }
//     else
//     {
//         count_notpermenant++;
//     }
//     if(item.empSalary > 50000)
//     {
//         highly_paid++;
//     }

//     Console.WriteLine("Emp No : " + item.empNo);    
//     Console.WriteLine("Emp Name : " + item.empName);
//     Console.WriteLine("Emp Last Name : " + item.empLastName);
//     Console.WriteLine("Emp SAl : " + item.empSalary);
//     Console.WriteLine("Emp Dept : " + item.empDept);
//     Console.WriteLine("Emp is Permenat : " + item.empIsPermenant);
//     Console.WriteLine("-----------------------------------------------------");
// }
// Console.WriteLine("########################################");
// Console.BackgroundColor = ConsoleColor.DarkGreen;
// Console.WriteLine("Permemnat : " + count_permenat);
// Console.WriteLine("Not permenant : " + count_notpermenant);
// Console.WriteLine("Highly paid : " + highly_paid);

#endregion

#endregion

#region Hashtable
// Hashtable friends = new Hashtable();
// friends.Add(1,"Nick");
// friends.Add(2,"Harry");
// friends.Add(3,"Harmony");
// friends.Add(4,"Paul");
// friends.Add("Five",false);
// friends.Add(30.90,10);

// foreach (var item in friends.Values)
// {
//     Console.WriteLine(item);
// }
#endregion

#region Dictionary
// Dictionary<int,string> friends = new Dictionary<int, string>();
// // Dictionary<int,Employee> empList =new Dictionary<int, Employee>();
// friends.Add(1,"Joe");
// friends.Add(2,"Bill");
// friends.Add(3,"Bush");
// friends.Add(4,"Donald");

// foreach (var item in friends)
// {
//     Console.WriteLine(item.Value);
// }
#endregion