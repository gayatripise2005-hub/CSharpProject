using ProductManagementApi.Entity.Model;
using ProductManagementApi.Service.Implementation;

namespace ProductManagementApi.Service.Definition
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        
        Brand GetById(int id);
       
        Brand Add(Brand brand);
        Brand Update(Brand brand);
        bool Delete(int id);
    }
}


