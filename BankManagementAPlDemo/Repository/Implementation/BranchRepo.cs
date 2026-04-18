
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class BranchRepo : IBranchRepo
    {
        private static List<Branch> branches = new List<Branch>();

        
        public PagedResult<Branch> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = branches.Count;

            var items = branches
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<Branch>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }

        public Branch GetById(int id)
        {
            return branches.FirstOrDefault(x => x.BranchId == id);
        }

        public Branch Add(Branch branch)
        {
            branch.BranchId = branches.Count + 1;
            branches.Add(branch);
            return branch;
        }

        public Branch Update(Branch branch)
        {
            var existing = branches.FirstOrDefault(x => x.BranchId == branch.BranchId);

            if (existing != null)
            {
                existing.BranchName = branch.BranchName;
                existing.Location = branch.Location;
            }

            return existing;
        }

        public bool Delete(int id)
        {
            var branch = branches.FirstOrDefault(x => x.BranchId == id);

            if (branch != null)
            {
                branches.Remove(branch);
                return true;
            }

            return false;
        }
    }
}