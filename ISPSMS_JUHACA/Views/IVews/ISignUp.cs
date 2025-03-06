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
        string AccountEmail { get; set; }
        string AccountPhone { get; set; }
        string AccountAddress { get; set; }
       
        void ShowMessage(string message);
        event EventHandler Save; // Add this line to define the Save event
    }
}
