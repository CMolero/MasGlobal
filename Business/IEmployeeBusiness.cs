using MasGlobal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobal.Business
{
    public interface IEmployeeBusiness
    {
        Task<List<IEmployeeDto>> GetEmployee();
    }
}
