using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface ITransactionsRepository : IRepository<Transactions>
    {
        float AnahawonTotalPaidAmount();
        float BaseCampTotalPaidAmount();
        float Camp1TotalPaidAmount();
        float ColambugonTotalPaidAmount();
        float DanggawanTotalPaidAmount();
        float DologonTotalPaidAmount();
        Task<IEnumerable<Transactions>> GetAllAsync();  // Change List<T> to IEnumerable<T>
        Task<IEnumerable<Transactions>> GetByDateAsync(DateTime date);
        Task<IEnumerable<Transactions>> GetPaginatedAsync(int pageNumber, int pageSize, bool orderByDescending);
        Task<IEnumerable<(DateTime Date, decimal TotalAmount)>> GetDailyTransactionTotalsAsync();
        Task<int> GetTotalCountAsync();
        Task<decimal> GetTotalPaidAmountAsync();
        float NorthTotalPaidAmount();
        float PanadtalanTotalPaidAmount();
        float SanMiguelTotalPaidAmount();
        float SouthTotalPaidAmount();
        void Update(Transactions obj);


    }
}




   
      
    
