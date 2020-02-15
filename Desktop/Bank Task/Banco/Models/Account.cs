using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Account
    {
        public string AccountID { get; set; }
        public int Amount { get; set; }
        public int Pin { get; set; }
        public string AccountStatus { get; set; }
    }
}
