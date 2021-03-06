﻿using System.Collections.ObjectModel;
using System.Collections.Specialized;
using TonerCartridgeApp.Model;
using TonerCartridgeApp.UI.Data;
using TonerCartridgeApp.UI.Annotations;

namespace TonerCartridgeApp.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IAppUserDataService _appUserDataService;
        private UserInfo _selecAppUser;

        public MainViewModel(IAppUserDataService appUserDataService)
        {
            AppUsers = new ObservableCollection<UserInfo>();
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

        public ObservableCollection<UserInfo> AppUsers { get; set; }


        public UserInfo SelectedAppUser
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
