﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class User
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SecretKey { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}
