using DemoModels.CustomModels;

namespace BlazorApp1.Services
{
    public interface IEmpService
    {
        Task<List<Employee>> GetEmployees();
        Task<ResponseModel> AddNewEmployee(Employee employee);
        Task<ResponseModel> UpdateEmployee(Employee employee);
        Task<ResponseModel> DeleteEmployee(int employeeId);
    }
}
