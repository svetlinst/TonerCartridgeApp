using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TonerCartridgeApp.Model;

namespace TonerCartridgeApp.UI.Data
{
    public class AppUserDataService : IAppUserDataService
    {
        public IEnumerable<AppUser> GetAllAppUsers()
        {
            // TO DO: retrieve the data from the SQL db
            yield return new AppUser {userName = "Pesho", isActive = true};
            yield return new AppUser { userName = "Gosho", isActive = true };
            yield return new AppUser { userName = "Nafarforiy", isActive = false };
        }
    }
}
