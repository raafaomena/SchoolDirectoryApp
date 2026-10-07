using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services
{
    public class SchoolService
    {
        private readonly HttpClient _http;

        public SchoolService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<School>> GetSchoolsAsync()
        {
            return await _http.GetFromJsonAsync<List<School>>(
                "https://edutots.net/api/school"
            );
        }
    }
}