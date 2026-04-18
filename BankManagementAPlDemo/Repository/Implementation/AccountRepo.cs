
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class AccountRepo : IAccountRepo
    {
        private static List<Account> accounts = new List<Account>();

        public PagedResult<Account> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = accounts.Count;

            var items = accounts
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<Account>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }

        public Account GetById(int id)
        {
            return accounts.FirstOrDefault(x => x.AccountId == id);
        }

        public Account Add(Account account)
        {
            account.AccountId = accounts.Any() ? accounts.Max(x => x.AccountId) + 1 : 1;
            accounts.Add(account);
            return account;
        }

        public Account Update(Account account)
        {
            var existing = accounts.FirstOrDefault(x => x.AccountId == account.AccountId);

            if (existing == null) return null;

            existing.AccountType = account.AccountType;
            existing.AccountNumber = account.AccountNumber;
            existing.Balance = account.Balance;

            return existing;
        }

        public bool Delete(int id)
        {
            var account = accounts.FirstOrDefault(x => x.AccountId == id);

            if (account == null) return false;

            accounts.Remove(account);
            return true;
        }
    }
}