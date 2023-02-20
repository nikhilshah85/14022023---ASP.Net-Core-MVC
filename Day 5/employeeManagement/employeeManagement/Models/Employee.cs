namespace employeeManagement.Models
{
    public class Employee
    {
        public int eId { get; set; }
        public string eName { get; set; }
        public string eDesignation { get; set; }

        public double eSalary { get; set; }
        public bool eIsPermaenant { get; set; }

        static List<Employee> eLIst = new List<Employee>()
        {
            new Employee(){ eId=101, eName="Sumit", eDesignation="Sales", eIsPermaenant=true, eSalary=10000 },
            new Employee(){ eId=102, eName="Mohan", eDesignation="HR", eIsPermaenant=true, eSalary=10000 },
            new Employee(){ eId=103, eName="Rohan", eDesignation="Sales", eIsPermaenant=true, eSalary=10000 },
            new Employee(){ eId=104, eName="Ramesh", eDesignation="Sales", eIsPermaenant=true, eSalary=10000 }
        };

        public List<Employee> GetALlEmp()
        {
            return eLIst;
        }

       


        public Employee GetEmployeeById(int eno)
        {
            var emp = eLIst.Find(e => e.eId == eno);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not Found");
        }

        public string EditEmployee(Employee changes)
        {
            var emp = eLIst.Find(e => e.eId == changes.eId);
            emp.eName = changes.eName;
            emp.eSalary = changes.eSalary;
            emp.eIsPermaenant = changes.eIsPermaenant;
            emp.eDesignation = changes.eDesignation;
            return "Employee Changed Successfully";
        }





    




    }
}



