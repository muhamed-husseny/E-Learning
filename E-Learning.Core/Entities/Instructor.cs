namespace E_Learning.Core.Entities
{
    public class Instructor : BaseEntity
    {
        public string Name { get; set; }

        public string Bio { get; set; }

        public int ExperienceYears { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string ContactEmail { get; set; }

        public string LinkedInProfile { get; set; }

        public string TwitterHandle { get; set; }

    }
}
