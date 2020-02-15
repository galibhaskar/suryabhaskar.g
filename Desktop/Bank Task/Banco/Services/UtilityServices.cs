using Banco.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class UtilityServices : IUtilityServices
    {
        public dynamic GenerateAccountID()
        {
            throw new NotImplementedException();
        }

        public dynamic GenerateBankID()
        {
            throw new NotImplementedException();
        }

        public dynamic GeneratePin()
        {
            throw new NotImplementedException();
        }

        public dynamic GenerateSecretKey()
        {
            throw new NotImplementedException();
        }

        public dynamic GenerateTransactionID()
        {
            throw new NotImplementedException();
        }

        public dynamic ValidatePin()
        {
            throw new NotImplementedException();
        }

        public dynamic ValidateSecretKey()
        {
            throw new NotImplementedException();
        }

        public dynamic ValidateUser(dynamic credentials, string role)
        {
            if (role.Equals("Application Admin"))
            {
                if (credentials[0] == "admin" && credentials[1] == "admin" && credentials[2] == "71006")
                    return true;
            }
            return false;
        }
    }
}
