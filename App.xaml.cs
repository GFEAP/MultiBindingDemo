using GeeDemos.MultiBinding.ViewModels;
using GeeDemos.MultiBinding.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GeeDemos.MultiBinding
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow();
            var vm = new MainViewModel();
            vm.SetCloseAction(window.Close);
            window.DataContext = vm;

            window.Show();

        }
    }
}
