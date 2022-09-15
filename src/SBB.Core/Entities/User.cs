namespace SBB.Core.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int Age { get; set; }

        public User() { }
        public User(string name, string email, string lastName, DateTime createdDate, DateTime lastModifiedDate, int age)
        {
            Name = name;
            Email = email;
            LastName = lastName;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            Age = age;
        }
    }
}