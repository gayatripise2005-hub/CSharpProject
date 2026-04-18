using ProductManagment.Entity;

namespace ProductManagment.Model__DTO
{
    public class ProductCreateUpdateDto : BaseEntity
    {
        public string  Name { get; set; }
        public string  CategoryName { get; set; }
        public IFormFile[] Image { get; set; }
        public decimal Price { get; set; }
    }
}
