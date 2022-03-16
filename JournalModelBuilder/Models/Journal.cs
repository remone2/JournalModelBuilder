namespace JournalModelBuilder.Models
{
    public class Journal
    {
        public int JournalId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string OwnerUserId { get; set; }
        public User OwnerUser { get; set; }
        public ICollection<User> EditorUsers { get; set; }
        public Journal()
        {
            EditorUsers = new HashSet<User>();
        }
    }
}
