using MasGlobal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobal.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<IEmployeeDto>> GetEmployee()
        {
            var employeeFactory = new EmployeeFactory();
            var listEmployees = await _employeeRepository.GetEmployee();
            var listEmployesDto = new List<IEmployeeDto>();

            foreach (var itemEmployee in listEmployees)
            {
                listEmployesDto.Add(employeeFactory.EmployeeCreate(itemEmployee));
            }

            return listEmployesDto;
        }
    }
}
