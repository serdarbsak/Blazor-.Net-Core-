using DemoModels.CustomModels;

namespace BlazorApp1.Services
{
    public class EmpService:IEmpService
    {
        private readonly HttpClient httpClient;
        public EmpService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<List<Employee>>("api/Employee/GetEmployees");
        }

        public async Task<ResponseModel> AddNewEmployee(Employee employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Employee/AddNewEmployee", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

        public async Task<ResponseModel> UpdateEmployee(Employee employee)
        {
            var response = await httpClient.PostAsJsonAsync("api/Employee/UpdateEmployee", employee);
            return await response.Content.ReadFromJsonAsync<ResponseModel>();
        }

        public async Task<ResponseModel> DeleteEmployee(int employeeId)
        {
            return await httpClient.GetFromJsonAsync<ResponseModel>("api/Employee/DeleteEmployee/?employeeId=" + employeeId);
        }

    }
}
