using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IStockService
{
    public IEnumerable<Stock> FindAll();
    public IEnumerable<Stock> FindByProductId(int productId);
    public Stock? FindById(int id);
    public IEnumerable<Stock> CreateOne(Stock newProduct);
    public IEnumerable<Stock> DeletOneById(int id);
    public IEnumerable<Stock> DeletProductById(int productId);
    // public IEnumerable<Stock> EditQuantity(int id);
    // public IEnumerable<Stock> EditeOne();


}
