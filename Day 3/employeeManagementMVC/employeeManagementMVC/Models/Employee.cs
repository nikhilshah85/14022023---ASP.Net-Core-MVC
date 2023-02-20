namespace employeeManagementMVC.Models
{
    public class Employee
    {
        public int eId   { get; set; }
        public string eName { get; set; }
        public string eDesignation { get; set; }
        public double eSalary { get; set; }
        public bool eIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ eId=101, eName="Kreena", eDesignation="HR", eIsPermenant=true, eSalary=8000},
            new Employee(){ eId=102, eName="Rohan", eDesignation="Sales", eIsPermenant=true, eSalary=18000},
            new Employee(){ eId=103, eName="Mohan", eDesignation="HR", eIsPermenant=false, eSalary=82000},
            new Employee(){ eId=104, eName="Sohan", eDesignation="HR", eIsPermenant=true, eSalary=28000},
            new Employee(){ eId=105, eName="Arjun", eDesignation="Accounts", eIsPermenant=true, eSalary=6000},
            new Employee(){ eId=106, eName="Prithvi", eDesignation="HR", eIsPermenant=false, eSalary=12000}
        };

        public List<Employee> GetAllEmployee()
        {
            return eList;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = eList.Find(e => e.eId == id);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not found in system");
        }

        public string AddEmployee(Employee newEmp)
        {
            //before adding the new employee, do validation and calculations, also formating
            if (newEmp.eName.Length < 3)
            {
                throw new Exception("Invalid name, please pass name more than 3 characters");
            }
            if (newEmp.eSalary < 5000)
            {
                throw new Exception("Please pass Salary more than 5000");
            }
            eList.Add(newEmp);
            return "Employee Added Successfully";
        }
    }
}










