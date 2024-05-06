
namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class OrderItem
    {
        public Guid OrderId { get; set;}
        public Guid StockId { get; set;}
        public int Quantity { get; set;}
    }
}