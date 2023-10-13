using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpf.Hosting;
using Wpf.ViewModel.Login;
using Wpf.ViewModel;
using Wpf.Command.LoginCommand;
using Wpf.Services.Unitofwork;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[]? args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(x =>
                {
                    x.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    DependencyConfiguration.Configure(services, context.Configuration);
             

                });

        }


        protected override void OnStartup(StartupEventArgs e)
        {

            _host.Start();

            //MainWindow = _host.Services.GetRequiredService<MainWindow>();

            //MainWindow.Show();

            var loginViewModel = new LoginViewModel(_host.Services.GetRequiredService<IUnitofwork>());
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.DataContext = loginViewModel;

            MainWindow.Show();


            base.OnStartup(e);



        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }


    }



    
}
