using SchoolSubjectsApp.Models;
using SchoolSubjectsApp.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Services
{
    public class SubjectService
    {

        private readonly ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public List<ISubject> GetAllSubjects()
        {
            return _repository.GetAllSubjects();
        }

        public ISubject GetSubjectByName(string name)
        {
            return _repository.GetAllSubjects()
                .FirstOrDefault(s => s.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
