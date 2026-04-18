using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using BankManagementAPlDemo.Service.Definiation;

namespace BankManagementAPlDemo.Service.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepo _repository;

        public TransactionService(ITransactionRepo repository)
        {
            _repository = repository;
        }

      
        public PagedResult<Transaction> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 50)
                pageSize = 50;

            return _repository.GetAll(pageIndex, pageSize);
        }

        public Transaction GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Transaction Id");

            var transaction = _repository.GetById(id);

            if (transaction == null)
                throw new Exception("Transaction not found");

            return transaction;
        }

        public Transaction Add(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            if (string.IsNullOrWhiteSpace(transaction.TransactionType))
                throw new Exception("Transaction type required");

            

            if (transaction.TransactionDate == default)
                transaction.TransactionDate = DateTime.Now;

            return _repository.Add(transaction);
        }

        public Transaction Update(Transaction transaction)
        {
            if (transaction.TransactionId <= 0)
                throw new Exception("Invalid Id");

            var existing = _repository.GetById(transaction.TransactionId);

            if (existing == null)
                throw new Exception("Transaction not found");

            return _repository.Update(transaction);
        }

        public bool Delete(int id)
        {
            var transaction = _repository.GetById(id);

            if (transaction == null)
                throw new Exception("Transaction not found");

            return _repository.Delete(id);
        }
    }
}