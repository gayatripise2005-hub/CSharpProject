
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class TransactionRepo : ITransactionRepo
    {
        private static List<Transaction> transactions = new List<Transaction>();

        
        public PagedResult<Transaction> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = transactions.Count;

            var items = transactions
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<Transaction>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }

        public Transaction GetById(int id)
        {
            return transactions.FirstOrDefault(x => x.TransactionId == id);
        }

        public Transaction Add(Transaction transaction)
        {
            transaction.TransactionId = transactions.Count + 1;
            transaction.TransactionDate = DateTime.Now;
            transactions.Add(transaction);
            return transaction;
        }

        public Transaction Update(Transaction transaction)
        {
            var existing = transactions.FirstOrDefault(x => x.TransactionId == transaction.TransactionId);

            if (existing != null)
            {
                existing.TransactionType = transaction.TransactionType;
                existing.TransactionDate = transaction.TransactionDate;
            }

            return existing;
        }

        public bool Delete(int id)
        {
            var transaction = transactions.FirstOrDefault(x => x.TransactionId == id);

            if (transaction != null)
            {
                transactions.Remove(transaction);
                return true;
            }

            return false;
        }
    }
}