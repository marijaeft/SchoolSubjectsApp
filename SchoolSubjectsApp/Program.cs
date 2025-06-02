using SchoolSubjectsApp.Models;
using SchoolSubjectsApp.Repositories.Implementation;
using SchoolSubjectsApp.Repositories.Interface;
using SchoolSubjectsApp.Services;

namespace SchoolSubjectsApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ISubjectRepository subjectRepo = new SubjectRepositoryImpl("subjects.json");
            IExternalSubjectService externalService = new ExternalSubjectService();

            var allSubjects = subjectRepo.GetAllSubjects();

            while (true)
            {
                Console.WriteLine("\nAvailable Subjects:");
                DisplaySubjects(allSubjects);

                Console.Write("\nType a subject name for details, or type 'more' to fetch additional subjects: ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "more", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Fetching additional subjects...");
                    var extraSubjects = await externalService.GetExternalSubjectsAsync();
                    allSubjects.AddRange(extraSubjects
                        .Where(e => !allSubjects.Any(s => s.Name.Equals(e.Name, StringComparison.OrdinalIgnoreCase))));
                }
                else
                {
                    var subject = allSubjects.FirstOrDefault(s => s.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
                    if (subject != null)
                    {
                        Console.WriteLine("\n" + subject.GetSubjectDetails());
                    }
                    else
                    {
                        Console.WriteLine("Subject not found.");
                    }
                }

                Console.Write("\nDo you want to continue? (y/n): ");
                if (!Console.ReadLine().Trim().ToLower().StartsWith("y")) break;
            }

            Console.WriteLine("\nGoodbye!");
        }

        static void DisplaySubjects(List<ISubject> subjects)
        {
            foreach (var subject in subjects)
            {
                Console.WriteLine(subject.GetSubject());
            }
        }
    }
}