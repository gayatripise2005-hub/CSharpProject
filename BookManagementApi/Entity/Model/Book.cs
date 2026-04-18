namespace BookManagementApi.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

    }
}
