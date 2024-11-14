using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balancemaster.services.Models;

public class Account
{
    public int Id { get; set; }

    public string Iban { get; set; }

    public string Currency { get; set; }

    public decimal Balance { get; set; }

    public int CustomerId { get; set; }

    public Overdraft Overdraft { get; set; }

    public decimal GetBalance()
    {
        if (Overdraft == null)
        {
            return Balance;
        }
        return Balance + Overdraft.Amount;
    }
}
