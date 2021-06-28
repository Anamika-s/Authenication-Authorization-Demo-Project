using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_AuthDemo.Models
{
    public enum Roles {  Admin , EndUser};
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles role { get; set; }
    }
}