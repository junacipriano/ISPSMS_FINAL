using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface ISignUp
    {
        string Username { get; set; }
        string AccountName { get; set; }
        string AccountPassword { get; set; }
        string AccountRole { get; set; }
        void ShowMessage(string message);
        void ShowError(string message);
        event EventHandler Save;
    }
}