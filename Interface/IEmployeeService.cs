using EmployeeDetails.Model;

namespace EmployeeDetails.Interface
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployee(Employee employee);
        Task<List<Employee>> GetEmployees();
        Task<bool> RemoveUser(int id);
        Task<Employee> GetEmployeeData(int userid);
        Task<List<Employee>> FetchEmployeesDataByName(string searchValue);
        bool ExportDataGridViewToCSV(DataGridView dgvEmployee);
    }
}
