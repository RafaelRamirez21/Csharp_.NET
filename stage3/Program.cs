// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
using static System.Console;
namespace Stage1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            var school = new School("Academy", 2021, SchoolTypes.kinderGarden, country: "Canadá", city: "Barranquilla");
            // school.Name="Academy";
            // school.Country="Colombia";
            // school.City="Barranquilla";
            school.SchoolType = SchoolTypes.Primary;

            var courseList= new List<Course>(){
                new Course() { Name = "101" },
                new Course() { Name = "102" },
                new Course() { Name = "103" },
            };

        
            school.Courses=courseList;
            printSchoolsCourses(school);

        }

        private static void printSchoolsCourses(School school)
        {

            WriteLine("====================");
            WriteLine(school);
            WriteLine("====================");

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

        private static void printCoursesWhile(Course[] coursesArray)
        {
            int counter = 0;
            while (counter < coursesArray.Length)
            {
                WriteLine($"Course: {coursesArray[counter].Name} Id: {coursesArray[counter].UniqueId}");
                counter++;
            }
        }
        private static void printCoursesForEach(Course[] coursesArray)
        {
            foreach (var course in coursesArray)
            {
                WriteLine($"Course: {course.Name} Id: {course.UniqueId}");

            }
        }
    }
}

