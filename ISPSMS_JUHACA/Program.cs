
using System;
using System.Windows.Forms;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Presenter;
using Infastructure.Data.Repositories;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Microsoft.EntityFrameworkCore;
using Unity.Lifetime;
using Unity;

namespace ISPSMS_JUHACA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbContext = new AppDbContext(new DbContextOptions<AppDbContext>());
            var accountsRepository = new AccountsRepository(dbContext);
            var unitOfWork = new UnitOfWork(dbContext);

            var loginForm = new LoginForm();
            new LoginPresenter(loginForm, unitOfWork, accountsRepository);

            Application.Run(loginForm);
        }
    }
}


