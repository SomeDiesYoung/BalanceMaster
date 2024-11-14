using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balancemaster.services.Commands;
using Balancemaster.services.Exceptions;
using Balancemaster.services.Services.Abstractions;



namespace Balancemaster.services.Services.Inplementation;



public class OperationService
{
    private readonly IAccountRepository _accountRepository;

    public OperationService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public void Execute(DebitCommand command)
    {
        command.Validate();


        var account = _accountRepository.GetById(command.AccountId);

        if (account.GetBalance() < command.Amount) throw new InsufficientFundsException(account.Id);

        account.Balance -= command.Amount;

        _accountRepository.SaveAccount(account);
    }

    public void Execute(CreditCommand command)
    {
        command.Validate();


        var account = _accountRepository.GetById(command.AccountId);

        account.Balance += command.Amount;

        _accountRepository.SaveAccount(account);
    }
}
