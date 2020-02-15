using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class ApplicationAdmin:User
    {
        public List<Transaction> ListOfTransactions { get; set; }
        public List<Bank> listOfBanks { get; set; }
    }
}
