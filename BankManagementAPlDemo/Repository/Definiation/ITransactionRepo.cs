using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface ITransactionRepo
    {
        //List<Transaction> GetAll();
        PagedResult<Transaction> GetAll(int pageIndex, int pageSize);

        Transaction GetById(int id);
        Transaction Add(Transaction transaction);
        bool Delete(int id);
        Transaction Update(Transaction transaction);

    }
}
