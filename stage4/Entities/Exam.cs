namespace CoreSchool.Entities
{
    public class Exam
    {
        public string? Name { get; set; }=default;
        public string? UniqueId { get; private set; }=default;
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public ScheduleType Schedule { get; set; }
        public double Grade { get; set; }

        public Exam( ){
    
            UniqueId=Guid.NewGuid().ToString();
        } 
        
    }
}