using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobal.Entities
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployee();
    }
}
