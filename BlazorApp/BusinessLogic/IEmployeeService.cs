using DemoModels.CustomModels;
using DemoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployeeService
    {
        List<EmployeeInfo> GetEmployees();
        ResponseModel AddNewEmployee(EmployeeInfo info);
        ResponseModel UpdateEmployee(EmployeeInfo info);
        ResponseModel DeleteEmployee(int employeeId);
    }
}
