using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IBankTellerServices
    {
        public dynamic CreateBankAccount();
        public dynamic ViewTransaction();
        public dynamic DeactivateAccount();
    }
}
