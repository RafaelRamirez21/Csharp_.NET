namespace CoreSchool.Entities
{
    public class Course
    {
        public string? Name { get; set; }=default;
        public string? UniqueId { get; private set; }=default;
        public ScheduleType Schedule { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public Course()
        {
            UniqueId=Guid.NewGuid().ToString();
        }
    }
}