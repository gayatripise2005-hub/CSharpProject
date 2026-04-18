 
using BankManagementAPlDemo.Model;
using BankManagementAPlDemo.Repository.Definiation;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementAPlDemo.Repository.Implementation
{
    public class ATMRepo : IATMRepo
    {
        private static List<ATM> atms = new List<ATM>();

       
        public PagedResult<ATM> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = atms.Count;

            var items = atms
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<ATM>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = items
            };
        }

        public ATM GetById(int id)
        {
            return atms.FirstOrDefault(x => x.ATMId == id);
        }

        public ATM Add(ATM atm)
        {
            atm.ATMId = atms.Count + 1;
            atms.Add(atm);
            return atm;
        }

        public ATM Update(ATM atm)
        {
            var existing = atms.FirstOrDefault(x => x.ATMId == atm.ATMId);

            if (existing != null)
            {
                existing.Location = atm.Location;
                existing.CashAvailable = atm.CashAvailable;
            }

            return existing;
        }

        public bool Delete(int id)
        {
            var atm = atms.FirstOrDefault(x => x.ATMId == id);

            if (atm != null)
            {
                atms.Remove(atm);
                return true;
            }

            return false;
        }
    }
}