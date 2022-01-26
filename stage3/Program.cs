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
            school.SchoolType = SchoolTypes.Primary;

            school.Courses= new List<Course>(){
                new Course() { Name = "101" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "102" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "103" , Schedule=ScheduleType.AtAfternoon},
            };
            school.Courses.Add(new Course(){Name="201",Schedule=ScheduleType.AtMorning});
            school.Courses.Add(new Course(){Name="202",Schedule=ScheduleType.AtMorning});


            var otherCollection=new List<Course>(){
                new Course() { Name = "301" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "302" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "303" , Schedule=ScheduleType.AtAfternoon},
            };
            Course tmp=new Course() { Name = "101-Vacacional" , Schedule=ScheduleType.AtNight};
            school.Courses.AddRange(otherCollection);
            school.Courses.Add(tmp);
            printSchoolsCourses(school);
            // school.Courses.Remove(tmp);
            // WriteLine("deleted"+ tmp.GetHashCode());
            
            school.Courses.RemoveAll(delegate (Course course)
                                    {
                                        return course.Name=="301";
                                    });
            school.Courses.RemoveAll((course)=> course.Name=="302");
            printSchoolsCourses(school);

        }

        // private static bool Predicado(Course curobj)
        // {
        //     return curobj.Name=="301";
        // }

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

