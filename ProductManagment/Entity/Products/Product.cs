namespace ProductManagment.Entity.Products
{
    public class Product : BaseEntity, ISoftDeleted
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
