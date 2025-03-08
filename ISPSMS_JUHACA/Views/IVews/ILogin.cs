using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface ILogin
    {
        string Username { get; set; }
        string AccountPassword { get; set; }
        event EventHandler Login;
        event EventHandler SignUp;
        void ShowMessage(string message);
        void ShowError(string message);
        void CloseForm();
        void Hide();
    }
}