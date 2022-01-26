namespace CoreSchool.Entities
{
    public class Student
    {
        public string? Name { get; set; }=default;
        public string? UniqueId { get; private set; }=default;
        public ScheduleType Schedule { get; set; }
        public List<Exam> Exams { get; set; }
        public Student(){
            Exams=new List <Exam>(){};
            UniqueId=Guid.NewGuid().ToString();} 
        

    }
}