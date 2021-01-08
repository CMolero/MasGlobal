using MasGlobal.Entities;
using System.Linq;

namespace MasGlobal.Models
{
    public class EmployeeDto : IEmployeeDto
    {
        private string ContractTypeN;
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get
            {
                return new string(ContractTypeN.SelectMany((c, i) => i > 0 && char.IsUpper(c) ? new[] { ' ', c } : new[] { c }).ToArray());
            }
            set
            {
                ContractTypeN = value;
            }
        }
        public RoleDto Role { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnnualSalary { get; set; }
    }
}
