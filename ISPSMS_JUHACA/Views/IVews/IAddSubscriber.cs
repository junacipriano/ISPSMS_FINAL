using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface IMainSubscriberPage
    {

        event EventHandler SaveSubscriber;
        event EventHandler FormLoaded;

        string LastName { get; set; }
        string FirstName { get; set; }
        string MiddleInitial { get; set; }
        string District { get; set; }
        string Barangay { get; set; }
        string Plan { get; set; }
        string ContactNumber { get; set; }
        decimal MonthlyCharge { get; set; }
        DateTime DueDate { get; set; }

        void ShowMessage(string message);
        void CloseForm();
    }
}
