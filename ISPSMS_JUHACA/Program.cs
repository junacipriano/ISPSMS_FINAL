using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Infastructure.Repositories;
using Unity;
using Unity.Lifetime;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace ISPSMS_JUHACA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Setup Dependency Injection with Unity
            IUnityContainer UnityC = new UnityContainer();
            UnityC.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            UnityC.RegisterType<IConnectedSubscribersRepository, ConnectedSubscribersRepository>(new HierarchicalLifetimeManager());

            // Enable high DPI settings for better UI scaling
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create database context and repositories
            var dbContext = new AppDbContext(new DbContextOptions<AppDbContext>());
            var accountsRepository = new AccountsRepository(dbContext);
            var unitOfWork = new UnitOfWork(dbContext);

            // Initialize Login Form with Presenter
            var loginForm = new LoginForm(unitOfWork);
            new LoginPresenter(loginForm, unitOfWork, accountsRepository);

            // Run the application
            Application.Run(loginForm);
        }
    }
}
