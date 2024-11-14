using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balancemaster.services.Exceptions
{
    public class InsufficientFundsException : DomainException
    {
        public InsufficientFundsException(int account): base("insufficient") {
        }
    }
}
