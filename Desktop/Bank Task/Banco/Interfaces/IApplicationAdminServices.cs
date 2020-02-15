using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IApplicationAdminServices
    {
        public dynamic RegisterBank();
        public dynamic DeactivateBank();
        public dynamic ViewAllTransactions();
    }
}
