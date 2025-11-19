namespace E_Learning.Core.Entities.CourseEntities
{
    public class Content : BaseEntity
    {
         
        public string File_Path { get; set; }

        public string Content_Type { get; set; }

        public string Title { get; set; }

        public int LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }

    }
}
