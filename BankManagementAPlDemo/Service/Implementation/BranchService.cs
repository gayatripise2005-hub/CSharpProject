

using BankManagementAPlDemo.Service.Definiation;
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;

namespace BankManagementAPlDemo.Service.Implementation
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepo _repository;

        public BranchService(IBranchRepo repository)
        {
            _repository = repository;
        }

        
        public PagedResult<Branch> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 50)
                pageSize = 50;

            return _repository.GetAll(pageIndex, pageSize);
        }

        public Branch GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Branch Id");

            var branch = _repository.GetById(id);

            if (branch == null)
                throw new Exception("Branch not found");

            return branch;
        }

        public Branch Add(Branch branch)
        {
            if (branch == null)
                throw new ArgumentNullException(nameof(branch));

            if (string.IsNullOrWhiteSpace(branch.BranchName))
                throw new Exception("Branch Name is required");

            if (string.IsNullOrWhiteSpace(branch.Location))
                throw new Exception("Branch Location is required");

           
            var allBranches = _repository.GetAll(0, int.MaxValue).Items;

            if (allBranches.Any(x =>
                x.BranchName.ToLower() == branch.BranchName.ToLower() &&
                x.Location.ToLower() == branch.Location.ToLower()))
            {
                throw new Exception("Branch already exists");
            }

            return _repository.Add(branch);
        }

        public Branch Update(Branch branch)
        {
            if (branch.BranchId <= 0)
                throw new Exception("Invalid Branch Id");

            var existing = _repository.GetById(branch.BranchId);

            if (existing == null)
                throw new Exception("Branch not found");

            return _repository.Update(branch);
        }

        public bool Delete(int id)
        {
            var existing = _repository.GetById(id);

            if (existing == null)
                throw new Exception("Branch not found");

            return _repository.Delete(id);
        }
    }
}