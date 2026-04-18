namespace BookManagementApi.Entity.Model
{
    public class Review : BaseEntity
    {
        public int BookId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
