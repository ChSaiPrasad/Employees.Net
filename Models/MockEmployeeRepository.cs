namespace FullStackProject.Models
{
    public class MockEmployeeRepository : IEmployeeReposiory
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Email = "Mary@gmail.com", Department = Dept.HR },
                new Employee() { Id = 2, Name = "John", Email = "jhon@gmail.com", Department = Dept.IT },
                new Employee() { Id = 3, Name = "Sam", Email = "sam@gmail.com", Department = Dept.Payroll }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id); ;
        }
    }
}
