// See https://aka.ms/new-console-template for more information
using CoreSchool;
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;
namespace Stage1
{
    class Program
    {
        static void Main(string[] args)
        {
           var engine=new SchoolEngine();
           engine.Init();
           Printer.WriteTitle("WELCOME TO SCHOOL");
           Printer.Beep_(1000,200,10);//Doesn't work in WSL WINDOWS SUBSYSTEM FOR LINUX
           printSchoolsCourses_(engine.School);

        }

        private static void printSchoolsCourses_(School school)
        {
            
            Printer.WriteTitle($"Those are the course in the {school.Name}");
           

            if (school?.Courses != null)
            {
                foreach (var course in school.Courses)
                {
                    WriteLine($"Course: {course.Name} Id: {course.UniqueId}");
                }
            }

            else
            {
                WriteLine("Dont exist courses");
            }
        }


    }
}

