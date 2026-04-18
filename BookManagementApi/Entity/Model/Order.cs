namespace BookManagementApi.Entity
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string BookTitle { get; set; }

    }
}
