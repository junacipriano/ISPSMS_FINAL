using System;
using System.Collections.Generic;
using Domain.Models;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface ITransactionView
    {

        void DisplayTransactions(IEnumerable<Transactions> transactions);
        void UpdatePaidAmountLabel(decimal totalPaidAmount);

        void SetPaginationButtons(bool enablePrevious, bool enableNext);
    }
}