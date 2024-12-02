namespace APIwithEntityFrameworkcore.DBModels
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

        //navigating propery
        // a course can have many students 1:M
        public ICollection<Student> Students { get; set; }
    }
}
