using CoreSchool.Entities;
using System.Linq;
namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
        }

        public void Init()
        {
            School = new School("Academy", 2021, SchoolTypes.kinderGarden,
                             country: "Canadá", city: "Barranquilla");
            LoadCourse();
            LoadSubjects();
            LoadExam();

        }

        private void LoadExam()
        {
            foreach (var course in School.Courses)
            {
                foreach (var subject in course.Subjects)
                {

                    foreach (var student in course.Students)
                    {
                        var rnd=new Random(System.Environment.TickCount);
                       
                        for (int i = 0; i < 5; i++)
                        {
                            var grade= new Exam {
                                Grade=(float)(5*rnd.NextDouble()),
                                Subject=subject,//new Subject(){Name=subject.Name},
                                Name=$"{subject.Name} No. {i}",
                                Student=student
                                };
                            student.Exams.Add(grade);
                        }
                        // var gradeList = new List<Exam>(){
                               

                        //         };
                        // student.Exams = gradeList;


                    }


                }
            }
        }

        private void LoadSubjects()
        {
            foreach (var course in School.Courses)
            {
                var SubjectList = new List<Subject>(){
                        new Subject{Name="Math"},
                        new Subject{Name="Sports"},
                        new Subject{Name="Lenguage"},
                        new Subject{Name="Math"},
                };
                course.Subjects = SubjectList;
            }
        }

        private List<Student> GenerateStudents(int qty)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var StudentsList = from n1 in name1
                               from n2 in name2
                               from a1 in lastname1
                               select new Student { Name = $"{n1} {n2} {a1}" };
            return StudentsList.OrderBy((st1) => st1.UniqueId).Take(qty).ToList();
        }

        private void LoadCourse()
        {
            School.Courses = new List<Course>(){
                new Course() { Name = "101" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "102" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "103" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "301" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "302" , Schedule=ScheduleType.AtAfternoon},
                new Course() { Name = "303" , Schedule=ScheduleType.AtAfternoon},
            };

            Random random = new Random();
            foreach (var course in School.Courses)
            {
                int randomQty = random.Next(5, 20);
                course.Students = GenerateStudents(randomQty);
            }
        }
    }
}