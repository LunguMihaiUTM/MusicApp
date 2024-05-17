using MusicApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Entities.User
{
    public class URegData
    {
        public string Email { get; set; }
        public string Credential { get; set; }
        public string Password { get; set; }
        public string RegIp { get; set; }
        public DateTime RegDateTime { get; set; }
        public URole level { get; set; }
    }
}
