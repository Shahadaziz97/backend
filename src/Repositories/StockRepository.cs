
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class StockRepository : IStockRepository
{

    private IEnumerable<Stock> _stock;
    public StockRepository(DatabaseContext databaseContext)
    {
        _stock = databaseContext.Stock;
    }


    public Stock CreateOne(Stock newProduct)
    {
        // var newStock = _stock.Append(newProduct);

        return newProduct;
    }

    // public IEnumerable<Stock> EditeOne()
    // {
    //     throw new NotImplementedException();
    // }

    public IEnumerable<Stock> FindAll()
    {
        return _stock;
    }

    public IEnumerable<Stock> FindByProductId(Guid productId)
    {
        // 
        return _stock.Where(item => item.ProductId == productId);

    }
    public Stock? FindById(Guid id)
    {
        // 
        return _stock.FirstOrDefault(item => item.Id == id);

    }

    public IEnumerable<Stock> DeletOneById(Guid id)
    {
        IEnumerable<Stock> filteredStock = _stock.Where(item => item.Id != id);
        return _stock = filteredStock;
    }
    public IEnumerable<Stock> DeletProductById(Guid productId)
    {
        IEnumerable<Stock> filteredStock = _stock.Where(item => item.ProductId != productId);
        return _stock = filteredStock;
    }

    // public IEnumerable<Stock> EditItem(int id)
    // {
    //     throw new NotImplementedException();
    // }
}
