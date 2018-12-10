using System;
using System.Windows;
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
            throw new NotImplementedException();
        }
    }
}
