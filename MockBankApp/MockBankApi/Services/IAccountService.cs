using MockBankApi.Models;

namespace MockBankApi.Services
{
    public interface IAccountService
    {
        List<Staging> GetAccountService(AccountDateParameter daterange);
        Staging GetAccountById(int stagingId);
    }
}
