
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class StockRepository : IStockRepository
{

    private IEnumerable<Stock> _stock;
    public StockRepository()
    {
        _stock = new DatabaseContext().stock;
    }


    public IEnumerable<Stock> CreateOne(Stock newProduct)
    {
        IEnumerable<Stock> newStock = _stock.Append(newProduct);
        _stock = newStock;
        return _stock;
    }

    // public IEnumerable<Stock> EditeOne()
    // {
    //     throw new NotImplementedException();
    // }

    public IEnumerable<Stock> FindAll()
    {
        return _stock;
    }

    public IEnumerable<Stock> FindByProductId(int productId)
    {
        // 
        return _stock.Where(item => item.ProductId == productId);

    }
    public Stock? FindById(int id)
    {
        // 
        return _stock.FirstOrDefault(item => item.Id == id);

    }

    public IEnumerable<Stock> DeletOneById(int id)
    {
        IEnumerable<Stock> filteredStock = _stock.Where(item => item.Id != id);
        return _stock = filteredStock;
    }
    public IEnumerable<Stock> DeletProductById(int productId)
    {
        IEnumerable<Stock> filteredStock = _stock.Where(item => item.ProductId != productId);
        return _stock = filteredStock;
    }

    // public IEnumerable<Stock> EditItem(int id)
    // {
    //     throw new NotImplementedException();
    // }
}
