using SkycoreHRM.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SkycoreHRM.Server.Services
{
    public class DepartmentDataService : IDepartmentDataService
    {
        private readonly HttpClient _httpClient;
        public DepartmentDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return
                await JsonSerializer.DeserializeAsync<IEnumerable<Department>>(
                    await _httpClient.GetStreamAsync("api/department"),
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );
        }
    }
}
