using SchoolSubjectsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Repositories.Interface
{
    public interface ISubjectRepository
    {
        List<ISubject> GetAllSubjects();
    }
}
