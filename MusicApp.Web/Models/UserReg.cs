using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicApp.Web.Models
{
    public class UserReg
    {
        public string Email { get; set; }
        public string Credential { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}