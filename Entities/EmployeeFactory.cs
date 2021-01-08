using MasGlobal.Models;
using System;

namespace MasGlobal.Entities
{
    public class EmployeeFactory
    {
        public EmployeeFactory() { }
        public IEmployeeDto EmployeeCreate(Employee employee)
        {
            var contractType = Enum.Parse(typeof(ContractType), employee.ContractTypeName);
            var employeeDto = new EmployeeDto
            {
                Name = employee.Name,
                Id = employee.Id,
                ContractTypeName = employee.ContractTypeName,
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary,
                Role = new RoleDto
                {
                    RoleId = employee.RoleId,
                    RoleName = employee.RoleName,
                    RoleDescription = employee.RoleDescription
                }
            };
            switch (contractType)
            {
                case ContractType.HourlySalaryEmployee:
                    employeeDto.AnnualSalary = 120 * employee.HourlySalary * 12;
                    break;
                case ContractType.MonthlySalaryEmployee:
                    employeeDto.AnnualSalary = employee.MonthlySalary * 12;
                    break;
            }
            return employeeDto;
        }
    }
}
