using System.Collections.ObjectModel;
using System.Collections.Specialized;
using TonerCartridgeApp.Model;
using TonerCartridgeApp.UI.Data;
using TonerCartridgeApp.UI.Annotations;

namespace TonerCartridgeApp.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IAppUserDataService _appUserDataService;
        private AppUser _selecAppUser;

        public MainViewModel(IAppUserDataService appUserDataService)
        {
            AppUsers = new ObservableCollection<AppUser>();
            _appUserDataService = appUserDataService;
        }

        public void Load()
        {
            var appUsers = _appUserDataService.GetAllAppUsers();
            AppUsers.Clear();
            foreach (var appUser in appUsers)
            {
                AppUsers.Add(appUser);
            }
        }

        public ObservableCollection<AppUser> AppUsers { get; set; }


        public AppUser SelectedAppUser
        {
            get { return _selecAppUser;}
            set
            {
                _selecAppUser = value; 
                OnPropertyChanged(nameof(SelectedAppUser));
            }
        }

    }
}
