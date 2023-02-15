namespace employeeMangementMVC.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

      static  List<Employee> eList = new List<Employee>()
        {
            new Employee() { empNo=101, empName="Akshay", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new Employee() { empNo=102, empName="Rahul", empDesignation="Sales", empIsPermenant=true, empSalary=15000},
            new Employee() { empNo=103, empName="Priya", empDesignation="HR", empIsPermenant=false, empSalary=25000},
            new Employee() { empNo=104, empName="Riya", empDesignation="Accounts", empIsPermenant=true, empSalary=35000},
        };
        public List<Employee> GetAllEmployees()
        {
            return eList;
        }
        public string AddNewEmployee(Employee newEmpObj)
        {
            eList.Add(newEmpObj);
            return "Employee Added Successfully";
        }

        public string DeleteEmployee(int empNo)
        {
            var emp = eList.Find(e => e.empNo == empNo);
            eList.Remove(emp);
            return "Employee Deleted Successfully";
        }

        





    }
}
