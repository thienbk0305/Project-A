using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemoMVC.EntitiesFrameWork.Entites
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}