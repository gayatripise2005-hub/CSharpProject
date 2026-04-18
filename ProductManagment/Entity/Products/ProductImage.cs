using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagment.Entity.Products
{
    public class ProductImage : BaseEntity
    {
      
        public string ImagePath { get; set; }

        [ForeignKey("Product")]
        public long ProductId { get; set; }
        //navigation property
        public Product Product { get; set; }
    }
}
