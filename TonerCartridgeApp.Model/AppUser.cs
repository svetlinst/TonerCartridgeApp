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
        public string userName { get; set; }
        public bool isAdmin { get; set; }
        public bool isActive { get; set; }
    }
}
