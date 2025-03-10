using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Infastructure.Repositories;
using Unity;
using Unity.Lifetime;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views;
using Microsoft.EntityFrameworkCore;

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
            UnityC.RegisterType<IUnitOfWork,UnitOfWork>(new HierarchicalLifetimeManager());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.



         // var ConnectedSubscribersRepository = UnityC.Resolve<IConnectedSubscribersRepository>();

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var unitOfWork = UnityC.Resolve<IUnitOfWork>();
            var Subs = new MainForm(unitOfWork);
        // new AppUserFormPresenter(unitOfWork, appUserForm);
            Application.Run(Subs);

            //var dbContext = new AppDbContext(new DbContextOptions<AppDbContext>());
            //var accountsRepository = new AccountsRepository(dbContext);
            //var unitOfWork = new UnitOfWork(dbContext);

            //var loginForm = new LoginForm();
            //new LoginPresenter(loginForm, unitOfWork, accountsRepository);

            //Application.Run(loginForm);





            // Application.Run(new SubscribersForm(ConnectedSubscribersRepository));
        }
    }
}