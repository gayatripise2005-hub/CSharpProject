using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface IAccountService
    {
        //List<Account> GetAll();
        PagedResult<Account> GetAll(int pageIndex, int pageSize);
        Account GetById(int id);
        Account Add(Account account);
        Account Update(Account account);
        bool Delete(int id);
    }
}
