using System.Collections.Generic;
using System.Linq;
using TonerCartridgeApp.Model;

namespace TonerCartridgeApp.UI.Data
{
    public class AppUserDataService : IAppUserDataService
    {
        public IEnumerable<UserInfo> GetAllAppUsers()
        {
            using (var ctx = new TonerCartridgeEntities())
            {
                return ctx.UserInfo.AsNoTracking().Where(u=>u.IsActive == true).ToList();
            }
        }
    }
}
