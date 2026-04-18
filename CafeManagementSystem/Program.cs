using CafeManagementSystem.OperationHandler;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            CrudHandler handler = new CrudHandler();
            await handler.Start();
        }
    }
}