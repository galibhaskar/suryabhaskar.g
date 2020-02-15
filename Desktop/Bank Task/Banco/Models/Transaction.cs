using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Transaction
    {
        public string TransactionID { get; set; }
        public string FromAccountID { get; set; }
        public string ToAccountID { get; set; }
        public DateTime TransactionTime { get; set; }
        public int Amount { get; set; }
        public string TransactionStatus { get; set; }
    }
}
