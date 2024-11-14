using Balancemaster.services.Models;

namespace Balancemaster.services.Services;

public interface IAccountRepository
{
    Account GetById(int id);
    void SaveAccount(Account account);
}
