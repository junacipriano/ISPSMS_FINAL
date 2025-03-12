using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Views.IVews
{
    namespace ISPSMS_JUHACA.Views.IVews
    {
        public interface IEditAccountView
        {
            string Username { get; set; }
            string AccountName { get; set; }
            string Password { get; set; }
            string ConfirmPassword { get; set; }
            string AccountRole { get; set; }
            string CurrentUserRole { get; }
            void ShowMessage(string message, string caption);
            void CloseForm();
        }
    }
}
