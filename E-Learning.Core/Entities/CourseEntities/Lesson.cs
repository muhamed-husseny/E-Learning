namespace E_Learning.Core.Entities.CourseEntities
{
    public class Lesson : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }

        public virtual ICollection<Content> Contents { get; set; } = new HashSet<Content>();
    }
}
