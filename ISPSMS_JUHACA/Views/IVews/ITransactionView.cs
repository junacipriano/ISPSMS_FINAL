using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface ITransactionView
    {
        void DisplayTransactions(List<Transactions> transactions);
    }
}
