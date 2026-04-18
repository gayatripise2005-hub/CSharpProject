using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface IAccountRepo
    {
        //List<Account> GetAll();
        PagedResult<Account> GetAll(int pageIndex, int pageSize);
        Account GetById(int id);
        Account Add(Account account);
        bool Delete(int id);
        Account Update(Account account);



    }
}
