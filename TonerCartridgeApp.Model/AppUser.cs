using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonerCartridgeApp.Model
{
    public class AppUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public int AccessLevel { get; set; }
        public string Password { get; }
    }
}
