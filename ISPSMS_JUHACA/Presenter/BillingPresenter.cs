using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;

public class BillingPresenter
{
    private readonly IBillingView _view;
    private readonly IUnitOfWork _dbContext;
    private int _currentPage = 1;
    private const int ItemsPerPage = 20;
    private int _totalItems;

    public BillingPresenter(IBillingView view, IUnitOfWork dbContext)
    {
        _view = view;
        _dbContext = dbContext;
    }

    public async Task LoadBillingItemsAsync(int page = 1)
    {
        _view.ShowLoadingIndicator(true);
        _currentPage = page;

        _totalItems = await Task.Run(() => _dbContext.connectedSubscriberRepository.GetAll().Count());
        var subscribers = await Task.Run(() =>
            _dbContext.connectedSubscriberRepository
            .GetAll()
            .OrderBy(sub => sub.CurrentDuedate)
            .Skip((_currentPage - 1) * ItemsPerPage)
            .Take(ItemsPerPage)
            .ToList()
        );

        _view.ShowLoadingIndicator(false);
        int start = ((_currentPage - 1) * ItemsPerPage) + 1;
        int end = start + subscribers.Count - 1;
        _view.DisplaySubscribers(subscribers, start, end, _totalItems);
        _view.EnablePagination(subscribers.Count == ItemsPerPage, _currentPage > 1);
    }

    public async Task NextPage()
    {
        _currentPage++;
        await LoadBillingItemsAsync(_currentPage);
    }

    public async Task PreviousPage()
    {
        if (_currentPage > 1)
        {
            _currentPage--;
            await LoadBillingItemsAsync(_currentPage);
        }
    }

    public async void FilterData(string searchText)
    {
        _view.ShowLoadingIndicator(true);

        var subscribers = await Task.Run(() =>
            _dbContext.connectedSubscriberRepository
            .GetAll()
            .Where(sub =>
                sub.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                sub.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            .OrderBy(sub => sub.CurrentDuedate)
            .ToList()
        );

        _view.ShowLoadingIndicator(false);
        _view.DisplaySubscribers(subscribers, 1, subscribers.Count, subscribers.Count);
        _view.EnablePagination(false, false);
    }

    public IUnitOfWork GetDbContext()
    {
        return _dbContext;
    }
}
