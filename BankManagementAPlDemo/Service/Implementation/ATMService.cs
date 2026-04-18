
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using BankManagementAPlDemo.Service.Definiation;

namespace BankManagementAPlDemo.Service.Implementation
{

    public class ATMService : IATMService
    {
        private readonly IATMRepo _repository;

        public ATMService(IATMRepo repository)
        {
            _repository = repository;
        }

        
        public PagedResult<ATM> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 50)
                pageSize = 50;

            return _repository.GetAll(pageIndex, pageSize);
        }

        public ATM GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid ATM Id");

            var atm = _repository.GetById(id);

            if (atm == null)
                throw new Exception("ATM not found");

            return atm;
        }

        public ATM Add(ATM atm)
        {
            if (atm == null)
                throw new ArgumentNullException(nameof(atm));

            if (string.IsNullOrWhiteSpace(atm.Location))
                throw new Exception("Location is required");

            if (atm.CashAvailable < 0)
                throw new Exception("Invalid cash amount");

            
            var all = _repository.GetAll(0, int.MaxValue).Items;

            if (all.Any(x => x.Location.ToLower() == atm.Location.ToLower()))
                throw new Exception("ATM already exists at this location");

            return _repository.Add(atm);
        }

        public ATM Update(ATM atm)
        {
            if (atm.ATMId <= 0)
                throw new Exception("Invalid ATM Id");

            var existing = _repository.GetById(atm.ATMId);

            if (existing == null)
                throw new Exception("ATM not found");

            return _repository.Update(atm);
        }

        public bool Delete(int id)
        {
            var atm = _repository.GetById(id);

            if (atm == null)
                throw new Exception("ATM not found");

            if (atm.CashAvailable > 0)
                throw new Exception("Cannot delete ATM with cash");

            return _repository.Delete(id);
        }
    }
}