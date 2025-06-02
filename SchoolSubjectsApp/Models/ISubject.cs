using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Models
{
    public interface ISubject
    {
        string Name { get; }
        string Description { get; }
        int WeeklyClasses { get; }
        List<string> Literature { get; }
        string GetSubject();
        string GetSubjectDetails();
    }
}
