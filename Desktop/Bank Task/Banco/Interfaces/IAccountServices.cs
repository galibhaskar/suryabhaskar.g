using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IAccountServices
    {
        public dynamic UpdateBankAccount();
        public dynamic ViewTransactionHistory();
    }
}
