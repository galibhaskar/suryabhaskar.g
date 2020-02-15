using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface ITransactionServices
    {
        public dynamic AddTransaction();
        public dynamic UpdateTransaction();
    }
}
