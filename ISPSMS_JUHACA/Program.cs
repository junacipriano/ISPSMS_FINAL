using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Infastructure.Repositories;
using Unity;
using Unity.Lifetime;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.Views;

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
            IUnityContainer UnityC = new UnityContainer();
            UnityC.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            UnityC.RegisterType<IAccountsRepository, AccountsRepository>(new HierarchicalLifetimeManager());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var unitOfWork = UnityC.Resolve<IUnitOfWork>();
            var accountsRepository = UnityC.Resolve<IAccountsRepository>();
            var signupForm = new SignUpForm(unitOfWork, accountsRepository);
            Application.Run(signupForm);

            // Application.Run(new SubscribersForm(ConnectedSubscribersRepository));
        }
    }
}