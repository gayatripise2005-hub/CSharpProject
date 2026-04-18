namespace OrderManagementApi.Entity.model
{
    public class Invoice : BaseEntity
    {
        public int OrderId { get; set; }
        public decimal FinalAmmount { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
