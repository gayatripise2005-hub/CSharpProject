
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using BankManagementAPlDemo.Service.Definiation;

namespace BankManagementAPlDemo.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepo _repository;

        public AccountService(IAccountRepo repository)
        {
            _repository = repository;
        }

        
        public PagedResult<Account> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 50)
                pageSize = 50;

            return _repository.GetAll(pageIndex, pageSize);
        }

        public Account GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Account Id");

            var account = _repository.GetById(id);

            if (account == null)
                throw new Exception("Account not found");

            return account;
        }

        public Account Add(Account account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            if (string.IsNullOrWhiteSpace(account.AccountNumber))
                throw new Exception("Account Number is required");

            if (string.IsNullOrWhiteSpace(account.AccountType))
                throw new Exception("Account Type is required");

            if (account.Balance < 0)
                throw new Exception("Balance cannot be negative");

            
            var allAccounts = _repository.GetAll(0, int.MaxValue).Items;

            if (allAccounts.Any(x => x.AccountNumber == account.AccountNumber))
                throw new Exception("Account with same number already exists");

            return _repository.Add(account);
        }

        public Account Update(Account account)
        {
            if (account.AccountId <= 0)
                throw new Exception("Invalid Account Id");

            var existing = _repository.GetById(account.AccountId);

            if (existing == null)
                throw new Exception("Account not found");

            if (string.IsNullOrWhiteSpace(account.AccountNumber))
                throw new Exception("Account Number required");

            if (account.Balance < 0)
                throw new Exception("Invalid Balance");

            return _repository.Update(account);
        }

        public bool Delete(int id)
        {
            var account = _repository.GetById(id);

            if (account == null)
                throw new Exception("Account not found");

            if (account.Balance > 0)
                throw new Exception("Cannot delete account with balance");

            return _repository.Delete(id);
        }
    }
}


