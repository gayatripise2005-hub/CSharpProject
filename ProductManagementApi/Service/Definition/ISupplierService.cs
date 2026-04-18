using ProductManagementApi.Entity.Model;

namespace ProductManagementApi.Service.Definition
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        Supplier GetById(int id);
        Supplier Add(Supplier supplier);
        Supplier Update(Supplier supplier);
        bool Delete(int id);
    }
}
