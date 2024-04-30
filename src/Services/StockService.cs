
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class StockService : IStockService
{

    private IStockRepository _stockRepository;
    public StockService(IStockRepository stockRepository)
    {
        _stockRepository = stockRepository;
    }

    public IEnumerable<Stock> CreateOne(Stock newProduct)
    {

        return _stockRepository.CreateOne(newProduct);
    }

    // public IEnumerable<Stock> EditeOne()
    // {
    //     throw new NotImplementedException();
    // }

    public IEnumerable<Stock> FindAll()
    {
        return _stockRepository.FindAll();
    }

    public IEnumerable<Stock> FindByProductId(int productId)
    {
        // 
        return _stockRepository.FindByProductId(productId);

    }
    public Stock? FindById(int id)
    {
        // 
        return _stockRepository.FindById(id);

    }

    public IEnumerable<Stock> DeletOneById(int id)
    {

        return _stockRepository.DeletOneById(id);
    }
    public IEnumerable<Stock> DeletProductById(int productId)
    {
        return _stockRepository.DeletProductById(productId);
    }

    // public IEnumerable<Stock> EditItem(int id)
    // {
    //     throw new NotImplementedException();
    // }
}
