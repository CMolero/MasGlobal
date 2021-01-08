using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MasGlobal.Entities;
using Newtonsoft.Json;

namespace MasGlobal.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
            _ = GetEmployee();
        }
        private HttpClient httpClient = new HttpClient();
        public async Task<List<Employee>> GetEmployee()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            List<Employee> result = new List<Employee>();

            using (httpClient)
            {
                using (var response = await httpClient.GetAsync("https://masglobaltestapi.azurewebsites.net/api/Employees"))
                {
                    string requestResult = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Employee>>(requestResult);
                }
            }
            return result;
        }
    }
}
