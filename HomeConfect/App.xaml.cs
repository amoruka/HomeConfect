using Abstractions.Commands;
using Abstractions.Queries;

using HomeConfect.Domain.Services.Products;
using HomeConfect.Domain.Services.Recipes;
using HomeConfect.Domain.Services.Scales;
using HomeConfect.Storage;
using HomeConfect.Storage.Commands;
using HomeConfect.Storage.Queries;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.IO;
using System.Windows;

namespace HomeConfect
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // ...
            services.AddDbContext<Context>(options => options.UseSqlite(Configuration.GetConnectionString("HomeConfect")));

            services.AddSingleton<ICommandFactory, CommandFactory>();
            services.AddScoped<ICommandBuilder, DefaultCommandBuilder>();

            services.AddSingleton<IQueryFactory, QueryFactory>();
            services.AddScoped(typeof(IQueryFor<>), typeof(DefaultQueryFor<>));
            services.AddScoped<IQueryBuilder, DefaultQueryBuilder>();

            // Domain services
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IScaleService, ScaleService>();

            services.AddTransient(typeof(MainWindow));
        }
    }
}
