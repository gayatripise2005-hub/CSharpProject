using BookManagementApi.Entity;

namespace BookManagementApi.service.Definition
{
    public interface ICustomerService
    {
        

       
            Task<List<Customer>> GetAll();
            Task<Customer> GetById(int id);
            Task<Customer> Add(Customer customer);
            Task<Customer> Update(Customer customer);
            Task<bool> Delete(int id);
        
    
     }
}
