
namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Stock
    {


        public Stock(int id, int productId, int stockQuantity, int price, string color, char size)
        {
            Id = id;
            ProductId = productId;
            StockQuantity = stockQuantity;
            Price = price;
            Color = color;
            Size = size;
        }


        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public char Size { get; set; }



    }
}