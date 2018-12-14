using System.Collections.Generic;
using TonerCartridgeApp.Model;

namespace TonerCartridgeApp.UI.Data
{
    public interface IAppUserDataService
    {
        IEnumerable<UserInfo> GetAllAppUsers();
    }
}