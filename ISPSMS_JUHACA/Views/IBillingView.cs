using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Views.IVews
{
    public interface IBillingView
    {
       // void FilterData(string searchText);
        void ShowLoadingIndicator(bool show);
        void DisplaySubscribers(List<ConnectedSubscribers> subscribers, int start, int end, int totalItems);
        void EnablePagination(bool enableNext, bool enablePrev);
    }
}