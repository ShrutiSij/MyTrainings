﻿using System.Windows;
using System.Windows.Threading;

namespace WPFMVVMPersonList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            //Views.MainView view = new Views.MainView();
            //view.DataContext = new ViewModels.PersonViewModel();
            //view.Show();
        }

        private void APP_DispatcherUnhandledException(object sender,
            DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }
    }
}