using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Bank
    {
        public string Name { get; set; }
        public string BankID { get; set; }
        public dynamic DiffBankCharges { get; set; }
        public dynamic SameBankCharges { get; set; }
        public List<Account> ListOfBankAccounts { get; set; }
        public List<BankTeller> ListOfBankTellers { get; set; }
        public string BankStatus { get; set; }
    }
}
