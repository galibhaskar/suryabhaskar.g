using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IBankAdminServices
    {
        public dynamic RegisterBankTeller();
        public dynamic ChangeBankConfig();
        public dynamic RevertTransaction();
    }
}
