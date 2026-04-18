namespace OrderManagementApi.Entity.model
{
    public class Order : BaseEntity
            {
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        

    }
}
