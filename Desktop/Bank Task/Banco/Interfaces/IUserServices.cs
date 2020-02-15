using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IUserServices
    {
        public dynamic Login();
        public dynamic UpdateUser();
        public dynamic Logout();
    }
}
