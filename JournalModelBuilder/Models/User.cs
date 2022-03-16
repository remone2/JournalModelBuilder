namespace JournalModelBuilder.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Journal> OwnJournals { get; set; }
        public int EditJournalId { get; set; }
        public Journal EditJournal { get; set; }
        public User()
        {
            OwnJournals = new HashSet<Journal>();
        }
    }
}
