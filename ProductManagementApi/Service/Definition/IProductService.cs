
using ProductManagementApi.Entity.Model;

namespace ProductManagementApi.Service.Definition
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        bool Delete(int id);
    }
}