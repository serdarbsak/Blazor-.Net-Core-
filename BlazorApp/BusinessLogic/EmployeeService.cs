using DemoModels.CustomModels;
using DemoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeService: IEmployeeService
    {
        private readonly EmployeeDBContext _dbContext;
        public EmployeeService(EmployeeDBContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        public List<EmployeeInfo> GetEmployees()
        {
            var data = _dbContext.EmployeeInfos.ToList();
            return data;
        }
        public ResponseModel AddNewEmployee(EmployeeInfo info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _dbContext.EmployeeInfos.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data == null)
                {
                    _dbContext.EmployeeInfos.Add(info);
                    _dbContext.SaveChanges();
                }

                response.Status = true;
                response.Message = "Sucess";
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ResponseModel UpdateEmployee(EmployeeInfo info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _dbContext.EmployeeInfos.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    data.Name = info.Name;
                    data.Company = info.Company;
                    data.Surname = info.Surname;
                    data.Phone = info.Phone; 
                    _dbContext.EmployeeInfos.Update(data);
                    _dbContext.SaveChanges();

                    response.Status = true;
                    response.Message = "Sucess";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Employee Does not exist";
                }

                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ResponseModel DeleteEmployee(int employeeId)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _dbContext.EmployeeInfos.Where(x => x.Id == employeeId).FirstOrDefault();
                if (data != null)
                {
                    _dbContext.EmployeeInfos.Remove(data);
                    _dbContext.SaveChanges();

                    response.Status = true;
                    response.Message = "Sucess";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Employee Does not exist";
                }

                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
