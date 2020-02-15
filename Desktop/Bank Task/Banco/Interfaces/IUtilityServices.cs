using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IUtilityServices
    {
        public dynamic ValidateUser(dynamic credentials,string role);
        public dynamic GenerateSecretKey();
        public dynamic ValidateSecretKey();
        public dynamic GeneratePin();
        public dynamic ValidatePin();
        public dynamic GenerateBankID();
        public dynamic GenerateAccountID();
        public dynamic GenerateTransactionID();
    }
}
