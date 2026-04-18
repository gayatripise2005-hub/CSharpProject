using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Repository.Definiation
{
    public interface IATMRepo
    {

    
        PagedResult<ATM> GetAll(int pageIndex, int pageSize);
        ATM GetById(int id);
        ATM Add(ATM atm);
        bool Delete(int id);
        ATM Update(ATM atm);


    }
}
