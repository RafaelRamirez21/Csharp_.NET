namespace CoreSchool.Entities
{
    public class Subject
    {
        public string? Name { get; set; }=default;
        public string? UniqueId { get; private set; }=default;
        public ScheduleType Schedule { get; set; }
        public Subject()=> UniqueId=Guid.NewGuid().ToString();
        
    }
}