
namespace FullStackProject.Models
{
    public interface IEmployeeReposiory
    {
        
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int Id);
        Employee Add(Employee employee);
    }
}
