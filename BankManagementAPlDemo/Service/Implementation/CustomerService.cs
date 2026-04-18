
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using BankManagementAPlDemo.Service.Definiation;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepo _repository;

    public CustomerService(ICustomerRepo repository)
    {
        _repository = repository;
    }

    public PagedResult<Customer> GetAll(int pageIndex, int pageSize)
    {
        if (pageSize > 50)
            pageSize = 50;

        return _repository.GetAll(pageIndex, pageSize);
    }

    public Customer GetById(int id)
    {
        if (id <= 0)
            throw new Exception("Invalid Id");

        var data = _repository.GetById(id);

        if (data == null)
            throw new Exception("Customer not found");

        return data;
    }

    public Customer Add(Customer customer)
    {
        if (string.IsNullOrWhiteSpace(customer.Name))
            throw new Exception("Name required");

        return _repository.Add(customer);
    }

    public Customer Update(Customer customer)
    {
        return _repository.Update(customer);
    }

    public bool Delete(int id)
    {
        return _repository.Delete(id);
    }
}