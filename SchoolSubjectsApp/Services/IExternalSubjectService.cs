using SchoolSubjectsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Services
{
    public interface IExternalSubjectService
    {
        Task<List<ISubject>> GetExternalSubjectsAsync();
    }
}
