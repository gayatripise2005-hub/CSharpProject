using ProductManagment.Model__DTO;

namespace ProductManagment.Service.Products
{
    public interface IProductService
    {
        Task<bool> AddProductWithImage(ProductCreateUpdateDto productDto);
        Task<bool> DeleteProductWithImage(long id);
         Task<bool> UpdateProductWithImage(long id, ProductCreateUpdateDto productDto);
         //Task<ProductReadDto?> GetProductById(long id);
         //Task<IEnumerable<ProductReadDto>> GetAllProducts(int page = 1, int pageSize = 10);
    }
}
