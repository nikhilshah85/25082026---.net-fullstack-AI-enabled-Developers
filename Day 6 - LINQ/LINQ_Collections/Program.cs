
using EmployeeManagement;



List <Employee> eList = new List<Employee>()
{
    new Employee(){ empNo=101, empName="Tom",  empDepartmentNo=10, empIsPermenant=true, empSalary=1000},
    new Employee(){ empNo=102, empName="Jon Snow",  empDepartmentNo=20, empIsPermenant=true, empSalary=2000},
    new Employee(){ empNo=103, empName="Sunny Haynes",  empDepartmentNo=30, empIsPermenant=true, empSalary=3000},
    new Employee(){ empNo=104, empName="Peter Parker",  empDepartmentNo=20, empIsPermenant=true, empSalary=4000},
    new Employee(){ empNo=105, empName="Mary Jane",  empDepartmentNo=20, empIsPermenant=false, empSalary=5000},
    new Employee(){ empNo=106, empName="David Miller",  empDepartmentNo=20, empIsPermenant=true, empSalary=6000},
    new Employee(){ empNo=107, empName="Leo",  empDepartmentNo=40, empIsPermenant=true, empSalary=7000},
    new Employee(){ empNo=108, empName="Paris",  empDepartmentNo=40, empIsPermenant=false, empSalary=8000},
    new Employee(){ empNo=109, empName="Shaggy",  empDepartmentNo=10, empIsPermenant=true, empSalary=9000},
    new Employee(){ empNo=110, empName="Enrique",  empDepartmentNo=10, empIsPermenant=true, empSalary=10000},
    new Employee(){ empNo=111, empName="Micheal",  empDepartmentNo=20, empIsPermenant=false, empSalary=11000},
    new Employee(){ empNo=112, empName="Shakira",  empDepartmentNo=20, empIsPermenant=true, empSalary=12000},
    new Employee(){ empNo=113, empName="Drew Berry",  empDepartmentNo=40, empIsPermenant=true, empSalary=13000},
    new Employee(){ empNo=114, empName="Monica",  empDepartmentNo=30, empIsPermenant=true, empSalary=14000},
    new Employee(){ empNo=115, empName="Chandler",  empDepartmentNo=20, empIsPermenant=false, empSalary=15000},
    new Employee(){ empNo=116, empName="Steffy",  empDepartmentNo=30, empIsPermenant=true, empSalary=16000},
    new Employee(){ empNo=117, empName="Tim",  empDepartmentNo=20, empIsPermenant=true, empSalary=17000},
    new Employee(){ empNo=118, empName="Charlie",  empDepartmentNo=40, empIsPermenant=true, empSalary=18000},
    new Employee(){ empNo=119, empName="Clara",  empDepartmentNo=40, empIsPermenant=false, empSalary=19000},
    new Employee(){ empNo=120, empName="Anthony",  empDepartmentNo=40, empIsPermenant=false, empSalary=20000},

};


// LINQ

//linq starts with var keyword on the left, it is a keyword, not a variable

#region 1 - select all the data
//this is select * from source (select all the records from source)
// var emp = from e in eList
//             //sort syntax
//             //filter syntax
//             //groupby syntax
//             //calcuations
//             //conditions
//             select e;

//     foreach (var item in emp)
//     {
//         Console.WriteLine(item.empName);
//     }
#endregion

#region  2 - select employees with empno > 115
// var emp = from e in eList
//             where e.empNo > 115
//             select e;

// foreach(var item in emp)
// {
//     Console.WriteLine(item.empNo + " " + item.empName);
// }

#endregion

#region 3 - select employees with Permenant position
// var emp = from e in eList
//             where e.empIsPermenant == true
//             select e;

// foreach (var item in emp)
// {
//     Console.WriteLine(item.empNo + " " + item.empName + " " + item.empIsPermenant);
// }

#endregion

#region  4 - select employee where empno deptno = 20 and salary > 12000

// var emp = from e in eList
//             where e.empDepartmentNo == 20 && e.empSalary > 8000
//             select e;

// foreach(var item in emp)
// {
//     Console.WriteLine(item.empNo + " " + item.empDepartmentNo + " " + item.empSalary);    
// }


#endregion

#region 5 - select employees whoes name starts with M


// var emp = from e in eList
//             where e.empName.StartsWith("Ma")
//             select e;

// foreach(var item in emp)
// {
//     Console.WriteLine(item.empName);
// }


#endregion

#region 6 - sort the data - by default ascending sort and use "descending" if you need output in reverse order

// var emp = from e in eList           
//           orderby e.empName descending
//           select e;

// foreach (var item in emp)
// {
//     Console.WriteLine(item.empNo + " " + item.empName);
// }

#endregion

#region 7 - filter and sort together

    // var emp = from e in eList
    //             where e.empDepartmentNo > 20
    //             orderby e.empDepartmentNo
    //             select e;

    // foreach (var item in emp)
    // {
    //     Console.WriteLine(item.empName + " " + item.empDepartmentNo);
    // }


#endregion

#region 8 - give me total employees

// var totalemp = (from e in eList
//                 where e.empIsPermenant == true && e.empDepartmentNo == 20
//                 select e.empNo).Count();

// Console.WriteLine("Total Employees are : " + totalemp);


#endregion