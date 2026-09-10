using System.Reflection;
using System.Runtime.CompilerServices;


var myapp =  Assembly.LoadFile(@"C:\Users\nikhi\OneDrive\Desktop\25082026---.net-fullstack-AI-enabled-Developers\Day 8 - Memory Graph, CLR, GC\bankLIB\bin\Debug\net10.0\bankLIB.dll");

Type[] myClasses = myapp.GetTypes(); //this will give me list of all the classes in that dll

// foreach(var item in myClasses)
// {
//     Console.WriteLine(item.FullName);
// }

// Type myclass = myClasses[4];
// Console.WriteLine(myclass);
// Console.WriteLine("------------------------------------------");

// MethodInfo[] myMethods = myclass.GetMethods();
// foreach(var item  in myMethods)
// {
//     Console.WriteLine(item);
// }


//Types
//MethodInfo
//MemberInfo
//ConstructorInfo
//ParameterInfo
//EventInfo
//EnumInfo
//etc...

 
 var myClass = myClasses[3];


 var obj = Activator.CreateInstance(myClass); //this will crete a new object of myMath

MethodInfo m = myClass.GetMethod("Add");

object[] parameters = new object[]{10,20};

object result =(int)m.Invoke(obj,parameters);

Console.WriteLine(result);