using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSubjectsApp.Models
{
    public class BaseSubject : ISubject
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int WeeklyClasses { get; private set; }
        public List<string> Literature { get; private set; }

        public BaseSubject(string name, string description, int weeklyClasses, List<string> literature)
        {
            Name = name;
            Description = description;
            WeeklyClasses = weeklyClasses;
            Literature = literature;
        }
        public string GetSubject()
        {
            return $"Subject: {Name}\n";
        }

        public string GetSubjectDetails()
        {
            return $"Subject: {Name}\nDescription: {Description}\nWeekly Classes: {WeeklyClasses}\nLiterature: {string.Join(", ", Literature)}";
        }

    }
}
