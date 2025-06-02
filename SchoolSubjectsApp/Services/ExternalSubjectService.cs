using SchoolSubjectsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Services
{
    public class ExternalSubjectService : IExternalSubjectService
    {
        private readonly HttpClient _httpClient;
        private readonly string _gistUrl = "https://gist.githubusercontent.com/marijaeft/6ab7366ca04dd50af2033829ad114a9d/raw/external-subjects.json";

        public ExternalSubjectService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ISubject>> GetExternalSubjectsAsync()
        {
            var response = await _httpClient.GetStringAsync(_gistUrl);
            var externalSubjects = JsonSerializer.Deserialize<List<RawSubject>>(response);

            var result = new List<ISubject>();
            foreach (var sub in externalSubjects)
            {
                result.Add(new BaseSubject(sub.Name, sub.Description, sub.WeeklyClasses, sub.Literature));
            }

            return result;
        }

        private class RawSubject
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int WeeklyClasses { get; set; }
            public List<string> Literature { get; set; }
        }
    }
}
