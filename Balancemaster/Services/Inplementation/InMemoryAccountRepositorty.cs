using Balancemaster.services.Models;
using Balancemaster.services.Services.Abstractions;

namespace Balancemaster.services.Services.Inplementation;

public class InMemoryAccountRepositorty : IAccountRepository
{

    private readonly List<Account> _accounts;


    public InMemoryAccountRepositorty()
    {
        _accounts = new List<Account> {
            new Account
            {
                Id = 1,
                Currency = "GEL",
                Balance = 100.53m,
                Iban = "GE29715525811266369343",
                CustomerId = 1,
                Overdraft = new Overdraft()
                {
                    Amount =50m,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddMonths(1),
                }
            },
            new Account
            {
                Id = 2,
                Currency = "USD",
                Balance = 1030.53m,
                Iban = "GE29715725811267383343",
                CustomerId = 2,
                Overdraft = new Overdraft()
                {
                    Amount =50m,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddMonths(1),
                }
            }
        };
    }
    public Account GetById(int id)
    {
        return _accounts.FirstOrDefault(account => account.Id == id);

    }
    public void SaveAccount(Account account)
    {
        //We haven`t base
    }
}
