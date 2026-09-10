using System.Text.Json;
using System.Text.Json.Serialization;

namespace EmpManagement
{
    
    class Employee
    {
        [JsonRequired]
        public int empNo { get; set; }
        public string empName { get; set; } = "";
        [JsonPropertyName("MonthlyPay")]        
        public double empSalary { get; set; }

        [JsonPropertyName("Permenant")]
        public bool empIsActive { get; set; } 
        public int empAvailableLeave { get; set; }

        [JsonIgnore]
        public string empPassword { get; set; } //but this should not be saved in a file, it very risky

        public double AppriseSalary()
        {
            empSalary = empSalary + 2000;
            return empSalary;
        }

        public int ApplyLeave(int days)
        {
            if(days > 5)
            {
                throw new Exception("Sorry cannot apply for more than 5 days");
            }
            empAvailableLeave = empAvailableLeave - days;
            return empAvailableLeave;
        }

        public string SaveObject()
        {

            var options = new JsonSerializerOptions()
            {
                 PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                 WriteIndented = true,
                 PropertyNameCaseInsensitive = true

            };

            //save this object
            string data =  JsonSerializer.Serialize(this,options);
            File.WriteAllText(this.empNo + ".json",data);
            return "Object Saved";
        }

        public static Employee LoadObject()
        {
            string details = File.ReadAllText("101.json");
            Employee emp = JsonSerializer.Deserialize<Employee>(details);
            return emp;

        }
    }
}
