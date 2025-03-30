using System;
using System.Collections.Generic;
using Domain.Models;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface ITransactionView
    {

        public void DisplayTransactions(IEnumerable<Transactions> transactions, bool filterByDate = true);

        void UpdatePaidAmountLabel(decimal totalPaidAmount);

        void SetPaginationButtons(bool enablePrevious, bool enableNext);
        void SetPaginationStatusText(string statusText);
        void SetPaginationData(int currentPage, int pageSize, int totalItems);



    }
}