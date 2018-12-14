using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonerCartridgeApp.UI.StartUp
{
    public class AppState
    {
        public bool IsLoggedIn { get; set; }

        public AppState()
        {
            this.IsLoggedIn = false;
        }
    }
}
