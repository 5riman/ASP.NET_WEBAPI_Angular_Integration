using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_WEBAPI_Angular_Integration.Models; // Assuming Employeemaster is defined in this namespace

namespace ASP.NET_WEBAPI_Angular_Integration.Models
{
  
        public class Login
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Registration : Employeemaster
        {

        }
    
}