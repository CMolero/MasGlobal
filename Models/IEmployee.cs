using MasGlobal.Models;

namespace MasGlobal.Entities
{
    public interface IEmployeeDto
    {
        int Id { get; set; }
        string Name { get; set; }
        string ContractTypeName { get; set; }
        RoleDto Role { get; set; }
        decimal HourlySalary { get; set; }
        decimal MonthlySalary { get; set; }
        decimal AnnualSalary { get; set; }
    }
}
