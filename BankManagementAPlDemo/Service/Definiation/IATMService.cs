using BankManagementAPlDemo.Model;

namespace BankManagementAPlDemo.Service.Definiation
{
    public interface IATMService
    {
        //List<ATM> GetAll();
        PagedResult<ATM> GetAll(int pageIndex, int pageSize);

        ATM GetById(int id);
        ATM Update(ATM atm);
        ATM Add(ATM atm);
        bool Delete(int id);
    }
}
