using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning.Core.Entities.CourseEntities
{
    public class Module : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();
    }
}
