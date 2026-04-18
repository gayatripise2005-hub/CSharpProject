using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface IBranchRepo
    {
        
        PagedResult<Branch> GetAll(int pageIndex, int pageSize);

        Branch GetById(int id);
        Branch Add(Branch branch);
        bool Delete(int id);
        Branch Update(Branch Branch);
    }
}
