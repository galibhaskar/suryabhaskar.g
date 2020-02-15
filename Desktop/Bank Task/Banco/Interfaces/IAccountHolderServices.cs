using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IAccountHolderServices
    {
        public dynamic CashDeposit();
        public dynamic CashWithdrawal();
        public dynamic FundTransfer();
    }
}
