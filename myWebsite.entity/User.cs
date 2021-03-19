namespace myWebsite.entity
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string ShortAbout { get; set; }
        public UserDetail Details { get; set; }
    }
}