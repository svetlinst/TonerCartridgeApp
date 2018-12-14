using System;
using System.Windows;
using System.Windows.Data;
using TonerCartridgeApp.Model;
using TonerCartridgeApp.UI.StartUp;
using TonerCartridgeApp.UI.ViewModel;

namespace TonerCartridgeApp.UI
{

    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }

        private void TerminateApplication(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void DoLogIn(object sender, RoutedEventArgs e)
        {
            
        }

        private void DoLogOut(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserSelectionComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            if(UserSelectionComboBox.Text!="")
            {
                PasswordTextBox.Visibility = Visibility.Visible;
            }
        }

        public bool CheckPassword(string enteredPassword, UserInfo currUser)
        {
            var isCorrect = false;
            var currUserPass = currUser.Password;
            if (enteredPassword == currUserPass)
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var enteredPassword = PasswordTextBox.Text;
            UserInfo currUser = (UserInfo) UserSelectionComboBox.SelectedItem;
            var currUserPass = currUser.Password;
            if (enteredPassword == currUserPass)
            {
                SuccessfulLogIn(currUser);
            }
            else
            {
                WrongPassword();
            }
        }

        public MessageBoxResult WrongPassword()
        {
            ((App)Application.Current).IsConnected = false;
            MessageBoxResult wrongPasswordEntry = MessageBox.Show("Грешна парола! Моля, опитайте отново.","Грешна парола!");
            return wrongPasswordEntry;
        }

        public void SuccessfulLogIn(UserInfo currUser)
        {
            ((App)Application.Current).IsConnected = true;
            PasswordTextBox.Text = null;
            PasswordTextBox.Visibility = Visibility.Hidden;
            UserInfoLabel.Text = $"Потебител: {currUser.UserName}";
        }

        private void LogOutButton_OnClick(object sender, RoutedEventArgs e)
        {
            UserInfoLabel.Text = null;
            ((App)Application.Current).IsConnected = false;

        }
    }
}
