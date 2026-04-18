using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface IBranchService
    {
        //List<Branch> GetAll();
        PagedResult<Branch> GetAll(int pageIndex, int pageSize);
        Branch GetById(int id);
        Branch Add(Branch branch);
        Branch Update(Branch branch);
        bool Delete(int id);
    }
}
