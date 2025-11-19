namespace E_Learning.Core.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string LinkedInProfile { get; set; }

        public string FacebookProfile { get; set; }

        public string TwitterHandle { get; set; }

    }
}
