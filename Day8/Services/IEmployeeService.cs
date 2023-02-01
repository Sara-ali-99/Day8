using Day8.Models;
using Day8.ViewModel;

namespace Day8.Services
{
    public interface IEmployeeService
    {
        int Add(Employee employeevm);
        int Delete(int id);
        int Edit(EmployeeVM employeevm);
        List<EmployeeVM> GetAll();
        EmployeeVM GetById(int id);
    }
}