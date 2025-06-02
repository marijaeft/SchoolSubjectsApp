using SchoolSubjectsApp.Models;
using SchoolSubjectsApp.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Repositories.Implementation
{
    public class SubjectRepositoryImpl : ISubjectRepository
    {
        private readonly string _filePath;

        public SubjectRepositoryImpl(string filePath)
        {
            _filePath = filePath;
        }

        public List<ISubject> GetAllSubjects()
        {
            if (!File.Exists(_filePath)) return new List<ISubject>();

            var json = File.ReadAllText(_filePath);
            var rawSubjects = JsonSerializer.Deserialize<List<RawSubject>>(json);
            return rawSubjects?.Select(rs =>
                new BaseSubject(rs.Name, rs.Description, rs.WeeklyClasses, rs.Literature)
            ).Cast<ISubject>().ToList() ?? new List<ISubject>();
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
