using Day8.Models;

namespace Day8.Reposiotries
{
    public interface IEmployeeRepo
    {
        int Add(Employee employee);
        int Delete(int id);
        int Edit(Employee employee);
        List<Employee> GetAll();
        Employee GetById(int id);
    }
}