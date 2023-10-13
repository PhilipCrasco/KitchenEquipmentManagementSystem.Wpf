
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Command.LoginCommand;
using Wpf.Services;
using Wpf.Services.Unitofwork;
using Wpf.View.Login;
using Wpf.View.Registration;
using Wpf.ViewModel;
using Wpf.ViewModel.Login;

namespace Wpf.Hosting
{
    public class DependencyConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DevConnection");

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.UseSnakeCaseNamingConvention();

            }, ServiceLifetime.Scoped);


            services.AddScoped<MainWindow>();
            services.AddScoped<LoginView>();
            services.AddScoped<RegistrationView>();


            services.AddScoped<LoginViewModel>();
            services.AddScoped<MainWindowViewModel>();


            services.AddScoped<IUnitofwork, Unitofwork>();





        }

    }
}
