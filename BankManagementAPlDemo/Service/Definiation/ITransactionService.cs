using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface ITransactionService
    {
        //List<Transaction> GetAll();
        PagedResult<Transaction> GetAll(int pageIndex, int pageSize);

        Transaction GetById(int id);
        
        Transaction Add(Transaction transaction);
        Transaction Update(Transaction transaction);
        bool Delete(int id);
    }
}
