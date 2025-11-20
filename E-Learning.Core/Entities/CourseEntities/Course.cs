namespace E_Learning.Core.Entities.CourseEntities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal price { get; set; }
        public virtual ICollection<Module> Modules { get; set; } = new HashSet<Module>();


        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
