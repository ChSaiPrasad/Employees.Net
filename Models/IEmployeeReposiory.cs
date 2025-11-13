
namespace FullStackProject.Models
{
    public interface IEmployeeReposiory
    {
        
        IEnumerable<Employee> GetEmployee();
        Employee GetEmployeeById(int Id);
    }
}
