namespace E_Learning.Core.Entities.CourseEntities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Module> Modules { get; set; } = new HashSet<Module>();
    }
}
